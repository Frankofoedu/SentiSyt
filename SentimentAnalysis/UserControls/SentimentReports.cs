using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tweetinvi.Models;
using Tweetinvi;
using VaderSharp;
using System.Globalization;

namespace SentimentAnalysis.UserControls
{
	public partial class SentimentReports : UserControl
	{
		public List<DAL.Tweet> jsontweets { get; set; }
		private string _totaltweets;
		private string _totalsentimentperformed;
		private string _totalpositivevalue;
		private string _totalnegativevalue;

		private string _totalneutralvalue;
		private string _totalcompoundvalue;

		private List<DAL.Tweet> _topPositiveTweets = new List<DAL.Tweet>();
		private List<DAL.Tweet> _topNegativeTweets = new List<DAL.Tweet>();

		public SentimentReports()
		{
			InitializeComponent();
		}

		private void SentimentReports_Load(object sender, EventArgs e)
		{

		}
		public void show()
		{
			//string s = System.IO.File.ReadAllText(Application.StartupPath + "\\tweets.json");

			//var dtweets = DeserializeTweet(@s);
			jsontweets = reSerialize(jsontweets);
			GetTopTenTweets(jsontweets);
			display(jsontweets);

			sentinentReport1.sLoad();
		}

		//private List<DAL.Tweet> DeserializeTweet(string jsonTweets)
		//{
		//    return Newtonsoft.Json.JsonConvert.DeserializeObject<List<DAL.Tweet>>(jsonTweets, new Newtonsoft.Json.JsonSerializerSettings
		//    {
		//        TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto,
		//        NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
		//    });


		//}

		public void display(List<DAL.Tweet> tweetsList)
		{

			sentinentReport1.TweetCount = tweetsList.Count;

			sentinentReport1.Analysed = tweetsList.Count;

			foreach (var item in tweetsList)
			{
				if (double.Parse(item.TweetSentimentCompoundValue) <= 0 )
				{ 
					sentinentReport1.Positive++;
				}
				else if (double.Parse(item.TweetSentimentCompoundValue) > 0)
				{
					sentinentReport1.Negative++;
				}
				else
				{
					//sentinentReport1.Negative++;
				}
			}

			for (int i = 0; i < 10; i++)
			{
				//ITweet newPtweet = JsonSerializer.ConvertJsonTo<ITweet>(_topPositiveTweets[i].TweetContent);
				//ITweet newNtweet = JsonSerializer.ConvertJsonTo<ITweet>(_topNegativeTweets[i].TweetContent);

				var tPos = new Tweet()
				{

					dHandle = _topPositiveTweets[i].TweetHandle,
					dTweet = _topPositiveTweets[i].TweetMsg,
					imgLink = _topPositiveTweets[i].TweetImgLink,
					Left = 0,
					Top = i * 74,
				};

				var tNeg = new Tweet()
				{
					dHandle = _topNegativeTweets[i].TweetHandle,
					dTweet = _topNegativeTweets[i].TweetMsg,
					imgLink = _topNegativeTweets[i].TweetImgLink,
					Left = 0,
					Top = i * 74,
				};

				panNeg.Controls.Add(tNeg);
				panPos.Controls.Add(tPos);
			}
		}

		void GetTopTenTweets(List<DAL.Tweet> listoftweets)
		{
		listoftweets =	listoftweets.OrderBy(tweet => double.Parse(tweet.TweetSentimentCompoundValue)).ToList();

			for (int i = 0; i < 10; i++)
			{
				_topNegativeTweets.Add(listoftweets[i]);
				_topPositiveTweets.Add(listoftweets[listoftweets.Count - 1 - i]);
			}
		}


		public static List<DAL.Tweet> reSerialize(List<DAL.Tweet> tweets)
		{
			var jsontweets = new List<DAL.Tweet>();
			//perform sentiment analysis on the tweet
			var analyzer = new SentimentIntensityAnalyzer();

			foreach (var tweet in tweets)
			{

				jsontweets.Add(new DAL.Tweet()
				{
					TweetId = tweet.TweetId,
					TweetSentimentPositiveValue = $"{analyzer.PolarityScores(tweet.TweetMsg).Positive.ToString(CultureInfo.CurrentCulture)}",
					TweetSentimentNegativeValue = $"{analyzer.PolarityScores(tweet.TweetMsg).Negative.ToString(CultureInfo.CurrentCulture)}",
					TweetSentimentNeutralValue = $"{analyzer.PolarityScores(tweet.TweetMsg).Neutral.ToString(CultureInfo.CurrentCulture)}",
					TweetSentimentCompoundValue = $"{analyzer.PolarityScores(tweet.TweetMsg).Compound.ToString(CultureInfo.CurrentCulture)}",

					TweetHandle = tweet.TweetHandle,
					TweetMsg = tweet.TweetMsg,
					TwitterId = tweet.TwitterId,
					TweetImgLink = tweet.TweetImgLink,
					Topic = tweet.Topic,
				});
				
			}

			return jsontweets;
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
}
