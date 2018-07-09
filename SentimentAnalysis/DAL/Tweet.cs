using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi.Models;
using Newtonsoft.Json;

namespace SentimentAnalysis.DAL
{

	public class Tweet
	{
		public int Id { get; set; }
		/// <summary>
		/// get id or set the current date as id
		/// </summary>

		public string TweetId { get; set; }

		/// <summary>
		/// contents of the tweet
		/// </summary>
		//internal string TweetContent { get; set; }
		/// <summary>
		/// stores the sentiment value in the following format: 
		/// Positive score(int)
		/// </summary>

		public string TweetSentimentPositiveValue { get; set; }

		/// <summary>
		/// stores the sentiment value in the following format: 
		///  Negative score(int)
		/// </summary>


		public string TweetSentimentNegativeValue { get; set; }
		/// <summary>
		/// stores the sentiment value in the following format: 
		/// Neutral score(int)
		/// </summary>
		public string TweetSentimentNeutralValue { get; set; }
		/// <summary>
		/// stores the sentiment value in the following format: 
		/// Compound Score(int)
		/// </summary>
		public string TweetSentimentCompoundValue { get; set; }

		public string Topic { get; set; }

		public string TweetMsg { get; set; }

		public string TweetHandle { get; set; }

		public string TweetImgLink { get; set; }

		public long TwitterId { get; set; }
	}
}
