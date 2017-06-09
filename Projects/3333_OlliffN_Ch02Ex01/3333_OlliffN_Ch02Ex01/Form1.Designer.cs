namespace _3333_OlliffN_Ch02Ex01
{
    partial class latinBox
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
            this.sinisterButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.dexterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sinisterButton
            // 
            this.sinisterButton.Location = new System.Drawing.Point(12, 29);
            this.sinisterButton.Name = "sinisterButton";
            this.sinisterButton.Size = new System.Drawing.Size(75, 23);
            this.sinisterButton.TabIndex = 0;
            this.sinisterButton.Text = "Sinister";
            this.sinisterButton.UseVisualStyleBackColor = true;
            this.sinisterButton.Click += new System.EventHandler(this.sinisterButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(107, 29);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(75, 23);
            this.mediumButton.TabIndex = 1;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // dexterButton
            // 
            this.dexterButton.Location = new System.Drawing.Point(197, 29);
            this.dexterButton.Name = "dexterButton";
            this.dexterButton.Size = new System.Drawing.Size(75, 23);
            this.dexterButton.TabIndex = 2;
            this.dexterButton.Text = "Dexter";
            this.dexterButton.UseVisualStyleBackColor = true;
            this.dexterButton.Click += new System.EventHandler(this.dexterButton_Click);
            // 
            // latinBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 73);
            this.Controls.Add(this.dexterButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.sinisterButton);
            this.Name = "latinBox";
            this.Text = "Latin to English Translator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sinisterButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button dexterButton;
    }
}

