namespace Room_Escape_by_VISIONARIES
{
    partial class frmStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStorage));
            this.picBack1 = new System.Windows.Forms.PictureBox();
            this.picBack2 = new System.Windows.Forms.PictureBox();
            this.picSprite = new System.Windows.Forms.PictureBox();
            this.picBeds = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBeds)).BeginInit();
            this.SuspendLayout();
            // 
            // picBack1
            // 
            this.picBack1.Image = ((System.Drawing.Image)(resources.GetObject("picBack1.Image")));
            this.picBack1.Location = new System.Drawing.Point(18, 18);
            this.picBack1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBack1.Name = "picBack1";
            this.picBack1.Size = new System.Drawing.Size(676, 322);
            this.picBack1.TabIndex = 0;
            this.picBack1.TabStop = false;
            this.picBack1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picBack2
            // 
            this.picBack2.Image = ((System.Drawing.Image)(resources.GetObject("picBack2.Image")));
            this.picBack2.Location = new System.Drawing.Point(573, 92);
            this.picBack2.Name = "picBack2";
            this.picBack2.Size = new System.Drawing.Size(447, 414);
            this.picBack2.TabIndex = 1;
            this.picBack2.TabStop = false;
            // 
            // picSprite
            // 
            this.picSprite.Image = ((System.Drawing.Image)(resources.GetObject("picSprite.Image")));
            this.picSprite.Location = new System.Drawing.Point(704, 71);
            this.picSprite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picSprite.Name = "picSprite";
            this.picSprite.Size = new System.Drawing.Size(478, 488);
            this.picSprite.TabIndex = 2;
            this.picSprite.TabStop = false;
            // 
            // picBeds
            // 
            this.picBeds.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBeds.Location = new System.Drawing.Point(132, 71);
            this.picBeds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBeds.Name = "picBeds";
            this.picBeds.Size = new System.Drawing.Size(362, 274);
            this.picBeds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBeds.TabIndex = 4;
            this.picBeds.TabStop = false;
            // 
            // frmStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.picBeds);
            this.Controls.Add(this.picSprite);
            this.Controls.Add(this.picBack2);
            this.Controls.Add(this.picBack1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStorage";
            this.Text = "Graphics2";
            this.Load += new System.EventHandler(this.frmStorage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBeds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picBack1;
        public System.Windows.Forms.PictureBox picBack2;
        public System.Windows.Forms.PictureBox picSprite;
        public System.Windows.Forms.PictureBox picBeds;
    }
}