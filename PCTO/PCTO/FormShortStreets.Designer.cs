
namespace PCTO
{
    partial class FormShortStreets
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
            this.shortestStreetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riderSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riderSpaceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortestStreetToolStripMenuItem,
            this.riderSpaceToolStripMenuItem,
            this.riderSpaceToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1058, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shortestStreetToolStripMenuItem
            // 
            this.shortestStreetToolStripMenuItem.Name = "shortestStreetToolStripMenuItem";
            this.shortestStreetToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.shortestStreetToolStripMenuItem.Text = "Home";
            // 
            // riderSpaceToolStripMenuItem
            // 
            this.riderSpaceToolStripMenuItem.Name = "riderSpaceToolStripMenuItem";
            this.riderSpaceToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.riderSpaceToolStripMenuItem.Text = "Shortest street";
            // 
            // riderSpaceToolStripMenuItem1
            // 
            this.riderSpaceToolStripMenuItem1.Name = "riderSpaceToolStripMenuItem1";
            this.riderSpaceToolStripMenuItem1.Size = new System.Drawing.Size(100, 24);
            this.riderSpaceToolStripMenuItem1.Text = "Rider space";
            this.riderSpaceToolStripMenuItem1.Click += new System.EventHandler(this.riderSpaceToolStripMenuItem1_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Location = new System.Drawing.Point(12, 31);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1030, 554);
            this.pnlHome.TabIndex = 1;
            // 
            // FormShortStreets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 597);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1076, 644);
            this.Name = "FormShortStreets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Short Streets";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shortestStreetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riderSpaceToolStripMenuItem;
        public System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.ToolStripMenuItem riderSpaceToolStripMenuItem1;
    }
}