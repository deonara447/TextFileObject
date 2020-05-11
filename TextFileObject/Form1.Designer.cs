namespace TextFileObject
{
    partial class Form1
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
            this.addScoreButton = new System.Windows.Forms.Button();
            this.sortScoresButton = new System.Windows.Forms.Button();
            this.saveScoresButton = new System.Windows.Forms.Button();
            this.loadScoresButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreInput = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.name2Label = new System.Windows.Forms.Label();
            this.nameRemove = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addScoreButton
            // 
            this.addScoreButton.Location = new System.Drawing.Point(94, 135);
            this.addScoreButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addScoreButton.Name = "addScoreButton";
            this.addScoreButton.Size = new System.Drawing.Size(231, 78);
            this.addScoreButton.TabIndex = 18;
            this.addScoreButton.Text = "Search Book";
            this.addScoreButton.UseVisualStyleBackColor = true;
            this.addScoreButton.Click += new System.EventHandler(this.addScoreButton_Click);
            // 
            // sortScoresButton
            // 
            this.sortScoresButton.Location = new System.Drawing.Point(338, 750);
            this.sortScoresButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortScoresButton.Name = "sortScoresButton";
            this.sortScoresButton.Size = new System.Drawing.Size(231, 72);
            this.sortScoresButton.TabIndex = 17;
            this.sortScoresButton.Text = "Sort Scores";
            this.sortScoresButton.UseVisualStyleBackColor = true;
            this.sortScoresButton.Click += new System.EventHandler(this.sortScoresButton_Click);
            // 
            // saveScoresButton
            // 
            this.saveScoresButton.Location = new System.Drawing.Point(342, 734);
            this.saveScoresButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveScoresButton.Name = "saveScoresButton";
            this.saveScoresButton.Size = new System.Drawing.Size(231, 72);
            this.saveScoresButton.TabIndex = 16;
            this.saveScoresButton.Text = "Save and Close";
            this.saveScoresButton.UseVisualStyleBackColor = true;
            this.saveScoresButton.Click += new System.EventHandler(this.saveScoresButton_Click);
            // 
            // loadScoresButton
            // 
            this.loadScoresButton.Location = new System.Drawing.Point(338, 750);
            this.loadScoresButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadScoresButton.Name = "loadScoresButton";
            this.loadScoresButton.Size = new System.Drawing.Size(231, 72);
            this.loadScoresButton.TabIndex = 15;
            this.loadScoresButton.Text = "Load Scores";
            this.loadScoresButton.UseVisualStyleBackColor = true;
            this.loadScoresButton.Click += new System.EventHandler(this.loadScoresButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.Control;
            this.outputLabel.Location = new System.Drawing.Point(256, 653);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(342, 169);
            this.outputLabel.TabIndex = 14;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(104, 69);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(90, 31);
            this.nameInput.TabIndex = 19;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 75);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 25);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Ref #";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(12, 242);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(73, 25);
            this.scoreLabel.TabIndex = 22;
            this.scoreLabel.Text = "Binary";
            // 
            // scoreInput
            // 
            this.scoreInput.Location = new System.Drawing.Point(94, 236);
            this.scoreInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scoreInput.Name = "scoreInput";
            this.scoreInput.Size = new System.Drawing.Size(521, 31);
            this.scoreInput.TabIndex = 21;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(327, 728);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(231, 78);
            this.removeButton.TabIndex = 23;
            this.removeButton.Text = "Remove Score";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // name2Label
            // 
            this.name2Label.AutoSize = true;
            this.name2Label.Location = new System.Drawing.Point(13, 314);
            this.name2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name2Label.Name = "name2Label";
            this.name2Label.Size = new System.Drawing.Size(72, 25);
            this.name2Label.TabIndex = 25;
            this.name2Label.Text = "Linear";
            // 
            // nameRemove
            // 
            this.nameRemove.Location = new System.Drawing.Point(94, 314);
            this.nameRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameRemove.Name = "nameRemove";
            this.nameRemove.Size = new System.Drawing.Size(521, 31);
            this.nameRemove.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 866);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.name2Label);
            this.Controls.Add(this.nameRemove);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.scoreInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.addScoreButton);
            this.Controls.Add(this.sortScoresButton);
            this.Controls.Add(this.saveScoresButton);
            this.Controls.Add(this.loadScoresButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addScoreButton;
        private System.Windows.Forms.Button sortScoresButton;
        private System.Windows.Forms.Button saveScoresButton;
        private System.Windows.Forms.Button loadScoresButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox scoreInput;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label name2Label;
        private System.Windows.Forms.TextBox nameRemove;
    }
}

