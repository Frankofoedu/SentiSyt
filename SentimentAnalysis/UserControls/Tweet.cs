using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentimentAnalysis.UserControls
{
	public partial class Tweet : UserControl
	{
		public string dHandle { get; set; }
		public string dTweet { get; set; }
		public string imgLink { get; set; }
		public Tweet()
		{
			InitializeComponent();
		}

		private void Tweet_Load(object sender, EventArgs e)
		{
			lblHandle.Text = "@" + dHandle;
			lblTweet.Text = dTweet;
			picPic.LoadAsync(imgLink);
		}
	}
}
