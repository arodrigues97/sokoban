using Sokoban_Assignment.src.sokoban.forms;

namespace Sokoban_Assignment
{
    partial class DesignForm
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
            this.ColumnCountButton = new System.Windows.Forms.NumericUpDown();
            this.RowCountButton = new System.Windows.Forms.NumericUpDown();
            this.columnLabel = new System.Windows.Forms.Label();
            this.rowLabel = new System.Windows.Forms.Label();
            this.GridGenerationPanel = new System.Windows.Forms.Panel();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.ToolBoxPanel = new System.Windows.Forms.Panel();
            this.toolBoxLabel = new System.Windows.Forms.Label();
            this.destinationButton = new System.Windows.Forms.RadioButton();
            this.boxButton = new System.Windows.Forms.RadioButton();
            this.wallButton = new System.Windows.Forms.RadioButton();
            this.heroButton = new System.Windows.Forms.RadioButton();
            this.noneRadioButton = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.DesignFileMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridPanel = new Sokoban_Assignment.src.sokoban.forms.BufferedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnCountButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowCountButton)).BeginInit();
            this.GridGenerationPanel.SuspendLayout();
            this.ToolBoxPanel.SuspendLayout();
            this.DesignFileMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColumnCountButton
            // 
            this.ColumnCountButton.Location = new System.Drawing.Point(244, 14);
            this.ColumnCountButton.Name = "ColumnCountButton";
            this.ColumnCountButton.Size = new System.Drawing.Size(120, 20);
            this.ColumnCountButton.TabIndex = 0;
            this.ColumnCountButton.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // RowCountButton
            // 
            this.RowCountButton.Location = new System.Drawing.Point(53, 14);
            this.RowCountButton.Name = "RowCountButton";
            this.RowCountButton.Size = new System.Drawing.Size(120, 20);
            this.RowCountButton.TabIndex = 1;
            this.RowCountButton.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // columnLabel
            // 
            this.columnLabel.AutoSize = true;
            this.columnLabel.Location = new System.Drawing.Point(188, 16);
            this.columnLabel.Name = "columnLabel";
            this.columnLabel.Size = new System.Drawing.Size(50, 13);
            this.columnLabel.TabIndex = 2;
            this.columnLabel.Text = "Columns:";
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Location = new System.Drawing.Point(8, 16);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(37, 13);
            this.rowLabel.TabIndex = 3;
            this.rowLabel.Text = "Rows:";
            // 
            // GridGenerationPanel
            // 
            this.GridGenerationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GridGenerationPanel.Controls.Add(this.GenerateButton);
            this.GridGenerationPanel.Controls.Add(this.RowCountButton);
            this.GridGenerationPanel.Controls.Add(this.rowLabel);
            this.GridGenerationPanel.Controls.Add(this.ColumnCountButton);
            this.GridGenerationPanel.Controls.Add(this.columnLabel);
            this.GridGenerationPanel.Location = new System.Drawing.Point(12, 34);
            this.GridGenerationPanel.Name = "GridGenerationPanel";
            this.GridGenerationPanel.Size = new System.Drawing.Size(373, 100);
            this.GridGenerationPanel.TabIndex = 4;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(51, 51);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(313, 23);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // ToolBoxPanel
            // 
            this.ToolBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolBoxPanel.Controls.Add(this.toolBoxLabel);
            this.ToolBoxPanel.Controls.Add(this.destinationButton);
            this.ToolBoxPanel.Controls.Add(this.boxButton);
            this.ToolBoxPanel.Controls.Add(this.wallButton);
            this.ToolBoxPanel.Controls.Add(this.heroButton);
            this.ToolBoxPanel.Controls.Add(this.noneRadioButton);
            this.ToolBoxPanel.Location = new System.Drawing.Point(12, 150);
            this.ToolBoxPanel.Name = "ToolBoxPanel";
            this.ToolBoxPanel.Size = new System.Drawing.Size(148, 486);
            this.ToolBoxPanel.TabIndex = 5;
            // 
            // toolBoxLabel
            // 
            this.toolBoxLabel.AutoSize = true;
            this.toolBoxLabel.Location = new System.Drawing.Point(30, 9);
            this.toolBoxLabel.Name = "toolBoxLabel";
            this.toolBoxLabel.Size = new System.Drawing.Size(49, 13);
            this.toolBoxLabel.TabIndex = 5;
            this.toolBoxLabel.Text = "Tool Box";
            // 
            // destinationButton
            // 
            this.destinationButton.AutoSize = true;
            this.destinationButton.Location = new System.Drawing.Point(11, 123);
            this.destinationButton.Name = "destinationButton";
            this.destinationButton.Size = new System.Drawing.Size(78, 17);
            this.destinationButton.TabIndex = 4;
            this.destinationButton.Text = "Destination";
            this.destinationButton.UseVisualStyleBackColor = true;
            this.destinationButton.CheckedChanged += new System.EventHandler(this.DestinationButton_CheckedChanged);
            // 
            // boxButton
            // 
            this.boxButton.AutoSize = true;
            this.boxButton.Location = new System.Drawing.Point(11, 100);
            this.boxButton.Name = "boxButton";
            this.boxButton.Size = new System.Drawing.Size(43, 17);
            this.boxButton.TabIndex = 3;
            this.boxButton.Text = "Box";
            this.boxButton.UseVisualStyleBackColor = true;
            this.boxButton.CheckedChanged += new System.EventHandler(this.BoxButton_CheckedChanged);
            // 
            // wallButton
            // 
            this.wallButton.AutoSize = true;
            this.wallButton.Location = new System.Drawing.Point(11, 77);
            this.wallButton.Name = "wallButton";
            this.wallButton.Size = new System.Drawing.Size(46, 17);
            this.wallButton.TabIndex = 2;
            this.wallButton.Text = "Wall";
            this.wallButton.UseVisualStyleBackColor = true;
            this.wallButton.CheckedChanged += new System.EventHandler(this.WallButton_CheckedChanged);
            // 
            // heroButton
            // 
            this.heroButton.AutoSize = true;
            this.heroButton.Location = new System.Drawing.Point(11, 54);
            this.heroButton.Name = "heroButton";
            this.heroButton.Size = new System.Drawing.Size(48, 17);
            this.heroButton.TabIndex = 1;
            this.heroButton.Text = "Hero";
            this.heroButton.UseVisualStyleBackColor = true;
            this.heroButton.CheckedChanged += new System.EventHandler(this.HeroButton_CheckedChanged);
            // 
            // noneRadioButton
            // 
            this.noneRadioButton.AutoSize = true;
            this.noneRadioButton.Checked = true;
            this.noneRadioButton.Location = new System.Drawing.Point(11, 31);
            this.noneRadioButton.Name = "noneRadioButton";
            this.noneRadioButton.Size = new System.Drawing.Size(51, 17);
            this.noneRadioButton.TabIndex = 0;
            this.noneRadioButton.TabStop = true;
            this.noneRadioButton.Text = "None";
            this.noneRadioButton.UseVisualStyleBackColor = true;
            this.noneRadioButton.CheckedChanged += new System.EventHandler(this.NoneRadioButton_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(990, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // DesignFileMenuStrip
            // 
            this.DesignFileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuStrip});
            this.DesignFileMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.DesignFileMenuStrip.Name = "DesignFileMenuStrip";
            this.DesignFileMenuStrip.Size = new System.Drawing.Size(990, 24);
            this.DesignFileMenuStrip.TabIndex = 8;
            this.DesignFileMenuStrip.Text = "File Menu";
            // 
            // FileMenuStrip
            // 
            this.FileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.Size = new System.Drawing.Size(37, 20);
            this.FileMenuStrip.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click_1);
            // 
            // GridPanel
            // 
            this.GridPanel.Location = new System.Drawing.Point(166, 150);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(824, 495);
            this.GridPanel.TabIndex = 6;
            this.GridPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.designPanelPaint);
            this.GridPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridMouseClick);
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 648);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.ToolBoxPanel);
            this.Controls.Add(this.GridGenerationPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.DesignFileMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DesignForm";
            this.Text = "Sokoban - Design";
            this.Load += new System.EventHandler(this.DesignForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ColumnCountButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowCountButton)).EndInit();
            this.GridGenerationPanel.ResumeLayout(false);
            this.GridGenerationPanel.PerformLayout();
            this.ToolBoxPanel.ResumeLayout(false);
            this.ToolBoxPanel.PerformLayout();
            this.DesignFileMenuStrip.ResumeLayout(false);
            this.DesignFileMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ColumnCountButton;
        private System.Windows.Forms.NumericUpDown RowCountButton;
        private System.Windows.Forms.Label columnLabel;
        private System.Windows.Forms.Label rowLabel;
        private System.Windows.Forms.Panel GridGenerationPanel;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Panel ToolBoxPanel;
        private System.Windows.Forms.Label toolBoxLabel;
        private System.Windows.Forms.RadioButton destinationButton;
        private System.Windows.Forms.RadioButton boxButton;
        private System.Windows.Forms.RadioButton wallButton;
        private System.Windows.Forms.RadioButton heroButton;
        private System.Windows.Forms.RadioButton noneRadioButton;
        private BufferedPanel GridPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip DesignFileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}