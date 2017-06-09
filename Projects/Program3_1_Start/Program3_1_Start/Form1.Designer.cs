namespace Program3_1_Start
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.formatOneButton = new System.Windows.Forms.Button();
            this.formatTwoButton = new System.Windows.Forms.Button();
            this.formatThreeButton = new System.Windows.Forms.Button();
            this.formatFourButton = new System.Windows.Forms.Button();
            this.formatFiveButton = new System.Windows.Forms.Button();
            this.formatSixButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(221, 12);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(221, 39);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(221, 66);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(221, 92);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "First name: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Middle name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preferred title (Mr., Mrs., Ms., Dr., etc.):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(16, 126);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(315, 23);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formatOneButton
            // 
            this.formatOneButton.Location = new System.Drawing.Point(12, 165);
            this.formatOneButton.Name = "formatOneButton";
            this.formatOneButton.Size = new System.Drawing.Size(75, 23);
            this.formatOneButton.TabIndex = 9;
            this.formatOneButton.Text = "Format 1";
            this.formatOneButton.UseVisualStyleBackColor = true;
            this.formatOneButton.Click += new System.EventHandler(this.formatOneButton_Click);
            // 
            // formatTwoButton
            // 
            this.formatTwoButton.Location = new System.Drawing.Point(93, 165);
            this.formatTwoButton.Name = "formatTwoButton";
            this.formatTwoButton.Size = new System.Drawing.Size(75, 23);
            this.formatTwoButton.TabIndex = 10;
            this.formatTwoButton.Text = "Format 2";
            this.formatTwoButton.UseVisualStyleBackColor = true;
            this.formatTwoButton.Click += new System.EventHandler(this.formatTwoButton_Click);
            // 
            // formatThreeButton
            // 
            this.formatThreeButton.Location = new System.Drawing.Point(174, 165);
            this.formatThreeButton.Name = "formatThreeButton";
            this.formatThreeButton.Size = new System.Drawing.Size(75, 23);
            this.formatThreeButton.TabIndex = 11;
            this.formatThreeButton.Text = "Format 3";
            this.formatThreeButton.UseVisualStyleBackColor = true;
            this.formatThreeButton.Click += new System.EventHandler(this.formatThreeButton_Click);
            // 
            // formatFourButton
            // 
            this.formatFourButton.Location = new System.Drawing.Point(256, 165);
            this.formatFourButton.Name = "formatFourButton";
            this.formatFourButton.Size = new System.Drawing.Size(75, 23);
            this.formatFourButton.TabIndex = 12;
            this.formatFourButton.Text = "Format 4";
            this.formatFourButton.UseVisualStyleBackColor = true;
            this.formatFourButton.Click += new System.EventHandler(this.formatFourButton_Click);
            // 
            // formatFiveButton
            // 
            this.formatFiveButton.Location = new System.Drawing.Point(53, 194);
            this.formatFiveButton.Name = "formatFiveButton";
            this.formatFiveButton.Size = new System.Drawing.Size(75, 23);
            this.formatFiveButton.TabIndex = 13;
            this.formatFiveButton.Text = "Format 5";
            this.formatFiveButton.UseVisualStyleBackColor = true;
            this.formatFiveButton.Click += new System.EventHandler(this.formatFiveButton_Click);
            // 
            // formatSixButton
            // 
            this.formatSixButton.Location = new System.Drawing.Point(210, 194);
            this.formatSixButton.Name = "formatSixButton";
            this.formatSixButton.Size = new System.Drawing.Size(75, 23);
            this.formatSixButton.TabIndex = 14;
            this.formatSixButton.Text = "Format 6";
            this.formatSixButton.UseVisualStyleBackColor = true;
            this.formatSixButton.Click += new System.EventHandler(this.formatSixButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(83, 232);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(183, 232);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 267);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.formatSixButton);
            this.Controls.Add(this.formatFiveButton);
            this.Controls.Add(this.formatFourButton);
            this.Controls.Add(this.formatThreeButton);
            this.Controls.Add(this.formatTwoButton);
            this.Controls.Add(this.formatOneButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "Form1";
            this.Text = "Name Formatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button formatOneButton;
        private System.Windows.Forms.Button formatTwoButton;
        private System.Windows.Forms.Button formatThreeButton;
        private System.Windows.Forms.Button formatFourButton;
        private System.Windows.Forms.Button formatFiveButton;
        private System.Windows.Forms.Button formatSixButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

