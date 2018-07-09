namespace SentimentAnalysis.UserControls
{
	partial class MyPreloader
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPreloader));
			this.circle = new Bunifu.Framework.UI.BunifuCircleProgressbar();
			this.timCircle = new System.Windows.Forms.Timer(this.components);
			this.timColor = new System.Windows.Forms.Timer(this.components);
			this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
			this.SuspendLayout();
			// 
			// circle
			// 
			this.circle.animated = true;
			this.circle.animationIterval = 2;
			this.circle.animationSpeed = 1;
			this.circle.BackColor = System.Drawing.Color.Transparent;
			this.circle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle.BackgroundImage")));
			this.circle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
			this.circle.ForeColor = System.Drawing.Color.SeaGreen;
			this.circle.LabelVisible = false;
			this.circle.LineProgressThickness = 8;
			this.circle.LineThickness = 5;
			this.circle.Location = new System.Drawing.Point(0, 0);
			this.circle.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.circle.MaxValue = 100;
			this.circle.Name = "circle";
			this.circle.ProgressBackColor = System.Drawing.Color.Transparent;
			this.circle.ProgressColor = System.Drawing.Color.SeaGreen;
			this.circle.Size = new System.Drawing.Size(240, 240);
			this.circle.TabIndex = 0;
			this.circle.Value = 30;
			// 
			// timCircle
			// 
			this.timCircle.Enabled = true;
			this.timCircle.Interval = 10;
			this.timCircle.Tick += new System.EventHandler(this.timCircle_Tick);
			// 
			// timColor
			// 
			this.timColor.Interval = 10;
			this.timColor.Tick += new System.EventHandler(this.timColor_Tick);
			// 
			// bunifuColorTransition1
			// 
			this.bunifuColorTransition1.Color1 = System.Drawing.Color.White;
			this.bunifuColorTransition1.Color2 = System.Drawing.Color.White;
			this.bunifuColorTransition1.ProgessValue = 0;
			// 
			// MyPreloader
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.circle);
			this.Name = "MyPreloader";
			this.Size = new System.Drawing.Size(240, 240);
			this.Load += new System.EventHandler(this.MyPreloader_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuCircleProgressbar circle;
		private System.Windows.Forms.Timer timCircle;
		private System.Windows.Forms.Timer timColor;
		private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
	}
}
