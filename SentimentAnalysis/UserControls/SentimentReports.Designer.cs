namespace SentimentAnalysis.UserControls
{
    partial class SentimentReports
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
            this.sentinentReport1 = new SentimentAnalysis.UserControls.SentinentReport();
            this.panPos = new System.Windows.Forms.Panel();
            this.panNeg = new System.Windows.Forms.Panel();
            this.lblPos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sentinentReport1
            // 
            this.sentinentReport1.Analysed = 0;
            this.sentinentReport1.BackColor = System.Drawing.Color.Transparent;
            this.sentinentReport1.Location = new System.Drawing.Point(1, 1);
            this.sentinentReport1.Name = "sentinentReport1";
            this.sentinentReport1.Negative = 0;
            this.sentinentReport1.Positive = 0;
            this.sentinentReport1.Size = new System.Drawing.Size(850, 139);
            this.sentinentReport1.TabIndex = 0;
            this.sentinentReport1.TweetCount = 0;
            // 
            // panPos
            // 
            this.panPos.AutoScroll = true;
            this.panPos.Location = new System.Drawing.Point(4, 178);
            this.panPos.Name = "panPos";
            this.panPos.Size = new System.Drawing.Size(421, 302);
            this.panPos.TabIndex = 1;
            // 
            // panNeg
            // 
            this.panNeg.AutoScroll = true;
            this.panNeg.Location = new System.Drawing.Point(428, 178);
            this.panNeg.Name = "panNeg";
            this.panNeg.Size = new System.Drawing.Size(421, 302);
            this.panNeg.TabIndex = 2;
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(81)))));
            this.lblPos.Location = new System.Drawing.Point(13, 149);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(212, 26);
            this.lblPos.TabIndex = 3;
            this.lblPos.Text = "Top Positive Tweets";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(99)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(436, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Top Negative Tweets";
            // 
            // SentimentReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.panNeg);
            this.Controls.Add(this.panPos);
            this.Controls.Add(this.sentinentReport1);
            this.Name = "SentimentReports";
            this.Size = new System.Drawing.Size(850, 480);
            this.Load += new System.EventHandler(this.SentimentReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SentinentReport sentinentReport1;
        private System.Windows.Forms.Panel panPos;
        private System.Windows.Forms.Panel panNeg;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Label label1;
    }
}
