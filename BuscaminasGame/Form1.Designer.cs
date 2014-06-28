namespace BuscaminasGame
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardcoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveQuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFlags = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(48, 33);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(0, 13);
            this.labelTimer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Score";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(136, 33);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(25, 13);
            this.labelScore.TabIndex = 5;
            this.labelScore.Text = "200";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.scoreScreenToolStripMenuItem,
            this.saveQuitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.hardcoreToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.easyToolStripMenuItem.Text = "Casual";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // hardcoreToolStripMenuItem
            // 
            this.hardcoreToolStripMenuItem.Name = "hardcoreToolStripMenuItem";
            this.hardcoreToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.hardcoreToolStripMenuItem.Text = "Hardcore";
            this.hardcoreToolStripMenuItem.Click += new System.EventHandler(this.hardcoreToolStripMenuItem_Click);
            // 
            // scoreScreenToolStripMenuItem
            // 
            this.scoreScreenToolStripMenuItem.Name = "scoreScreenToolStripMenuItem";
            this.scoreScreenToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.scoreScreenToolStripMenuItem.Text = "Score Screen";
            this.scoreScreenToolStripMenuItem.Click += new System.EventHandler(this.scoreScreenToolStripMenuItem_Click);
            // 
            // saveQuitToolStripMenuItem
            // 
            this.saveQuitToolStripMenuItem.Name = "saveQuitToolStripMenuItem";
            this.saveQuitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.saveQuitToolStripMenuItem.Text = "Save And Quit";
            this.saveQuitToolStripMenuItem.Click += new System.EventHandler(this.saveQuitToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Flags";
            // 
            // labelFlags
            // 
            this.labelFlags.AutoSize = true;
            this.labelFlags.Location = new System.Drawing.Point(237, 33);
            this.labelFlags.Name = "labelFlags";
            this.labelFlags.Size = new System.Drawing.Size(13, 13);
            this.labelFlags.TabIndex = 8;
            this.labelFlags.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 402);
            this.Controls.Add(this.labelFlags);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);            
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardcoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveQuitToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFlags;
    }
}

