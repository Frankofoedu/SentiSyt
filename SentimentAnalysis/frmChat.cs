using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RiveScript;

namespace SentimentAnalysis
{
	public partial class frmChat : Form
	{
		RiveScript.RiveScript bot = new RiveScript.RiveScript();
		public frmChat()
		{
			InitializeComponent();

			bot.loadFile(@".\bot.rive");
			bot.sortReplies();
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			listMessages.Items.Add("(You) : " + txtMsg.Text);

			var reply = bot.reply("local_user", txtMsg.Text);

			listMessages.Items.Add("(bot) : " + reply);
		}
	}
}
