namespace PictureBox
{
    partial class PictureBox
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btChoosePicture = new System.Windows.Forms.Button();
            this.btClearImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btChoosePicture
            // 
            this.btChoosePicture.Location = new System.Drawing.Point(572, 160);
            this.btChoosePicture.Name = "btChoosePicture";
            this.btChoosePicture.Size = new System.Drawing.Size(135, 36);
            this.btChoosePicture.TabIndex = 1;
            this.btChoosePicture.Text = "Choose Picture";
            this.btChoosePicture.UseVisualStyleBackColor = true;
            this.btChoosePicture.Click += new System.EventHandler(this.btChoosePicture_Click);
            // 
            // btClearImage
            // 
            this.btClearImage.Location = new System.Drawing.Point(572, 247);
            this.btClearImage.Name = "btClearImage";
            this.btClearImage.Size = new System.Drawing.Size(135, 36);
            this.btClearImage.TabIndex = 2;
            this.btClearImage.Text = "Clear Image";
            this.btClearImage.UseVisualStyleBackColor = true;
            this.btClearImage.Click += new System.EventHandler(this.btClearImage_Click);
            // 
            // PictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btClearImage);
            this.Controls.Add(this.btChoosePicture);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PictureBox";
            this.Text = "PictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btChoosePicture;
        private System.Windows.Forms.Button btClearImage;
    }
}

