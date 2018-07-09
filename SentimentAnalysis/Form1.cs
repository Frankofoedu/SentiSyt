using SentimentAnalysis.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Runtime;

// REST API
using Tweetinvi;
using Tweetinvi.Core.Events;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

// STREAM API
using Tweetinvi.Streaming;
using Stream = Tweetinvi.Stream;

// Others
using Tweetinvi.Exceptions; // Handle Exceptions
using Tweetinvi.Core.Extensions;
using Tweetinvi.Core.Public.Parameters;
// Extension methods provided by Tweetinvi
using Tweetinvi.Models.DTO; // Data Transfer Objects for Serialization
using Tweetinvi.Json;
using Tweet = Tweetinvi.Logic.Tweet;
using System.Threading;
using Newtonsoft.Json.Linq;
using VaderSharp;
using Bunifu.Framework.UI;

// JSON static classes to get json from Twitter.

namespace SentimentAnalysis
{
	public partial class Form1 : BunifuForm
	{
		public static List<DAL.Tweet> jsontweets;
		private IAuthenticatedUser _authenticatedUser;
		private const string ConsumerKey = "AHaR1PW1TeoebTEEWueZp7A5N";
		private const string ConsumerSecret = "idenId4i5d45Uio8Icro6mX9SiuoTxTUID5VEf6A8PkPirJKtG";
		private const string UserAccessToken = "1076291598-sPjUUo8JlhuYOrqCYgAKOurtyXdY1bk9OF4X1cV";
		private const string UserAccessSecret = "YsMDRtdHncfKj4eZnBD4qZ27o2ZoanyAbZL2PRht3YzX9";
		private const string CountryCode = "59b27337f38d658b";

		private readonly SynchronizationContext synchronizationContext;


		int TotalHeight;
		RiveScript.RiveScript bot = new RiveScript.RiveScript();

		public Form1()
		{
			InitializeComponent();
			synchronizationContext = SynchronizationContext.Current;
			//application settings for tweetinvi
			TweetinviConfig.ApplicationSettings.HttpRequestTimeout = 200000;
			TweetinviConfig.CurrentThreadSettings.TweetMode = TweetMode.Extended;
			TweetinviConfig.ApplicationSettings.TweetMode = TweetMode.Extended;

			bot.loadFile(@".\bot.rive");
			bot.sortReplies();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			ActiveForm?.Hide();
		}




		private async void btnTwitterLogin_Click(object sender, EventArgs e)
		{
			//progressBar1.Visible = true;
			myPreloader1.Visible = true;
			btnTwitterLogin.Enabled = false;
			btnTwitterLogin.TextAlign = ContentAlignment.MiddleCenter;
			btnTwitterLogin.ButtonText = "loggin in";

			await Task.Run(() =>
				{
					login(false);

				});

			//progressBar1.Visible = false;

			myPreloader1.Visible = false;
			//btnTwitterLogin.Text = @"Logged in as " + _authenticatedUser.ScreenName;
			btnGetTweets.Enabled = _authenticatedUser != null;
			btnViewResults.Enabled = _authenticatedUser != null;

		}

		void login(bool fromBot)
		{
			
			try
			{
				Auth.SetUserCredentials
				(
					ConsumerKey,
					ConsumerSecret,
					UserAccessToken,
					UserAccessSecret
					);
				_authenticatedUser = User.GetAuthenticatedUser();
				if (_authenticatedUser == null)
				{
					var latestexception = ExceptionHandler.GetLastException();
					MessageBox.Show(latestexception.TwitterDescription);

					if (fromBot)
					{ 
						var reply = bot.reply("local_user", "login failed");
						newPanel(false, "(bot) : " + reply);
					}
				}
				else
				{
					MessageBox.Show("Logged In as " + _authenticatedUser.ScreenName);
					if (fromBot)
					{
						var reply = bot.reply("local_user", "login complete");
						newPanel(false, "(bot) : " + reply);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(@"Something went wrong when we tried to execute the http request : '{0}'", ex.Message);

				if (fromBot)
				{
					var reply = bot.reply("local_user", "login failed");
					newPanel(false, "(bot) : " + reply);
				}
			}
			
		}
		private void btnGetTweets_Click(object sender, EventArgs e)
		{
			if (ddlLocations.selectedIndex != -1)
			{

				if (!txtSearchTwitter.Text.IsNullOrEmpty())
				{
					switch (ddlLocations.selectedValue)
					{
						case "Lagos":
							var gc1 = new GeoCode(6.5244, 3.3792, 100, DistanceMeasure.Kilometers);
							GetAllTweets(txtSearchTwitter.Text, false);//gc1);
							break;
						case "Abuja":
							var gc2 = new GeoCode(9.072, 7.491, 100, DistanceMeasure.Kilometers);
							GetAllTweets(txtSearchTwitter.Text, false);//gc2);
							break;
						case "Awka":
							{
								var gc3 = new GeoCode(6.2220, 7.0821, 100, DistanceMeasure.Kilometers);
								GetAllTweets(txtSearchTwitter.Text, false);//gc3);
								break;
							}
						default:
							{
								MessageBox.Show(@"Please select an area");
								break;
							}
					}
				}
				else
				{
					txtSearchTwitter.Focus();
					MessageBox.Show(@"Please provide search parameters");


				}
			}
			else
			{
				MessageBox.Show(@"please select a location");
			}

		}

		private async void GetAllTweets(string SearchText, bool fromBot)//GeoCode geoCode)
		{
			IEnumerable<ITweet> tweets;

			string result = "";

			myPreloader1.Visible = true;
			await Task.Run(() =>
				 {
					 try
					 {
						 //var sp = new SearchTweetsParameters(geoCode)
						 //{
						 //    SearchQuery = txtSearchTwitter.Text,
						 //    Fil
						 //    //FilterTweetsNotContainingGeoInformation = true
						 //};


						 tweets = Search.SearchTweets(new SearchTweetsParameters(SearchText)
						 {
							 TweetSearchType = TweetSearchType.OriginalTweetsOnly
						 });


						 // var tweets = Search.SearchTweets(sp);



						 //foreach (var tweet in tweets)
						 //{
						 //    var t = new DAL.Tweet
						 //    {
						 //        TweetId = tweet.Id.ToString(),
						 //        TweetContent = tweet.Text,
						 //        TweetCreatedDate = tweet.TweetLocalCreationDate.ToString
						 //            (CultureInfo.InvariantCulture),
						 //        TweetOwnerName = tweet.CreatedBy.ScreenName
						 //    };

						 //}

						 if (tweets.Count() < 1)
						 {
							 MessageBox.Show("E dinor work. " + ExceptionHandler.GetLastException().TwitterDescription);

							 if (fromBot)
							 {
								 result = "Error fetching tweets";
							 }
							 return;
						 }

						 Serialize(tweets, txtSearchTwitter.Text);
						 MessageBox.Show("tweets saved");
						 
						 if (fromBot)
						 {
							 result = "Tweets downloaded successfully";
						 }

					 }
					 catch (ArgumentException argumentException)
					 {
						 MessageBox.Show(@"Request parameters are invalid: '{0}'", argumentException.Message);

						 if (fromBot)
						 {
							 result = "Error fetching tweets";
						 }

					 }
					 catch (TwitterException twitterException)
					 {
						 MessageBox.Show(@"An error occured while connecting to twitter API : '{0}'", twitterException.Message);

						 if (fromBot)
						 {
							 result = "Error fetching tweets";
						 }

					 }
				 });
			displaynReply(result);
			Cursor = Cursors.Arrow;
			myPreloader1.Visible = false;
		}

		public static void Serialize(IEnumerable<ITweet> tweets, string topic)
		{
			jsontweets = new List<DAL.Tweet>();
			//perform sentiment analysis on the tweet
			var analyzer = new SentimentIntensityAnalyzer();

			using (var db = new SentimentContext())
			{
				if (db.Tweets.Count() > 1) { db.Tweets.RemoveRange(db.Tweets); }

				foreach (var tweet in tweets)
				{
					var check = db.Tweets.Where(x=>x.TwitterId == tweet.Id).FirstOrDefault();
					if (check == null)
					{

						jsontweets.Add(new DAL.Tweet()
						{
							TweetId = DateTime.Now.ToString(CultureInfo.CurrentCulture),

							//TweetContent = tweet.ToJson(),


							TweetHandle = tweet.CreatedBy.ScreenName,
							TweetMsg = tweet.FullText,
							TwitterId = tweet.Id,
							TweetImgLink = tweet.CreatedBy.ProfileImageUrl400x400,
							Topic = topic,

							TweetSentimentPositiveValue = $"{analyzer.PolarityScores(tweet.FullText).Positive.ToString(CultureInfo.CurrentCulture)}",
							TweetSentimentNegativeValue = $"{analyzer.PolarityScores(tweet.FullText).Negative.ToString(CultureInfo.CurrentCulture)}",
							TweetSentimentNeutralValue = $"{analyzer.PolarityScores(tweet.FullText).Neutral.ToString(CultureInfo.CurrentCulture)}",
							TweetSentimentCompoundValue = $"{analyzer.PolarityScores(tweet.FullText).Compound.ToString(CultureInfo.CurrentCulture)}",

						});
					
					}

					db.Tweets.AddRange(jsontweets);
				}

				db.SaveChanges();
				//var serializer = new Newtonsoft.Json.JsonSerializer();
				//serializer.NullValueHandling = NullValueHandling.Ignore;
				//serializer.TypeNameHandling = TypeNameHandling.Auto;
				//serializer.Formatting = Formatting.Indented;


				//using (var sw = new StreamWriter(@".\tweets.json", true))
				//{
				//    using (JsonWriter jwriter = new JsonTextWriter(sw))
				//    {
				//        serializer.Serialize(jwriter, jsontweets, typeof(List<DAL.Tweet>));
				//    }
				//}
				
			}
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void sentimentReports1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			animPan.HideSync(panel2);
		}

		private void btnViewResults_Click(object sender, EventArgs e)
		{
			displayResult();

			animPan.HideSync(panMain);
			animPan.ShowSync(panel2);
		}

		void displayResult()
		{
			Cursor = Cursors.WaitCursor;
			using (var db = new DAL.SentimentContext())
			{
				jsontweets = db.Tweets.ToList();
			}

			sentimentReports1.jsontweets = jsontweets;
			sentimentReports1.show();

			Cursor = Cursors.WaitCursor;

		}

		private void btnBot_Click(object sender, EventArgs e)
		{
			animPan.HideSync(panMainSmall);
			animPan.ShowSync(panBotChat);
		}

		void displaynReply(string msg)
		{
			newPanel(true, "(you) : " + msg);

			string reply = bot.reply("local_user", msg);

			if (reply.StartsWith("command: "))
			{
				reply = reply.Replace("command: ", "");

				if (reply.Contains("login to twitter"))
				{
					newPanel(false, "(bot) : " + "Logging in to twitter.");
					login(true);

				}
				else if (reply.Contains("perform analysis on"))
				{
					Cursor = Cursors.AppStarting;

					string topic = reply.Replace("perform analysis on ", "");
					newPanel(false, "(bot) : " + "Please wait while I fetch Tweets about \"" + topic + "\".");

					GetAllTweets(topic, true);
				}
				else if  (reply.Contains ("show report"))
				{
					newPanel(false, "(bot) : " + "Showing Report.");
					displayResult();

					animPan.HideSync(panMain);
					animPan.ShowSync(panel2);
				}
			}
			else { newPanel(false, "(bot) : " + reply); }



		}
		private void btnSend_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			displaynReply(rtbMsg.Text);
			rtbMsg.Text = "";

			Cursor = Cursors.Arrow;
		}
		
		private void newPanel(bool human, string msg)
		{
			Panel pan = new Panel();
			pan.BackColor = Color.FromArgb(14, 36, 50);
			pan.ForeColor = Color.White;

			pan.Top = TotalHeight;
			//pan.Tag = id;
			Label lbl = newLabel();

			SizeF s = TextRenderer.MeasureText(msg, lbl.Font);
			if (s.Width < (PanAllMsgs.Width / 2) - 10)
			{
				pan.Width = (int)Math.Ceiling(s.Width) + 10;
				pan.Height = (int)Math.Ceiling(s.Height) + 10;
				lbl.Width = (int)Math.Ceiling(s.Width);
				lbl.Height = (int)Math.Ceiling(s.Height);

			}
			else
			{
				s = TextRenderer.MeasureText(msg, lbl.Font, new Size((PanAllMsgs.Width / 2) - 10, int.MaxValue));

				pan.Width = (int)Math.Ceiling(s.Width) + 10;
				pan.Height = (int)Math.Ceiling(s.Height) + 10;
				lbl.Width = (int)Math.Ceiling(s.Width);
				lbl.Height = (int)Math.Ceiling(s.Height);
			}

			lbl.Text = msg;
			TotalHeight += pan.Height;
			pan.Controls.Add(lbl);

			lbl.Left = 5;
			lbl.Top = 5;
			//pan.Click += Pan_Click;

			PanAllMsgs.Controls.Add(pan);
			pan.BorderStyle = BorderStyle.FixedSingle;
			if (human)
			{
				pan.Left = 5;
			}
			else
			{
				pan.Left = PanAllMsgs.Width - pan.Width - 5;
			}

		}

		private Label newLabel()
		{
			Label lbl = new Label();
			lbl.TextAlign = ContentAlignment.MiddleLeft;
			lbl.Font = new Font("Lucida Sans", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			//lbl.Tag = msgObject;

			//pan.Click += Pan_Click;
			return lbl;
		}

		private void rtbMsg_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(rtbMsg.Text))
			{
				if (btnSend.Enabled)
				{
					btnSend.Enabled = false;
				}
			}
			else
			{
				if (!btnSend.Enabled)
				{
					btnSend.Enabled = true;
				}
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			animPan.HideSync(panBotChat);
			animPan.ShowSync(panMainSmall);
		}

		private void lblCloseReport_Click(object sender, EventArgs e)
		{
			animPan.HideSync(panel2);
			animPan.ShowSync(panMain);
		}
	}
}
