namespace Sokoban_Assignment
{
    partial class PlayForm
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
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.upButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.numberOfMovesLabel = new System.Windows.Forms.Label();
            this.numberOfPushesLabel = new System.Windows.Forms.Label();
            this.gamePanel = new Sokoban_Assignment.src.sokoban.forms.BufferedPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1121, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadStripMenuItem,
            this.exitToolStripMenuItem1});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.loadToolStripMenuItem.Text = "File";
            // 
            // loadStripMenuItem
            // 
            this.loadStripMenuItem.Name = "loadStripMenuItem";
            this.loadStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadStripMenuItem.Text = "Load";
            this.loadStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(1013, 71);
            this.upButton.Margin = new System.Windows.Forms.Padding(2);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(48, 50);
            this.upButton.TabIndex = 2;
            this.upButton.Text = "Up";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(968, 119);
            this.leftButton.Margin = new System.Windows.Forms.Padding(2);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(48, 50);
            this.leftButton.TabIndex = 3;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(1013, 119);
            this.downButton.Margin = new System.Windows.Forms.Padding(2);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(48, 50);
            this.downButton.TabIndex = 4;
            this.downButton.Text = "Down";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(1059, 119);
            this.rightButton.Margin = new System.Windows.Forms.Padding(2);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(48, 50);
            this.rightButton.TabIndex = 5;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // numberOfMovesLabel
            // 
            this.numberOfMovesLabel.AutoSize = true;
            this.numberOfMovesLabel.Location = new System.Drawing.Point(881, 180);
            this.numberOfMovesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfMovesLabel.Name = "numberOfMovesLabel";
            this.numberOfMovesLabel.Size = new System.Drawing.Size(105, 13);
            this.numberOfMovesLabel.TabIndex = 6;
            this.numberOfMovesLabel.Text = "Number Of Moves: 0";
            // 
            // numberOfPushesLabel
            // 
            this.numberOfPushesLabel.AutoSize = true;
            this.numberOfPushesLabel.Location = new System.Drawing.Point(877, 205);
            this.numberOfPushesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfPushesLabel.Name = "numberOfPushesLabel";
            this.numberOfPushesLabel.Size = new System.Drawing.Size(108, 13);
            this.numberOfPushesLabel.TabIndex = 7;
            this.numberOfPushesLabel.Text = "Number Of Pushes: 0";
            // 
            // gamePanel
            // 
            this.gamePanel.Location = new System.Drawing.Point(0, 32);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(2);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(858, 536);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.playPanelPaint);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 573);
            this.Controls.Add(this.numberOfPushesLabel);
            this.Controls.Add(this.numberOfMovesLabel);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlayForm";
            this.Text = "Sokoban - Play";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private src.sokoban.forms.BufferedPanel gamePanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button rightButton;
        public System.Windows.Forms.Label numberOfMovesLabel;
        public  System.Windows.Forms.Label numberOfPushesLabel;
    }
}