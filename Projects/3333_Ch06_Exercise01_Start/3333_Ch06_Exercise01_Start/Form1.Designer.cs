namespace _3333_Ch06_Exercise01_Start
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
            this.label2 = new System.Windows.Forms.Label();
            this.fatGramsTextBox = new System.Windows.Forms.TextBox();
            this.carbGramsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fatCaloriesLabel = new System.Windows.Forms.Label();
            this.carbCaloriesLabel = new System.Windows.Forms.Label();
            this.totalCaloriesLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.calorieIntakeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Fat Grams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Carb Grams";
            // 
            // fatGramsTextBox
            // 
            this.fatGramsTextBox.Location = new System.Drawing.Point(148, 10);
            this.fatGramsTextBox.Name = "fatGramsTextBox";
            this.fatGramsTextBox.Size = new System.Drawing.Size(100, 20);
            this.fatGramsTextBox.TabIndex = 2;
            // 
            // carbGramsTextBox
            // 
            this.carbGramsTextBox.Location = new System.Drawing.Point(148, 42);
            this.carbGramsTextBox.Name = "carbGramsTextBox";
            this.carbGramsTextBox.Size = new System.Drawing.Size(100, 20);
            this.carbGramsTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calories from Fat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Calories from Carbs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Calories";
            // 
            // fatCaloriesLabel
            // 
            this.fatCaloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fatCaloriesLabel.Location = new System.Drawing.Point(148, 94);
            this.fatCaloriesLabel.Name = "fatCaloriesLabel";
            this.fatCaloriesLabel.Size = new System.Drawing.Size(100, 23);
            this.fatCaloriesLabel.TabIndex = 7;
            // 
            // carbCaloriesLabel
            // 
            this.carbCaloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carbCaloriesLabel.Location = new System.Drawing.Point(148, 130);
            this.carbCaloriesLabel.Name = "carbCaloriesLabel";
            this.carbCaloriesLabel.Size = new System.Drawing.Size(100, 23);
            this.carbCaloriesLabel.TabIndex = 8;
            // 
            // totalCaloriesLabel
            // 
            this.totalCaloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCaloriesLabel.Location = new System.Drawing.Point(148, 164);
            this.totalCaloriesLabel.Name = "totalCaloriesLabel";
            this.totalCaloriesLabel.Size = new System.Drawing.Size(100, 23);
            this.totalCaloriesLabel.TabIndex = 9;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(8, 256);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(89, 256);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(173, 256);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Calorie Intake";
            // 
            // calorieIntakeLabel
            // 
            this.calorieIntakeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calorieIntakeLabel.Location = new System.Drawing.Point(145, 202);
            this.calorieIntakeLabel.Name = "calorieIntakeLabel";
            this.calorieIntakeLabel.Size = new System.Drawing.Size(100, 23);
            this.calorieIntakeLabel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(263, 291);
            this.Controls.Add(this.calorieIntakeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalCaloriesLabel);
            this.Controls.Add(this.carbCaloriesLabel);
            this.Controls.Add(this.fatCaloriesLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carbGramsTextBox);
            this.Controls.Add(this.fatGramsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calorie Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fatGramsTextBox;
        private System.Windows.Forms.TextBox carbGramsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fatCaloriesLabel;
        private System.Windows.Forms.Label carbCaloriesLabel;
        private System.Windows.Forms.Label totalCaloriesLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label calorieIntakeLabel;
    }
}

