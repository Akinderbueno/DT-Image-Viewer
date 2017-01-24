using System;

namespace DatatronTestImageViewer1
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
            this.picImageViewer = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.lblZoom = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtbxCurrent = new System.Windows.Forms.TextBox();
            this.txtbxLast = new System.Windows.Forms.TextBox();
            this.lblImageNo = new System.Windows.Forms.Label();
            this.btnViewINo = new System.Windows.Forms.Button();
            this.lblimgno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImageViewer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picImageViewer
            // 
            this.picImageViewer.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.picImageViewer.Location = new System.Drawing.Point(106, 39);
            this.picImageViewer.Name = "picImageViewer";
            this.picImageViewer.Size = new System.Drawing.Size(388, 473);
            this.picImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageViewer.TabIndex = 0;
            this.picImageViewer.TabStop = false;
            this.picImageViewer.Click += new System.EventHandler(this.picImageViewer_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(521, 39);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(195, 75);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.Location = new System.Drawing.Point(79, 518);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(61, 59);
            this.btnZoomOut.TabIndex = 3;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomIn.Location = new System.Drawing.Point(12, 518);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(61, 59);
            this.btnZoomIn.TabIndex = 4;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.Location = new System.Drawing.Point(666, 563);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(81, 25);
            this.lblZoom.TabIndex = 5;
            this.lblZoom.Text = "ZoomN";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(445, 526);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(49, 50);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(390, 526);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(49, 50);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtbxCurrent
            // 
            this.txtbxCurrent.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtbxCurrent.Location = new System.Drawing.Point(12, 107);
            this.txtbxCurrent.Name = "txtbxCurrent";
            this.txtbxCurrent.Size = new System.Drawing.Size(36, 20);
            this.txtbxCurrent.TabIndex = 8;
            this.txtbxCurrent.Text = " ";
            this.txtbxCurrent.TextChanged += new System.EventHandler(this.txtbxCurrent_TextChanged);
            // 
            // txtbxLast
            // 
            this.txtbxLast.Location = new System.Drawing.Point(54, 107);
            this.txtbxLast.Name = "txtbxLast";
            this.txtbxLast.Size = new System.Drawing.Size(36, 20);
            this.txtbxLast.TabIndex = 9;
            // 
            // lblImageNo
            // 
            this.lblImageNo.AutoSize = true;
            this.lblImageNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageNo.Location = new System.Drawing.Point(13, 88);
            this.lblImageNo.Name = "lblImageNo";
            this.lblImageNo.Size = new System.Drawing.Size(46, 16);
            this.lblImageNo.TabIndex = 10;
            this.lblImageNo.Text = "Image";
            // 
            // btnViewINo
            // 
            this.btnViewINo.Location = new System.Drawing.Point(561, 187);
            this.btnViewINo.Name = "btnViewINo";
            this.btnViewINo.Size = new System.Drawing.Size(75, 23);
            this.btnViewINo.TabIndex = 11;
            this.btnViewINo.Text = "View No,";
            this.btnViewINo.UseVisualStyleBackColor = true;
            this.btnViewINo.Click += new System.EventHandler(this.btnViewINo_Click);
            // 
            // lblimgno
            // 
            this.lblimgno.AutoSize = true;
            this.lblimgno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimgno.Location = new System.Drawing.Point(558, 227);
            this.lblimgno.Name = "lblimgno";
            this.lblimgno.Size = new System.Drawing.Size(21, 31);
            this.lblimgno.TabIndex = 12;
            this.lblimgno.Text = " ";
            this.lblimgno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 597);
            this.Controls.Add(this.lblimgno);
            this.Controls.Add(this.btnViewINo);
            this.Controls.Add(this.lblImageNo);
            this.Controls.Add(this.txtbxLast);
            this.Controls.Add(this.txtbxCurrent);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picImageViewer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImageViewer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.PictureBox picImageViewer;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtbxCurrent;
        private System.Windows.Forms.TextBox txtbxLast;
        private System.Windows.Forms.Label lblImageNo;
        private System.Windows.Forms.Button btnViewINo;
        private System.Windows.Forms.Label lblimgno;
    }
}

