namespace SentimentAnalysis
{
	partial class frmChat
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
			this.btnSend = new System.Windows.Forms.Button();
			this.txtMsg = new System.Windows.Forms.TextBox();
			this.listMessages = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(365, 353);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 0;
			this.btnSend.Text = "SEND";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtMsg
			// 
			this.txtMsg.Location = new System.Drawing.Point(75, 353);
			this.txtMsg.Name = "txtMsg";
			this.txtMsg.Size = new System.Drawing.Size(247, 20);
			this.txtMsg.TabIndex = 1;
			// 
			// listMessages
			// 
			this.listMessages.FormattingEnabled = true;
			this.listMessages.Location = new System.Drawing.Point(46, 64);
			this.listMessages.Name = "listMessages";
			this.listMessages.Size = new System.Drawing.Size(358, 238);
			this.listMessages.TabIndex = 2;
			// 
			// frmChat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 407);
			this.Controls.Add(this.listMessages);
			this.Controls.Add(this.txtMsg);
			this.Controls.Add(this.btnSend);
			this.Name = "frmChat";
			this.Text = "frmChat";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtMsg;
		private System.Windows.Forms.ListBox listMessages;
	}
}