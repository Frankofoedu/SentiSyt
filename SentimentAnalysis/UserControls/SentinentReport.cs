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
    public partial class SentinentReport : UserControl
    {
        public int TweetCount { get; set; }
        public int Analysed { get; set; }
        public int Positive { get; set; }
        public int Negative { get; set; }

        public SentinentReport()
        {
            InitializeComponent();
        }

        private void SentinentReport_Load(object sender, EventArgs e)
        {

        }

        public void sLoad()
        {
            lblAnalysed.Text = Analysed.ToString();
            lblNegative.Text = Negative.ToString();
            lblPositive.Text = Positive.ToString();
            lblTweetCount.Text = TweetCount.ToString();
        }
    }
}
