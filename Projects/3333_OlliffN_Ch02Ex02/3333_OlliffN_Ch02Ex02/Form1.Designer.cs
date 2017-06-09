namespace _3333_OlliffN_Ch02Ex02
{
    partial class translatorBox
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
            this.translateLabel = new System.Windows.Forms.Label();
            this.translateOutput = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sinisterButton
            // 
            this.sinisterButton.Location = new System.Drawing.Point(12, 98);
            this.sinisterButton.Name = "sinisterButton";
            this.sinisterButton.Size = new System.Drawing.Size(75, 23);
            this.sinisterButton.TabIndex = 0;
            this.sinisterButton.Text = "Sinister";
            this.sinisterButton.UseVisualStyleBackColor = true;
            this.sinisterButton.Click += new System.EventHandler(this.sinisterButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(143, 98);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(75, 23);
            this.mediumButton.TabIndex = 1;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // dexterButton
            // 
            this.dexterButton.Location = new System.Drawing.Point(273, 98);
            this.dexterButton.Name = "dexterButton";
            this.dexterButton.Size = new System.Drawing.Size(75, 23);
            this.dexterButton.TabIndex = 2;
            this.dexterButton.Text = "Dexter";
            this.dexterButton.UseVisualStyleBackColor = true;
            this.dexterButton.Click += new System.EventHandler(this.dexterButton_Click);
            // 
            // translateLabel
            // 
            this.translateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.translateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateLabel.Location = new System.Drawing.Point(12, 9);
            this.translateLabel.Name = "translateLabel";
            this.translateLabel.Size = new System.Drawing.Size(336, 23);
            this.translateLabel.TabIndex = 3;
            this.translateLabel.Text = "Latin to English Translator";
            this.translateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translateOutput
            // 
            this.translateOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.translateOutput.Location = new System.Drawing.Point(83, 48);
            this.translateOutput.Name = "translateOutput";
            this.translateOutput.Size = new System.Drawing.Size(195, 47);
            this.translateOutput.TabIndex = 4;
            this.translateOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(83, 127);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(203, 127);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // translatorBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 161);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.translateOutput);
            this.Controls.Add(this.translateLabel);
            this.Controls.Add(this.dexterButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.sinisterButton);
            this.Name = "translatorBox";
            this.Text = "Translator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sinisterButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button dexterButton;
        private System.Windows.Forms.Label translateLabel;
        private System.Windows.Forms.Label translateOutput;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

