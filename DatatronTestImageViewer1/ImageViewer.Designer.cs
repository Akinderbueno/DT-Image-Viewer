namespace DatatronTestImageViewer1
{
    partial class ImageViewer
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
            this.picImageViewer = new System.Windows.Forms.PictureBox();
            this.pnlImageV = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picImageViewer)).BeginInit();
            this.pnlImageV.SuspendLayout();
            this.SuspendLayout();
            // 
            // picImageViewer
            // 
            this.picImageViewer.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.picImageViewer.Location = new System.Drawing.Point(0, 3);
            this.picImageViewer.Name = "picImageViewer";
            this.picImageViewer.Size = new System.Drawing.Size(429, 586);
            this.picImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageViewer.TabIndex = 1;
            this.picImageViewer.TabStop = false;
            // 
            // pnlImageV
            // 
            this.pnlImageV.AutoScroll = true;
            this.pnlImageV.Controls.Add(this.picImageViewer);
            this.pnlImageV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImageV.Location = new System.Drawing.Point(0, 0);
            this.pnlImageV.Name = "pnlImageV";
            this.pnlImageV.Size = new System.Drawing.Size(429, 592);
            this.pnlImageV.TabIndex = 2;
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 592);
            this.Controls.Add(this.pnlImageV);
            this.Name = "ImageViewer";
            this.Text = "ImageViewer";
            this.Load += new System.EventHandler(this.ImageViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImageViewer)).EndInit();
            this.pnlImageV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picImageViewer;
        public System.Windows.Forms.Panel pnlImageV;
    }
}