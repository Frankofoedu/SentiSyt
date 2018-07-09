namespace SentimentAnalysis
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.animPan = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.txtSearchTwitter = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.panMain = new System.Windows.Forms.Panel();
			this.panBotChat = new System.Windows.Forms.Panel();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnSend = new System.Windows.Forms.Button();
			this.rtbMsg = new System.Windows.Forms.RichTextBox();
			this.PanAllMsgs = new System.Windows.Forms.Panel();
			this.panMainSmall = new System.Windows.Forms.Panel();
			this.btnBot = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnTwitterLogin = new Bunifu.Framework.UI.BunifuThinButton2();
			this.ddlLocations = new Bunifu.Framework.UI.BunifuDropdown();
			this.btnGetTweets = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnViewResults = new Bunifu.Framework.UI.BunifuThinButton2();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lblCloseReport = new System.Windows.Forms.Label();
			this.sentimentReports1 = new SentimentAnalysis.UserControls.SentimentReports();
			this.myPreloader1 = new SentimentAnalysis.UserControls.MyPreloader();
			this.panel1.SuspendLayout();
			this.panMain.SuspendLayout();
			this.panBotChat.SuspendLayout();
			this.panMainSmall.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.animPan.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(871, 52);
			this.panel1.TabIndex = 0;
			// 
			// label3
			// 
			this.animPan.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(780, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 36);
			this.label3.TabIndex = 2;
			this.label3.Text = "-";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.animPan.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(811, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 36);
			this.label2.TabIndex = 1;
			this.label2.Text = "X";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.animPan.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(66, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "SENTINET";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.panel1;
			this.bunifuDragControl1.Vertical = true;
			// 
			// animPan
			// 
			this.animPan.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
			this.animPan.Cursor = null;
			animation1.AnimateOnlyDifferences = true;
			animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
			animation1.LeafCoeff = 0F;
			animation1.MaxTime = 1F;
			animation1.MinTime = 0F;
			animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
			animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
			animation1.MosaicSize = 0;
			animation1.Padding = new System.Windows.Forms.Padding(0);
			animation1.RotateCoeff = 0F;
			animation1.RotateLimit = 0F;
			animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
			animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
			animation1.TimeCoeff = 0F;
			animation1.TransparencyCoeff = 0F;
			this.animPan.DefaultAnimation = animation1;
			this.animPan.Interval = 15;
			// 
			// label4
			// 
			this.animPan.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(310, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 38);
			this.label4.TabIndex = 3;
			this.label4.Text = "Twitter Login";
			// 
			// txtSearchTwitter
			// 
			this.txtSearchTwitter.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.animPan.SetDecoration(this.txtSearchTwitter, BunifuAnimatorNS.DecorationType.None);
			this.txtSearchTwitter.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txtSearchTwitter.ForeColor = System.Drawing.Color.White;
			this.txtSearchTwitter.HintForeColor = System.Drawing.Color.Gainsboro;
			this.txtSearchTwitter.HintText = "Enter Search Term";
			this.txtSearchTwitter.isPassword = false;
			this.txtSearchTwitter.LineFocusedColor = System.Drawing.Color.Blue;
			this.txtSearchTwitter.LineIdleColor = System.Drawing.Color.Gray;
			this.txtSearchTwitter.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.txtSearchTwitter.LineThickness = 3;
			this.txtSearchTwitter.Location = new System.Drawing.Point(274, 206);
			this.txtSearchTwitter.Margin = new System.Windows.Forms.Padding(4);
			this.txtSearchTwitter.Name = "txtSearchTwitter";
			this.txtSearchTwitter.Size = new System.Drawing.Size(183, 34);
			this.txtSearchTwitter.TabIndex = 6;
			this.txtSearchTwitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// panMain
			// 
			this.panMain.Controls.Add(this.panBotChat);
			this.panMain.Controls.Add(this.panMainSmall);
			this.animPan.SetDecoration(this.panMain, BunifuAnimatorNS.DecorationType.None);
			this.panMain.Dock = System.Windows.Forms.DockStyle.Right;
			this.panMain.Location = new System.Drawing.Point(12, 52);
			this.panMain.Name = "panMain";
			this.panMain.Size = new System.Drawing.Size(859, 509);
			this.panMain.TabIndex = 3;
			// 
			// panBotChat
			// 
			this.panBotChat.Controls.Add(this.btnBack);
			this.panBotChat.Controls.Add(this.btnSend);
			this.panBotChat.Controls.Add(this.rtbMsg);
			this.panBotChat.Controls.Add(this.PanAllMsgs);
			this.animPan.SetDecoration(this.panBotChat, BunifuAnimatorNS.DecorationType.None);
			this.panBotChat.Location = new System.Drawing.Point(126, 26);
			this.panBotChat.Name = "panBotChat";
			this.panBotChat.Size = new System.Drawing.Size(610, 448);
			this.panBotChat.TabIndex = 13;
			this.panBotChat.Visible = false;
			// 
			// btnBack
			// 
			this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBack.BackColor = System.Drawing.Color.White;
			this.animPan.SetDecoration(this.btnBack, BunifuAnimatorNS.DecorationType.None);
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
			this.btnBack.Location = new System.Drawing.Point(508, 375);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(76, 70);
			this.btnBack.TabIndex = 5;
			this.btnBack.Text = "BACK";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnSend
			// 
			this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSend.BackColor = System.Drawing.Color.White;
			this.animPan.SetDecoration(this.btnSend, BunifuAnimatorNS.DecorationType.None);
			this.btnSend.Enabled = false;
			this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSend.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
			this.btnSend.Location = new System.Drawing.Point(432, 375);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(76, 70);
			this.btnSend.TabIndex = 4;
			this.btnSend.Text = "SEND";
			this.btnSend.UseVisualStyleBackColor = false;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// rtbMsg
			// 
			this.rtbMsg.AcceptsTab = true;
			this.rtbMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbMsg.AutoWordSelection = true;
			this.rtbMsg.BackColor = System.Drawing.Color.White;
			this.rtbMsg.BulletIndent = 3;
			this.animPan.SetDecoration(this.rtbMsg, BunifuAnimatorNS.DecorationType.None);
			this.rtbMsg.EnableAutoDragDrop = true;
			this.rtbMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbMsg.Location = new System.Drawing.Point(28, 375);
			this.rtbMsg.Name = "rtbMsg";
			this.rtbMsg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
			this.rtbMsg.Size = new System.Drawing.Size(403, 70);
			this.rtbMsg.TabIndex = 3;
			this.rtbMsg.Text = "";
			this.rtbMsg.TextChanged += new System.EventHandler(this.rtbMsg_TextChanged);
			// 
			// PanAllMsgs
			// 
			this.PanAllMsgs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PanAllMsgs.AutoScroll = true;
			this.animPan.SetDecoration(this.PanAllMsgs, BunifuAnimatorNS.DecorationType.None);
			this.PanAllMsgs.Location = new System.Drawing.Point(30, 3);
			this.PanAllMsgs.Name = "PanAllMsgs";
			this.PanAllMsgs.Size = new System.Drawing.Size(551, 366);
			this.PanAllMsgs.TabIndex = 2;
			// 
			// panMainSmall
			// 
			this.panMainSmall.Controls.Add(this.btnBot);
			this.panMainSmall.Controls.Add(this.btnTwitterLogin);
			this.panMainSmall.Controls.Add(this.myPreloader1);
			this.panMainSmall.Controls.Add(this.label4);
			this.panMainSmall.Controls.Add(this.ddlLocations);
			this.panMainSmall.Controls.Add(this.btnGetTweets);
			this.panMainSmall.Controls.Add(this.btnViewResults);
			this.panMainSmall.Controls.Add(this.txtSearchTwitter);
			this.animPan.SetDecoration(this.panMainSmall, BunifuAnimatorNS.DecorationType.None);
			this.panMainSmall.Location = new System.Drawing.Point(47, 46);
			this.panMainSmall.Name = "panMainSmall";
			this.panMainSmall.Size = new System.Drawing.Size(775, 429);
			this.panMainSmall.TabIndex = 12;
			// 
			// btnBot
			// 
			this.btnBot.ActiveBorderThickness = 1;
			this.btnBot.ActiveCornerRadius = 20;
			this.btnBot.ActiveFillColor = System.Drawing.Color.SeaGreen;
			this.btnBot.ActiveForecolor = System.Drawing.Color.White;
			this.btnBot.ActiveLineColor = System.Drawing.Color.SeaGreen;
			this.btnBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
			this.btnBot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBot.BackgroundImage")));
			this.btnBot.ButtonText = "Chat Bot";
			this.btnBot.Cursor = System.Windows.Forms.Cursors.Hand;
			this.animPan.SetDecoration(this.btnBot, BunifuAnimatorNS.DecorationType.None);
			this.btnBot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBot.ForeColor = System.Drawing.Color.SeaGreen;
			this.btnBot.IdleBorderThickness = 1;
			this.btnBot.IdleCornerRadius = 20;
			this.btnBot.IdleFillColor = System.Drawing.Color.White;
			this.btnBot.IdleForecolor = System.Drawing.Color.SeaGreen;
			this.btnBot.IdleLineColor = System.Drawing.Color.SeaGreen;
			this.btnBot.Location = new System.Drawing.Point(19, 286);
			this.btnBot.Margin = new System.Windows.Forms.Padding(5);
			this.btnBot.Name = "btnBot";
			this.btnBot.Size = new System.Drawing.Size(117, 82);
			this.btnBot.TabIndex = 11;
			this.btnBot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnBot.Click += new System.EventHandler(this.btnBot_Click);
			// 
			// btnTwitterLogin
			// 
			this.btnTwitterLogin.ActiveBorderThickness = 1;
			this.btnTwitterLogin.ActiveCornerRadius = 20;
			this.btnTwitterLogin.ActiveFillColor = System.Drawing.Color.SeaGreen;
			this.btnTwitterLogin.ActiveForecolor = System.Drawing.Color.White;
			this.btnTwitterLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
			this.btnTwitterLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
			this.btnTwitterLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTwitterLogin.BackgroundImage")));
			this.btnTwitterLogin.ButtonText = "Log In";
			this.btnTwitterLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.animPan.SetDecoration(this.btnTwitterLogin, BunifuAnimatorNS.DecorationType.None);
			this.btnTwitterLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTwitterLogin.ForeColor = System.Drawing.Color.SeaGreen;
			this.btnTwitterLogin.IdleBorderThickness = 1;
			this.btnTwitterLogin.IdleCornerRadius = 20;
			this.btnTwitterLogin.IdleFillColor = System.Drawing.Color.White;
			this.btnTwitterLogin.IdleForecolor = System.Drawing.Color.SeaGreen;
			this.btnTwitterLogin.IdleLineColor = System.Drawing.Color.SeaGreen;
			this.btnTwitterLogin.Location = new System.Drawing.Point(96, 78);
			this.btnTwitterLogin.Margin = new System.Windows.Forms.Padding(5);
			this.btnTwitterLogin.Name = "btnTwitterLogin";
			this.btnTwitterLogin.Size = new System.Drawing.Size(511, 41);
			this.btnTwitterLogin.TabIndex = 5;
			this.btnTwitterLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnTwitterLogin.Click += new System.EventHandler(this.btnTwitterLogin_Click);
			// 
			// ddlLocations
			// 
			this.ddlLocations.BackColor = System.Drawing.Color.Transparent;
			this.ddlLocations.BorderRadius = 3;
			this.animPan.SetDecoration(this.ddlLocations, BunifuAnimatorNS.DecorationType.None);
			this.ddlLocations.ForeColor = System.Drawing.Color.White;
			this.ddlLocations.Items = new string[] {
        "Lagos",
        "Abuja",
        "Awka"};
			this.ddlLocations.Location = new System.Drawing.Point(277, 269);
			this.ddlLocations.Name = "ddlLocations";
			this.ddlLocations.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.ddlLocations.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
			this.ddlLocations.selectedIndex = -1;
			this.ddlLocations.Size = new System.Drawing.Size(180, 29);
			this.ddlLocations.TabIndex = 9;
			// 
			// btnGetTweets
			// 
			this.btnGetTweets.ActiveBorderThickness = 1;
			this.btnGetTweets.ActiveCornerRadius = 20;
			this.btnGetTweets.ActiveFillColor = System.Drawing.Color.SeaGreen;
			this.btnGetTweets.ActiveForecolor = System.Drawing.Color.White;
			this.btnGetTweets.ActiveLineColor = System.Drawing.Color.SeaGreen;
			this.btnGetTweets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
			this.btnGetTweets.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetTweets.BackgroundImage")));
			this.btnGetTweets.ButtonText = "Get Tweets";
			this.btnGetTweets.Cursor = System.Windows.Forms.Cursors.Hand;
			this.animPan.SetDecoration(this.btnGetTweets, BunifuAnimatorNS.DecorationType.None);
			this.btnGetTweets.Enabled = false;
			this.btnGetTweets.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGetTweets.ForeColor = System.Drawing.Color.SeaGreen;
			this.btnGetTweets.IdleBorderThickness = 1;
			this.btnGetTweets.IdleCornerRadius = 20;
			this.btnGetTweets.IdleFillColor = System.Drawing.Color.White;
			this.btnGetTweets.IdleForecolor = System.Drawing.Color.SeaGreen;
			this.btnGetTweets.IdleLineColor = System.Drawing.Color.SeaGreen;
			this.btnGetTweets.Location = new System.Drawing.Point(157, 306);
			this.btnGetTweets.Margin = new System.Windows.Forms.Padding(5);
			this.btnGetTweets.Name = "btnGetTweets";
			this.btnGetTweets.Size = new System.Drawing.Size(437, 41);
			this.btnGetTweets.TabIndex = 4;
			this.btnGetTweets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnGetTweets.Click += new System.EventHandler(this.btnGetTweets_Click);
			// 
			// btnViewResults
			// 
			this.btnViewResults.ActiveBorderThickness = 1;
			this.btnViewResults.ActiveCornerRadius = 20;
			this.btnViewResults.ActiveFillColor = System.Drawing.Color.SeaGreen;
			this.btnViewResults.ActiveForecolor = System.Drawing.Color.White;
			this.btnViewResults.ActiveLineColor = System.Drawing.Color.SeaGreen;
			this.btnViewResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
			this.btnViewResults.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewResults.BackgroundImage")));
			this.btnViewResults.ButtonText = "View Results";
			this.btnViewResults.Cursor = System.Windows.Forms.Cursors.Hand;
			this.animPan.SetDecoration(this.btnViewResults, BunifuAnimatorNS.DecorationType.None);
			this.btnViewResults.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnViewResults.ForeColor = System.Drawing.Color.SeaGreen;
			this.btnViewResults.IdleBorderThickness = 1;
			this.btnViewResults.IdleCornerRadius = 20;
			this.btnViewResults.IdleFillColor = System.Drawing.Color.White;
			this.btnViewResults.IdleForecolor = System.Drawing.Color.SeaGreen;
			this.btnViewResults.IdleLineColor = System.Drawing.Color.SeaGreen;
			this.btnViewResults.Location = new System.Drawing.Point(636, 286);
			this.btnViewResults.Margin = new System.Windows.Forms.Padding(5);
			this.btnViewResults.Name = "btnViewResults";
			this.btnViewResults.Size = new System.Drawing.Size(117, 82);
			this.btnViewResults.TabIndex = 7;
			this.btnViewResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnViewResults.Click += new System.EventHandler(this.btnViewResults_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblCloseReport);
			this.panel2.Controls.Add(this.sentimentReports1);
			this.panel2.Controls.Add(this.pictureBox2);
			this.animPan.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
			this.panel2.Location = new System.Drawing.Point(0, 55);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(850, 480);
			this.panel2.TabIndex = 4;
			this.panel2.Visible = false;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Red;
			this.animPan.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
			this.pictureBox2.Image = global::SentimentAnalysis.Properties.Resources.close;
			this.pictureBox2.Location = new System.Drawing.Point(816, 1);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(33, 30);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// lblCloseReport
			// 
			this.lblCloseReport.BackColor = System.Drawing.Color.Red;
			this.animPan.SetDecoration(this.lblCloseReport, BunifuAnimatorNS.DecorationType.None);
			this.lblCloseReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCloseReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblCloseReport.Location = new System.Drawing.Point(828, 4);
			this.lblCloseReport.Name = "lblCloseReport";
			this.lblCloseReport.Size = new System.Drawing.Size(20, 20);
			this.lblCloseReport.TabIndex = 3;
			this.lblCloseReport.Text = "X";
			this.lblCloseReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblCloseReport.Click += new System.EventHandler(this.lblCloseReport_Click);
			// 
			// sentimentReports1
			// 
			this.animPan.SetDecoration(this.sentimentReports1, BunifuAnimatorNS.DecorationType.None);
			this.sentimentReports1.jsontweets = null;
			this.sentimentReports1.Location = new System.Drawing.Point(0, 0);
			this.sentimentReports1.Name = "sentimentReports1";
			this.sentimentReports1.Size = new System.Drawing.Size(850, 480);
			this.sentimentReports1.TabIndex = 2;
			this.sentimentReports1.Load += new System.EventHandler(this.sentimentReports1_Load);
			// 
			// myPreloader1
			// 
			this.myPreloader1.BackColor = System.Drawing.Color.Transparent;
			this.animPan.SetDecoration(this.myPreloader1, BunifuAnimatorNS.DecorationType.None);
			this.myPreloader1.Location = new System.Drawing.Point(288, 157);
			this.myPreloader1.Name = "myPreloader1";
			this.myPreloader1.Size = new System.Drawing.Size(159, 151);
			this.myPreloader1.TabIndex = 10;
			this.myPreloader1.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
			this.ClientSize = new System.Drawing.Size(871, 561);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panMain);
			this.Controls.Add(this.panel1);
			this.animPan.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panMain.ResumeLayout(false);
			this.panBotChat.ResumeLayout(false);
			this.panMainSmall.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private BunifuAnimatorNS.BunifuTransition animPan;
		private System.Windows.Forms.Label label4;
		private Bunifu.Framework.UI.BunifuThinButton2 btnGetTweets;
		private System.Windows.Forms.Panel panMain;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchTwitter;
		private Bunifu.Framework.UI.BunifuThinButton2 btnViewResults;
		private Bunifu.Framework.UI.BunifuThinButton2 btnTwitterLogin;
		private Bunifu.Framework.UI.BunifuDropdown ddlLocations;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private UserControls.SentimentReports sentimentReports1;
		private UserControls.MyPreloader myPreloader1;
		private Bunifu.Framework.UI.BunifuThinButton2 btnBot;
		private System.Windows.Forms.Panel panBotChat;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.RichTextBox rtbMsg;
		private System.Windows.Forms.Panel PanAllMsgs;
		private System.Windows.Forms.Panel panMainSmall;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label lblCloseReport;
		//     private ExtendedPanel extendedPanel1;
	}
}

