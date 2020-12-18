namespace Hotelli_Sivu
{
    partial class Paasivu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hallitseAsiakaitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallitseHuoneitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallitseVarauksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hallitseAsiakaitaToolStripMenuItem,
            this.hallitseHuoneitaToolStripMenuItem,
            this.hallitseVarauksetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hallitseAsiakaitaToolStripMenuItem
            // 
            this.hallitseAsiakaitaToolStripMenuItem.Name = "hallitseAsiakaitaToolStripMenuItem";
            this.hallitseAsiakaitaToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.hallitseAsiakaitaToolStripMenuItem.Text = "Hallitse Asiakaita";
            this.hallitseAsiakaitaToolStripMenuItem.Click += new System.EventHandler(this.hallitseAsiakaitaToolStripMenuItem_Click);
            // 
            // hallitseHuoneitaToolStripMenuItem
            // 
            this.hallitseHuoneitaToolStripMenuItem.Name = "hallitseHuoneitaToolStripMenuItem";
            this.hallitseHuoneitaToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.hallitseHuoneitaToolStripMenuItem.Text = "Hallitse Huoneita";
            this.hallitseHuoneitaToolStripMenuItem.Click += new System.EventHandler(this.hallitseHuoneitaToolStripMenuItem_Click);
            // 
            // hallitseVarauksetToolStripMenuItem
            // 
            this.hallitseVarauksetToolStripMenuItem.Name = "hallitseVarauksetToolStripMenuItem";
            this.hallitseVarauksetToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.hallitseVarauksetToolStripMenuItem.Text = "Hallitse Varaukset";
            this.hallitseVarauksetToolStripMenuItem.Click += new System.EventHandler(this.hallitseToolStripMenuItem_Click);
            // 
            // Paasivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 501);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paasivu";
            this.Text = "Paasivu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Paasivu_FormClosing);
            this.Load += new System.EventHandler(this.Paasivu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hallitseAsiakaitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallitseVarauksetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallitseHuoneitaToolStripMenuItem;
    }
}