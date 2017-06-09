namespace _3333_OlliffN_Lab07
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
            this.scoreAverageLabel = new System.Windows.Forms.Label();
            this.scoreCountLabel = new System.Windows.Forms.Label();
            this.totalScoreLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.scoresTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreAverageLabel
            // 
            this.scoreAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreAverageLabel.Location = new System.Drawing.Point(93, 105);
            this.scoreAverageLabel.Name = "scoreAverageLabel";
            this.scoreAverageLabel.Size = new System.Drawing.Size(97, 23);
            this.scoreAverageLabel.TabIndex = 28;
            this.scoreAverageLabel.Text = "\r\n";
            // 
            // scoreCountLabel
            // 
            this.scoreCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreCountLabel.Location = new System.Drawing.Point(93, 76);
            this.scoreCountLabel.Name = "scoreCountLabel";
            this.scoreCountLabel.Size = new System.Drawing.Size(97, 23);
            this.scoreCountLabel.TabIndex = 27;
            this.scoreCountLabel.Text = "\r\n";
            // 
            // totalScoreLabel
            // 
            this.totalScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalScoreLabel.Location = new System.Drawing.Point(93, 47);
            this.totalScoreLabel.Name = "totalScoreLabel";
            this.totalScoreLabel.Size = new System.Drawing.Size(97, 23);
            this.totalScoreLabel.TabIndex = 26;
            this.totalScoreLabel.Text = "\r\n";
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(186, 135);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 22);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "C&lear Scores";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(197, 166);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 22);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Average";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Score Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Total Score";
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(12, 135);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(86, 22);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "&Display Scores";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(197, 18);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // scoresTextBox
            // 
            this.scoresTextBox.Location = new System.Drawing.Point(90, 18);
            this.scoresTextBox.Name = "scoresTextBox";
            this.scoresTextBox.Size = new System.Drawing.Size(100, 20);
            this.scoresTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Score";
            // 
            // Form1
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.scoreAverageLabel);
            this.Controls.Add(this.scoreCountLabel);
            this.Controls.Add(this.totalScoreLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.scoresTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreAverageLabel;
        private System.Windows.Forms.Label scoreCountLabel;
        private System.Windows.Forms.Label totalScoreLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox scoresTextBox;
        private System.Windows.Forms.Label label1;
    }
}

