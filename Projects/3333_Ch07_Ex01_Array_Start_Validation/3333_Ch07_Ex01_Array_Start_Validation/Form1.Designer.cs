namespace _3333_Ch07_Ex01_Array_Start_Validation
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
            this.salesTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.salesCountLabel = new System.Windows.Forms.Label();
            this.salesAverageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales";
            // 
            // salesTextBox
            // 
            this.salesTextBox.Location = new System.Drawing.Point(97, 13);
            this.salesTextBox.Name = "salesTextBox";
            this.salesTextBox.Size = new System.Drawing.Size(100, 20);
            this.salesTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(205, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(16, 140);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 35);
            this.displayButton.TabIndex = 4;
            this.displayButton.Text = "&Display Sales";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Sales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sales Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sales Average";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(205, 140);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 35);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(110, 140);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 35);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "C&lear Sales";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalSalesLabel.Location = new System.Drawing.Point(100, 42);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(97, 23);
            this.totalSalesLabel.TabIndex = 14;
            this.totalSalesLabel.Text = "\r\n";
            // 
            // salesCountLabel
            // 
            this.salesCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salesCountLabel.Location = new System.Drawing.Point(100, 71);
            this.salesCountLabel.Name = "salesCountLabel";
            this.salesCountLabel.Size = new System.Drawing.Size(97, 23);
            this.salesCountLabel.TabIndex = 15;
            this.salesCountLabel.Text = "\r\n";
            // 
            // salesAverageLabel
            // 
            this.salesAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salesAverageLabel.Location = new System.Drawing.Point(100, 100);
            this.salesAverageLabel.Name = "salesAverageLabel";
            this.salesAverageLabel.Size = new System.Drawing.Size(97, 23);
            this.salesAverageLabel.TabIndex = 16;
            this.salesAverageLabel.Text = "\r\n";
            // 
            // Form1
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(289, 185);
            this.Controls.Add(this.salesAverageLabel);
            this.Controls.Add(this.salesCountLabel);
            this.Controls.Add(this.totalSalesLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.salesTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salesTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Label salesCountLabel;
        private System.Windows.Forms.Label salesAverageLabel;
    }
}

