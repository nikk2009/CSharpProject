namespace _3333_OlliffN_Exam01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.purchaseTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.purchaseAmmountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.countyTaxLabel = new System.Windows.Forms.Label();
            this.totalTaxLabel = new System.Windows.Forms.Label();
            this.totalSaleLabel = new System.Windows.Forms.Label();
            this.overallSalesLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseTextBox
            // 
            this.purchaseTextBox.Location = new System.Drawing.Point(197, 15);
            this.purchaseTextBox.Name = "purchaseTextBox";
            this.purchaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.purchaseTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Purchase Ammount:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.overallSalesLabel);
            this.groupBox1.Controls.Add(this.totalSaleLabel);
            this.groupBox1.Controls.Add(this.totalTaxLabel);
            this.groupBox1.Controls.Add(this.countyTaxLabel);
            this.groupBox1.Controls.Add(this.salesTaxLabel);
            this.groupBox1.Controls.Add(this.purchaseAmmountLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 308);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // purchaseAmmountLabel
            // 
            this.purchaseAmmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purchaseAmmountLabel.Location = new System.Drawing.Point(165, 16);
            this.purchaseAmmountLabel.Name = "purchaseAmmountLabel";
            this.purchaseAmmountLabel.Size = new System.Drawing.Size(100, 23);
            this.purchaseAmmountLabel.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Overall Sales:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Sale:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Sales Tax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "County Sales Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "State Sales Tax:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Purchase Ammount:";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salesTaxLabel.Location = new System.Drawing.Point(165, 68);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(100, 23);
            this.salesTaxLabel.TabIndex = 10;
            // 
            // countyTaxLabel
            // 
            this.countyTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countyTaxLabel.Location = new System.Drawing.Point(165, 120);
            this.countyTaxLabel.Name = "countyTaxLabel";
            this.countyTaxLabel.Size = new System.Drawing.Size(100, 23);
            this.countyTaxLabel.TabIndex = 11;
            // 
            // totalTaxLabel
            // 
            this.totalTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalTaxLabel.Location = new System.Drawing.Point(165, 172);
            this.totalTaxLabel.Name = "totalTaxLabel";
            this.totalTaxLabel.Size = new System.Drawing.Size(100, 23);
            this.totalTaxLabel.TabIndex = 12;
            // 
            // totalSaleLabel
            // 
            this.totalSaleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalSaleLabel.Location = new System.Drawing.Point(165, 224);
            this.totalSaleLabel.Name = "totalSaleLabel";
            this.totalSaleLabel.Size = new System.Drawing.Size(100, 23);
            this.totalSaleLabel.TabIndex = 13;
            // 
            // overallSalesLabel
            // 
            this.overallSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.overallSalesLabel.Location = new System.Drawing.Point(165, 276);
            this.overallSalesLabel.Name = "overallSalesLabel";
            this.overallSalesLabel.Size = new System.Drawing.Size(100, 23);
            this.overallSalesLabel.TabIndex = 14;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(32, 355);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Ca&lculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(131, 355);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(222, 355);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(335, 381);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.purchaseTextBox);
            this.Name = "Form1";
            this.Text = "Tax Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox purchaseTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label purchaseAmmountLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label overallSalesLabel;
        private System.Windows.Forms.Label totalSaleLabel;
        private System.Windows.Forms.Label totalTaxLabel;
        private System.Windows.Forms.Label countyTaxLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

