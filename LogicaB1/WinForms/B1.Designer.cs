namespace WinForms
{
    partial class B1
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            cotiToolStripMenuItem = new ToolStripMenuItem();
            sTToolStripMenuItem = new ToolStripMenuItem();
            lMToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, cotiToolStripMenuItem, sTToolStripMenuItem, lMToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(290, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(42, 20);
            toolStripMenuItem1.Text = "Stok";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // cotiToolStripMenuItem
            // 
            cotiToolStripMenuItem.Name = "cotiToolStripMenuItem";
            cotiToolStripMenuItem.Size = new Size(41, 20);
            cotiToolStripMenuItem.Text = "Coti";
            cotiToolStripMenuItem.Click += cotiToolStripMenuItem_Click;
            // 
            // sTToolStripMenuItem
            // 
            sTToolStripMenuItem.Name = "sTToolStripMenuItem";
            sTToolStripMenuItem.Size = new Size(31, 20);
            sTToolStripMenuItem.Text = "ST";
            sTToolStripMenuItem.Click += sTToolStripMenuItem_Click;
            // 
            // lMToolStripMenuItem
            // 
            lMToolStripMenuItem.Name = "lMToolStripMenuItem";
            lMToolStripMenuItem.Size = new Size(36, 20);
            lMToolStripMenuItem.Text = "LM";
            lMToolStripMenuItem.Click += lMToolStripMenuItem_Click;
            // 
            // B1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 29);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "B1";
            Text = "B1";
            FormClosing += B1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem cotiToolStripMenuItem;
        private ToolStripMenuItem sTToolStripMenuItem;
        private ToolStripMenuItem lMToolStripMenuItem;
    }
}