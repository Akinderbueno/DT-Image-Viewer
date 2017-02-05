using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatatronTestImageViewer1
{


    public partial class DTImageViewer : Form
    {
        //Fields --------------------------------------
        //public int CURRENT_INDEX;
        //public string[] filesArray;
        public ImageViewer imgV = new ImageViewer();
        public FloatingDialogue flDiag = new FloatingDialogue();
        //public GlobalV Globals = new GlobalV();
        public string testVal = "String Passed";

        public DTImageViewer()
        {
            InitializeComponent();


           
        }

        private void DTImageViewer_Load(object sender, EventArgs e)
        {

           
        }


       

        

        //---------------------------------------------



        //Toolstrip items ------------------------


        //--------------------------------------

        //Get/Set Methods--------------------------------------


        //Get Current Index
        //public int getCurrentIndex()
        //{
        //    return CURRENT_INDEX;

        //}

        ////Set Current Index
        //public void setCurrentIndex(int currentIndex)
        //{
        //    this.CURRENT_INDEX = currentIndex;

        //}

        //Get files array
        //public string[] getFilesArray()
        //{
        //    return this.filesArray;
        //}

        //public string getFilesArrayIndex(int index)
        //{
        //    return this.filesArray[index];

        //}


        //Set files array
        //public void setFilesArray(string[] filesArray)
        //{
        //    this.filesArray = filesArray;
        //}


        //get Files No
        //public string getFileNo()
        //{
        //    return ("" + (GlobalV.getCurrentIndex() + 1));
        //}


        //Load Form
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        //-----------------------------------------------------
        //General Methods ---------------------------------

        //Open Multiple Images
        public void openImagePls()
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "All files (*.*)|*.*|TIFF (*.TIF)|*.TIF|jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";



            try
            {
                if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
                {
                    //Creates an array of imported file Names. Call index with string[x]
                    imgV.setFilesArray(ofd.FileNames);

                    //filesArray[1] = "TEST.TIF";



                    string[] filesCopy = imgV.getFilesArray();
                    GlobalV.setFilesArray(filesCopy);

                    for (int a = 0; a < ofd.FileNames.Length; a = a + 1)
                    {
                        //MessageBox.Show(GlobalV.getFilesArrayIndex(a));



                        //GlobalV.setFilesArray(ofd.FileNames);
                    }

                    imgV.picImageViewer.SizeMode = PictureBoxSizeMode.Zoom;

                    GlobalV.setCurrentIndex(0);

                    //sets the current image to the index of the filesCopy array
                    Image currentImage = Image.FromFile(filesCopy[GlobalV.getCurrentIndex()]);

                    //set image viewer to current image index
                    imgV.picImageViewer.Image = currentImage;

                    updateIndexUI();
                   
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("nullReferenceException");
            }



        }

        //IncreaseCurrentIndex
        public void IncCurrentIndex(int step)
        {

            if (GlobalV.getCurrentIndex() >= 0 && GlobalV.getCurrentIndex() < ((GlobalV.getFilesArray().Length) - 1))
            {
                GlobalV.setCurrentIndex((GlobalV.getCurrentIndex() + step));
                setImage(GlobalV.getCurrentIndex());

                

                updateIndexUI();
            }



        }
        //DecreaseCurrentIndex
        public void DecCurrentIndex(int step)
        {

            if (GlobalV.getCurrentIndex() > 0 && GlobalV.getCurrentIndex() <= ((GlobalV.getFilesArray().Length) - 1))
            {
                GlobalV.setCurrentIndex((GlobalV.getCurrentIndex() - step));
                setImage(GlobalV.getCurrentIndex());


                //lblimgno.Text = "Index: " + getCurrentIndex();
                updateIndexUI();
            }


        }

        //UpdateUI
        public void updateIndexUI()
        {


            //change textbox valies
            //first
            txtbCurrent.Text = ("" + GlobalV.getFileNo());

            //last textbox

            txtbLength.Text = ("" + GlobalV.getFilesArray().Length);


        }
        //SetImage
        public void setImage(int index)
        {
            imgV.picImageViewer.Image = Image.FromFile(GlobalV.getFilesArrayIndex(index));
            //MessageBox.Show("gets image");
        }
        //ChangeImageValue(with txtbox)
        public void changedImageValue()
        {
            //MessageBox.Show(""+imgV.getFilesArray().Length);

            try
            {
                if (txtbCurrent.Text != "" & GlobalV.getFilesArrayIndex(0) != "")
                {

                    try
                    {
                        int value = Int32.Parse(txtbCurrent.Text);
                        int index = value - 1;
                       
                        if (value > 0 && value <= GlobalV.getFilesArray().Length && GlobalV.getFilesArray().Length > 0)
                        {
                            
                            setImage(index);
                            
                            GlobalV.setCurrentIndex(index);
                           
                        }
                    }

                    catch (FormatException)
                    {
                        MessageBox.Show("ChangedImageValue: catch FormatException");
                    }
                }

              
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("OutsideChangedIMVal: catch NullReference");
            }
        }

        private void openToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openImagePls();
        }

        private void saveAsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {

                imgV.picImageViewer.Image.Save(sfd.FileName);
            }
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imageViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            imgV.MdiParent = this;
            //Boolean isOpen = true;


            imgV.Show();

            



        }

        private void floatingDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flDiag.Show();
        }


        //Current and Last image Textbox functions
        private void txtbCurrent_TextChanged_1(object sender, EventArgs e)
        {
            changedImageValue();
            
        }

        private void txtbLength_TextChanged(object sender, EventArgs e)
        {

        }






        //Closing image viewer(not functional)
        private void ImageViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // this cancels the close event.
            imgV.Hide();
            MessageBox.Show("hidden");
        }



        //Zoom Functions
        public void ZoomIn(Int32 ZoomValue)
        {
            if (GlobalV.getCurrentIndex().Equals(null))
            {
                MessageBox.Show("null image");

            }
          

            imgV.picImageViewer.Width = Convert.ToInt32(imgV.picImageViewer.Width + ZoomValue);
            imgV.picImageViewer.Height = Convert.ToInt32(imgV.picImageViewer.Height + ZoomValue);
            imgV.picImageViewer.SizeMode = PictureBoxSizeMode.Zoom;

        }

        public void ZoomOut(int ZoomValue)
        {
            imgV.picImageViewer.Width = Convert.ToInt32(imgV.picImageViewer.Width - ZoomValue);
            imgV.picImageViewer.Height = Convert.ToInt32(imgV.picImageViewer.Height - ZoomValue);
            imgV.picImageViewer.SizeMode = PictureBoxSizeMode.Zoom;
        }  

        //ZoomButtons
        private void btnZoom_Click(object sender, EventArgs e)
        {
            ZoomIn(50);
            //this.Cursor = Cursors.SizeAll;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            ZoomOut(50);
        }



        //MOuse craic
        private Point _StartPoint;

        private void picImageViewer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _StartPoint = e.Location;

            MessageBox.Show("Mousedown");
        }


        private void picImageViewer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point changePoint = new Point(e.Location.X - _StartPoint.X,
                                              e.Location.Y - _StartPoint.Y);
                imgV.pnlImageV.AutoScrollPosition = new Point(-imgV.pnlImageV.AutoScrollPosition.X - changePoint.X,
                                                      -imgV.pnlImageV.AutoScrollPosition.Y - changePoint.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataGridView dg = new DataGridView();
            dg.MdiParent = this;

            dg.Show();
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            IncCurrentIndex(1);
            
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            DecCurrentIndex(1);
           
        }
    }


































}


