namespace BuscaminasGame
{
    partial class SaveScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.TextBox();
            this.buttonSaveScore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save Score";
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(16, 70);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(100, 20);
            this.playerName.TabIndex = 1;
            // 
            // buttonSaveScore
            // 
            this.buttonSaveScore.Location = new System.Drawing.Point(16, 96);
            this.buttonSaveScore.Name = "buttonSaveScore";
            this.buttonSaveScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSaveScore.Size = new System.Drawing.Size(100, 23);
            this.buttonSaveScore.TabIndex = 2;
            this.buttonSaveScore.Text = "Save";
            this.buttonSaveScore.UseVisualStyleBackColor = true;
            this.buttonSaveScore.Click += new System.EventHandler(this.buttonSaveScore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Write Your Initials";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SaveScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(135, 131);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSaveScore);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.label1);
            this.Name = "SaveScore";
            this.Text = "SaveScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Button buttonSaveScore;
        private System.Windows.Forms.Label label2;
    }
}