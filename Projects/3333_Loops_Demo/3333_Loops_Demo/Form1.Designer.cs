namespace _3333_Loops_Demo
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
            this.whileButton = new System.Windows.Forms.Button();
            this.doWhileButton = new System.Windows.Forms.Button();
            this.forButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // whileButton
            // 
            this.whileButton.Location = new System.Drawing.Point(3, 138);
            this.whileButton.Name = "whileButton";
            this.whileButton.Size = new System.Drawing.Size(75, 23);
            this.whileButton.TabIndex = 0;
            this.whileButton.Text = "while";
            this.whileButton.UseVisualStyleBackColor = true;
            this.whileButton.Click += new System.EventHandler(this.whileButton_Click);
            // 
            // doWhileButton
            // 
            this.doWhileButton.Location = new System.Drawing.Point(84, 138);
            this.doWhileButton.Name = "doWhileButton";
            this.doWhileButton.Size = new System.Drawing.Size(75, 23);
            this.doWhileButton.TabIndex = 1;
            this.doWhileButton.Text = "do-while";
            this.doWhileButton.UseVisualStyleBackColor = true;
            this.doWhileButton.Click += new System.EventHandler(this.doWhileButton_Click);
            // 
            // forButton
            // 
            this.forButton.Location = new System.Drawing.Point(167, 138);
            this.forButton.Name = "forButton";
            this.forButton.Size = new System.Drawing.Size(75, 23);
            this.forButton.TabIndex = 2;
            this.forButton.Text = "for";
            this.forButton.UseVisualStyleBackColor = true;
            this.forButton.Click += new System.EventHandler(this.forButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(34, 177);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(140, 177);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(13, 13);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(221, 95);
            this.outputListBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 212);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.forButton);
            this.Controls.Add(this.doWhileButton);
            this.Controls.Add(this.whileButton);
            this.Name = "Form1";
            this.Text = "Loops Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button whileButton;
        private System.Windows.Forms.Button doWhileButton;
        private System.Windows.Forms.Button forButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox outputListBox;
    }
}

