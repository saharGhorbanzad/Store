namespace SaneiStore
{
    partial class frmMain
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
            this.منویاصلیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتمشتریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستمشتریهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انبارToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.منویاصلیToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // منویاصلیToolStripMenuItem
            // 
            this.منویاصلیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتمشتریToolStripMenuItem,
            this.لیستمشتریهاToolStripMenuItem,
            this.انبارToolStripMenuItem1});
            this.منویاصلیToolStripMenuItem.Name = "منویاصلیToolStripMenuItem";
            this.منویاصلیToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.منویاصلیToolStripMenuItem.Text = "منوی اصلی";
            // 
            // ثبتمشتریToolStripMenuItem
            // 
            this.ثبتمشتریToolStripMenuItem.Name = "ثبتمشتریToolStripMenuItem";
            this.ثبتمشتریToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ثبتمشتریToolStripMenuItem.Text = "ثبت مشتری";
            this.ثبتمشتریToolStripMenuItem.Click += new System.EventHandler(this.ثبتمشتریToolStripMenuItem_Click);
            // 
            // لیستمشتریهاToolStripMenuItem
            // 
            this.لیستمشتریهاToolStripMenuItem.Name = "لیستمشتریهاToolStripMenuItem";
            this.لیستمشتریهاToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.لیستمشتریهاToolStripMenuItem.Text = "لیست مشتری ها";
            this.لیستمشتریهاToolStripMenuItem.Click += new System.EventHandler(this.لیستمشتریهاToolStripMenuItem_Click);
            // 
            // انبارToolStripMenuItem1
            // 
            this.انبارToolStripMenuItem1.Name = "انبارToolStripMenuItem1";
            this.انبارToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.انبارToolStripMenuItem1.Text = "انبار";
            this.انبارToolStripMenuItem1.Click += new System.EventHandler(this.انبارToolStripMenuItem1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem منویاصلیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتمشتریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستمشتریهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انبارToolStripMenuItem1;
    }
}