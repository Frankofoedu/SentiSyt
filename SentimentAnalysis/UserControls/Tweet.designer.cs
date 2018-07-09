namespace SentimentAnalysis.UserControls
{
	partial class Tweet
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTweet = new System.Windows.Forms.Label();
            this.lblHandle = new System.Windows.Forms.Label();
            this.picPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(330, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nigeria";
            // 
            // lblTweet
            // 
            this.lblTweet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTweet.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTweet.Location = new System.Drawing.Point(61, 23);
            this.lblTweet.Name = "lblTweet";
            this.lblTweet.Size = new System.Drawing.Size(333, 49);
            this.lblTweet.TabIndex = 2;
            this.lblTweet.Text = "Glo, you are very mad, and your network in my area is useless as the ueue in queu" +
    "e.";
            // 
            // lblHandle
            // 
            this.lblHandle.AutoSize = true;
            this.lblHandle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(232)))));
            this.lblHandle.Location = new System.Drawing.Point(68, 3);
            this.lblHandle.Name = "lblHandle";
            this.lblHandle.Size = new System.Drawing.Size(72, 16);
            this.lblHandle.TabIndex = 3;
            this.lblHandle.Text = "@Obaino";
            // 
            // picPic
            // 
            this.picPic.Location = new System.Drawing.Point(5, 11);
            this.picPic.Name = "picPic";
            this.picPic.Size = new System.Drawing.Size(50, 50);
            this.picPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPic.TabIndex = 0;
            this.picPic.TabStop = false;
            // 
            // Tweet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblHandle);
            this.Controls.Add(this.lblTweet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPic);
            this.Name = "Tweet";
            this.Size = new System.Drawing.Size(400, 72);
            this.Load += new System.EventHandler(this.Tweet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picPic;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblTweet;
		private System.Windows.Forms.Label lblHandle;
	}
}
