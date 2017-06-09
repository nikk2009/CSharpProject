namespace _3333_OlliffN_Ch02Ex03
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.translateLabel = new System.Windows.Forms.Label();
            this.translateOutputLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sinisterPicControl = new System.Windows.Forms.PictureBox();
            this.sinisterTranslatePic = new System.Windows.Forms.PictureBox();
            this.mediumPicControl = new System.Windows.Forms.PictureBox();
            this.dexterPicControl = new System.Windows.Forms.PictureBox();
            this.mediumTranslatePic = new System.Windows.Forms.PictureBox();
            this.dexterTranslatePic = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sinisterPicControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinisterTranslatePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumPicControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexterPicControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumTranslatePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexterTranslatePic)).BeginInit();
            this.SuspendLayout();
            // 
            // translateLabel
            // 
            this.translateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateLabel.Location = new System.Drawing.Point(132, 9);
            this.translateLabel.Name = "translateLabel";
            this.translateLabel.Size = new System.Drawing.Size(232, 23);
            this.translateLabel.TabIndex = 0;
            this.translateLabel.Text = "Latin to English Translator";
            this.translateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translateOutputLabel
            // 
            this.translateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.translateOutputLabel.Location = new System.Drawing.Point(199, 54);
            this.translateOutputLabel.Name = "translateOutputLabel";
            this.translateOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.translateOutputLabel.TabIndex = 1;
            this.translateOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // sinisterPicControl
            // 
            this.sinisterPicControl.Image = ((System.Drawing.Image)(resources.GetObject("sinisterPicControl.Image")));
            this.sinisterPicControl.InitialImage = null;
            this.sinisterPicControl.Location = new System.Drawing.Point(12, 98);
            this.sinisterPicControl.Name = "sinisterPicControl";
            this.sinisterPicControl.Size = new System.Drawing.Size(100, 112);
            this.sinisterPicControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sinisterPicControl.TabIndex = 2;
            this.sinisterPicControl.TabStop = false;
            this.sinisterPicControl.Click += new System.EventHandler(this.sinisterPicControl_Click);
            // 
            // sinisterTranslatePic
            // 
            this.sinisterTranslatePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sinisterTranslatePic.Image = ((System.Drawing.Image)(resources.GetObject("sinisterTranslatePic.Image")));
            this.sinisterTranslatePic.Location = new System.Drawing.Point(56, 98);
            this.sinisterTranslatePic.Name = "sinisterTranslatePic";
            this.sinisterTranslatePic.Size = new System.Drawing.Size(100, 112);
            this.sinisterTranslatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sinisterTranslatePic.TabIndex = 3;
            this.sinisterTranslatePic.TabStop = false;
            this.sinisterTranslatePic.Visible = false;
            this.sinisterTranslatePic.Click += new System.EventHandler(this.sinisterTranslatePic_Click);
            // 
            // mediumPicControl
            // 
            this.mediumPicControl.Image = ((System.Drawing.Image)(resources.GetObject("mediumPicControl.Image")));
            this.mediumPicControl.Location = new System.Drawing.Point(199, 98);
            this.mediumPicControl.Name = "mediumPicControl";
            this.mediumPicControl.Size = new System.Drawing.Size(100, 112);
            this.mediumPicControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mediumPicControl.TabIndex = 5;
            this.mediumPicControl.TabStop = false;
            this.mediumPicControl.Click += new System.EventHandler(this.mediumPicControl_Click);
            // 
            // dexterPicControl
            // 
            this.dexterPicControl.Image = ((System.Drawing.Image)(resources.GetObject("dexterPicControl.Image")));
            this.dexterPicControl.Location = new System.Drawing.Point(393, 98);
            this.dexterPicControl.Name = "dexterPicControl";
            this.dexterPicControl.Size = new System.Drawing.Size(100, 112);
            this.dexterPicControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dexterPicControl.TabIndex = 6;
            this.dexterPicControl.TabStop = false;
            this.dexterPicControl.Click += new System.EventHandler(this.dexterPicControl_Click);
            // 
            // mediumTranslatePic
            // 
            this.mediumTranslatePic.Image = ((System.Drawing.Image)(resources.GetObject("mediumTranslatePic.Image")));
            this.mediumTranslatePic.Location = new System.Drawing.Point(223, 98);
            this.mediumTranslatePic.Name = "mediumTranslatePic";
            this.mediumTranslatePic.Size = new System.Drawing.Size(100, 112);
            this.mediumTranslatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mediumTranslatePic.TabIndex = 7;
            this.mediumTranslatePic.TabStop = false;
            this.mediumTranslatePic.Visible = false;
            this.mediumTranslatePic.Click += new System.EventHandler(this.mediumTranslatePic_Click);
            // 
            // dexterTranslatePic
            // 
            this.dexterTranslatePic.Image = ((System.Drawing.Image)(resources.GetObject("dexterTranslatePic.Image")));
            this.dexterTranslatePic.Location = new System.Drawing.Point(370, 98);
            this.dexterTranslatePic.Name = "dexterTranslatePic";
            this.dexterTranslatePic.Size = new System.Drawing.Size(100, 112);
            this.dexterTranslatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dexterTranslatePic.TabIndex = 8;
            this.dexterTranslatePic.TabStop = false;
            this.dexterTranslatePic.Visible = false;
            this.dexterTranslatePic.Click += new System.EventHandler(this.dexterTranslatePic_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(418, 227);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 262);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dexterTranslatePic);
            this.Controls.Add(this.mediumTranslatePic);
            this.Controls.Add(this.dexterPicControl);
            this.Controls.Add(this.mediumPicControl);
            this.Controls.Add(this.sinisterTranslatePic);
            this.Controls.Add(this.sinisterPicControl);
            this.Controls.Add(this.translateOutputLabel);
            this.Controls.Add(this.translateLabel);
            this.Name = "Form1";
            this.Text = "Translation Images";
            ((System.ComponentModel.ISupportInitialize)(this.sinisterPicControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinisterTranslatePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumPicControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexterPicControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumTranslatePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexterTranslatePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label translateLabel;
        private System.Windows.Forms.Label translateOutputLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox sinisterPicControl;
        private System.Windows.Forms.PictureBox sinisterTranslatePic;
        private System.Windows.Forms.PictureBox mediumPicControl;
        private System.Windows.Forms.PictureBox dexterPicControl;
        private System.Windows.Forms.PictureBox mediumTranslatePic;
        private System.Windows.Forms.PictureBox dexterTranslatePic;
        private System.Windows.Forms.Button exitButton;
    }
}

