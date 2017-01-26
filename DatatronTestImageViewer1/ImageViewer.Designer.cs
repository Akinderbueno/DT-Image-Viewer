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
            ((System.ComponentModel.ISupportInitialize)(this.picImageViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // picImageViewer
            // 
            this.picImageViewer.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.picImageViewer.Location = new System.Drawing.Point(12, 12);
            this.picImageViewer.Name = "picImageViewer";
            this.picImageViewer.Size = new System.Drawing.Size(414, 545);
            this.picImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageViewer.TabIndex = 1;
            this.picImageViewer.TabStop = false;
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 569);
            this.Controls.Add(this.picImageViewer);
            this.Name = "ImageViewer";
            this.Text = "ImageViewer";
            this.Load += new System.EventHandler(this.ImageViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImageViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picImageViewer;
    }
}