namespace Click_Trainning
{
    partial class GamingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamingForm));
            this.RedPoint = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.clickScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RemainingTimeLabel = new System.Windows.Forms.Label();
            this.RemainingTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RedPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // RedPoint
            // 
            this.RedPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RedPoint.Image = ((System.Drawing.Image)(resources.GetObject("RedPoint.Image")));
            this.RedPoint.Location = new System.Drawing.Point(466, 298);
            this.RedPoint.Name = "RedPoint";
            this.RedPoint.Size = new System.Drawing.Size(25, 25);
            this.RedPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedPoint.TabIndex = 0;
            this.RedPoint.TabStop = false;
            this.RedPoint.Click += new System.EventHandler(this.RedPoint_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(837, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(47, 12);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Score：";
            // 
            // clickScore
            // 
            this.clickScore.AutoSize = true;
            this.clickScore.Location = new System.Drawing.Point(891, 9);
            this.clickScore.Name = "clickScore";
            this.clickScore.Size = new System.Drawing.Size(11, 12);
            this.clickScore.TabIndex = 2;
            this.clickScore.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // RemainingTimeLabel
            // 
            this.RemainingTimeLabel.AutoSize = true;
            this.RemainingTimeLabel.Location = new System.Drawing.Point(538, 8);
            this.RemainingTimeLabel.Name = "RemainingTimeLabel";
            this.RemainingTimeLabel.Size = new System.Drawing.Size(95, 12);
            this.RemainingTimeLabel.TabIndex = 3;
            this.RemainingTimeLabel.Text = "Remaining Time:";
            // 
            // RemainingTime
            // 
            this.RemainingTime.AutoSize = true;
            this.RemainingTime.Location = new System.Drawing.Point(639, 8);
            this.RemainingTime.Name = "RemainingTime";
            this.RemainingTime.Size = new System.Drawing.Size(17, 12);
            this.RemainingTime.TabIndex = 4;
            this.RemainingTime.Text = "30";
            // 
            // GamingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.RemainingTime);
            this.Controls.Add(this.RemainingTimeLabel);
            this.Controls.Add(this.clickScore);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.RedPoint);
            this.Name = "GamingForm";
            this.Text = "GamingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GamingForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.RedPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RedPoint;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label clickScore;
        private System.Windows.Forms.Label RemainingTimeLabel;
        private System.Windows.Forms.Label RemainingTime;
        private System.Windows.Forms.Timer timer1;
    }
}