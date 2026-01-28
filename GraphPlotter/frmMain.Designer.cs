namespace GraphPlotter
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            renderingToolStripMenuItem = new ToolStripMenuItem();
            rerenderToolStripMenuItem = new ToolStripMenuItem();
            insertToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Silver;
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.ImageScalingSize = new Size(18, 18);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, renderingToolStripMenuItem, insertToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(778, 27);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(43, 23);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(107, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // renderingToolStripMenuItem
            // 
            renderingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rerenderToolStripMenuItem, clearToolStripMenuItem });
            renderingToolStripMenuItem.Name = "renderingToolStripMenuItem";
            renderingToolStripMenuItem.Size = new Size(85, 23);
            renderingToolStripMenuItem.Text = "Rendering";
            // 
            // rerenderToolStripMenuItem
            // 
            rerenderToolStripMenuItem.Name = "rerenderToolStripMenuItem";
            rerenderToolStripMenuItem.Size = new Size(206, 24);
            rerenderToolStripMenuItem.Text = "Re-Render";
            rerenderToolStripMenuItem.Click += rerenderToolStripMenuItem_Click;
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(88, 23);
            insertToolStripMenuItem.Text = "NewVertex";
            insertToolStripMenuItem.Click += insertToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(206, 24);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 652);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GraphPlotter";
            Shown += frmMain_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem renderingToolStripMenuItem;
        private ToolStripMenuItem rerenderToolStripMenuItem;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
    }
}
