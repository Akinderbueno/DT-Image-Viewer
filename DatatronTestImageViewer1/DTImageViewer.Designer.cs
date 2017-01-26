namespace DatatronTestImageViewer1
{
    partial class DTImageViewer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblImageNo = new System.Windows.Forms.Label();
            this.txtbxLast = new System.Windows.Forms.TextBox();
            this.txtbxCurrent = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblImage = new System.Windows.Forms.Label();
            this.txtbCurrent = new System.Windows.Forms.TextBox();
            this.txtbLength = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.floatingDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbLength);
            this.panel1.Controls.Add(this.lblImage);
            this.panel1.Controls.Add(this.txtbCurrent);
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 603);
            this.panel1.TabIndex = 0;
            // 
            // lblImageNo
            // 
            this.lblImageNo.AutoSize = true;
            this.lblImageNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageNo.Location = new System.Drawing.Point(10, 24);
            this.lblImageNo.Name = "lblImageNo";
            this.lblImageNo.Size = new System.Drawing.Size(46, 16);
            this.lblImageNo.TabIndex = 13;
            this.lblImageNo.Text = "Image";
            // 
            // txtbxLast
            // 
            this.txtbxLast.Location = new System.Drawing.Point(47, 43);
            this.txtbxLast.Name = "txtbxLast";
            this.txtbxLast.Size = new System.Drawing.Size(36, 20);
            this.txtbxLast.TabIndex = 12;
            // 
            // txtbxCurrent
            // 
            this.txtbxCurrent.Location = new System.Drawing.Point(0, 0);
            this.txtbxCurrent.Name = "txtbxCurrent";
            this.txtbxCurrent.Size = new System.Drawing.Size(100, 20);
            this.txtbxCurrent.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem2,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // fileToolStripMenuItem2
            // 
            this.fileToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem2,
            this.saveAsToolStripMenuItem2,
            this.exitToolStripMenuItem2});
            this.fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            this.fileToolStripMenuItem2.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem2.Text = "File";
            // 
            // openToolStripMenuItem2
            // 
            this.openToolStripMenuItem2.Name = "openToolStripMenuItem2";
            this.openToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem2.Text = "Open";
            this.openToolStripMenuItem2.Click += new System.EventHandler(this.openToolStripMenuItem2_Click);
            // 
            // saveAsToolStripMenuItem2
            // 
            this.saveAsToolStripMenuItem2.Name = "saveAsToolStripMenuItem2";
            this.saveAsToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem2.Text = "Save As";
            this.saveAsToolStripMenuItem2.Click += new System.EventHandler(this.saveAsToolStripMenuItem2_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem2.Text = "Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageViewerToolStripMenuItem,
            this.floatingDToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "View";
            // 
            // imageViewerToolStripMenuItem
            // 
            this.imageViewerToolStripMenuItem.Name = "imageViewerToolStripMenuItem";
            this.imageViewerToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.imageViewerToolStripMenuItem.Text = "Image Viewer";
            this.imageViewerToolStripMenuItem.Click += new System.EventHandler(this.imageViewerToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(12, 36);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(39, 13);
            this.lblImage.TabIndex = 5;
            this.lblImage.Text = "Image:";
            // 
            // txtbCurrent
            // 
            this.txtbCurrent.Location = new System.Drawing.Point(10, 52);
            this.txtbCurrent.Name = "txtbCurrent";
            this.txtbCurrent.Size = new System.Drawing.Size(27, 20);
            this.txtbCurrent.TabIndex = 6;
            this.txtbCurrent.TextChanged += new System.EventHandler(this.txtbCurrent_TextChanged_1);
            // 
            // txtbLength
            // 
            this.txtbLength.Location = new System.Drawing.Point(42, 52);
            this.txtbLength.Name = "txtbLength";
            this.txtbLength.Size = new System.Drawing.Size(27, 20);
            this.txtbLength.TabIndex = 7;
            this.txtbLength.TextChanged += new System.EventHandler(this.txtbLength_TextChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(84, 603);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // floatingDToolStripMenuItem
            // 
            this.floatingDToolStripMenuItem.Name = "floatingDToolStripMenuItem";
            this.floatingDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.floatingDToolStripMenuItem.Text = "Floating D";
            this.floatingDToolStripMenuItem.Click += new System.EventHandler(this.floatingDToolStripMenuItem_Click);
            // 
            // DTImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 627);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "DTImageViewer";
            this.Text = "DTImageViewer";
            this.Load += new System.EventHandler(this.DTImageViewer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label lblImageNo;
        private System.Windows.Forms.TextBox txtbxLast;
        private System.Windows.Forms.TextBox txtbxCurrent;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imageViewerToolStripMenuItem;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.TextBox txtbCurrent;
        private System.Windows.Forms.TextBox txtbLength;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem floatingDToolStripMenuItem;
    }
}