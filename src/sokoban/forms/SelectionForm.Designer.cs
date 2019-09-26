namespace Sokoban_Assignment
{
    partial class SelectionForm
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
            this.DesignButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.madeByLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DesignButton
            // 
            this.DesignButton.Location = new System.Drawing.Point(55, 37);
            this.DesignButton.Name = "DesignButton";
            this.DesignButton.Size = new System.Drawing.Size(131, 48);
            this.DesignButton.TabIndex = 0;
            this.DesignButton.Text = "Design ";
            this.DesignButton.UseVisualStyleBackColor = true;
            this.DesignButton.Click += new System.EventHandler(this.DesignButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(232, 37);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(131, 48);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(141, 116);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(131, 48);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // madeByLabel
            // 
            this.madeByLabel.AutoSize = true;
            this.madeByLabel.Location = new System.Drawing.Point(285, 172);
            this.madeByLabel.Name = "madeByLabel";
            this.madeByLabel.Size = new System.Drawing.Size(129, 13);
            this.madeByLabel.TabIndex = 3;
            this.madeByLabel.Text = "Made by Adam Rodrigues";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 194);
            this.Controls.Add(this.madeByLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.DesignButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelectionForm";
            this.Text = "Sokoban - Selection";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DesignButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label madeByLabel;
    }
}

