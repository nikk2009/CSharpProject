namespace _3333_Ch04Ex01_Start
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
            this.label1 = new System.Windows.Forms.Label();
            this.monthsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.pointsEarnedLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalPointsLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of book(s) purchased this month:";
            // 
            // monthsTextBox
            // 
            this.monthsTextBox.Location = new System.Drawing.Point(211, 12);
            this.monthsTextBox.Name = "monthsTextBox";
            this.monthsTextBox.Size = new System.Drawing.Size(52, 20);
            this.monthsTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Points earned:";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(197, 44);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "&Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // pointsEarnedLabel
            // 
            this.pointsEarnedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pointsEarnedLabel.Location = new System.Drawing.Point(84, 39);
            this.pointsEarnedLabel.Name = "pointsEarnedLabel";
            this.pointsEarnedLabel.Size = new System.Drawing.Size(79, 23);
            this.pointsEarnedLabel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Points";
            // 
            // totalPointsLabel
            // 
            this.totalPointsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalPointsLabel.Location = new System.Drawing.Point(84, 76);
            this.totalPointsLabel.Name = "totalPointsLabel";
            this.totalPointsLabel.Size = new System.Drawing.Size(100, 23);
            this.totalPointsLabel.TabIndex = 6;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(197, 72);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(197, 101);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.checkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 128);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalPointsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pointsEarnedLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthsTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Serendipity Booksellers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox monthsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label pointsEarnedLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalPointsLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

