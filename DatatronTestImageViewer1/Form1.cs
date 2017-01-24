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
    public partial class Form1 : Form
    {
        //Fields
        static int zoomFactor = 10;
       
        private int CURRENT_INDEX;
        private string[] filesArray;
        //Constructor
        public Form1()
        {
            InitializeComponent();

        }




        //static int ZoomNumber = 0;

        Image imageOriginal;

        //Methods

        //Get Current Index
        public int getCurrentIndex()
        { 
            return CURRENT_INDEX;

        }
        

        //Set Current Index
        public void setCurrentIndex(int currentIndex)
        {
            this.CURRENT_INDEX = currentIndex;

        }

        //Get files array
        public string[] getFilesArray()
        {
            return this.filesArray;
        }

        public string getFilesArrayIndex(int index)
        {
            return this.filesArray[index];

        }


        //Set files array
        public void setFilesArray(string[] filesArray)
        {
            this.filesArray = filesArray;
        }


        //get Files No
        public string getFileNo()
        {
            return ("" + (getCurrentIndex() + 1));
        }


        //Load Form
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //ZoomTest1
        Image Zoom(Image img, Size size)
        {

            Size newSize = new Size((int)(imageOriginal.Width + 200), (int)(imageOriginal.Height + 200));
            Bitmap bmp = new Bitmap(imageOriginal, newSize);
            imageOriginal = bmp;

            //Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
            //Graphics g = Graphics.FromImage(bmp);
            //g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }






        //Toolstrip items ------------------------

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openImagePls();


        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if(sfd.ShowDialog()==DialogResult.OK && sfd.FileName.Length > 0)
            {
                picImageViewer.Image.Save(sfd.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //--------------------------------------


        //Open Multiple Images
        public void openImagePls()
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "All files (*.*)|*.*|TIFF (*.TIF)|*.TIF|jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";




            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                //Creates an array of imported file Names. Call index with string[x]
                setFilesArray(ofd.FileNames);
                string[] filesCopy = getFilesArray();

                picImageViewer.SizeMode = PictureBoxSizeMode.Zoom;

                setCurrentIndex(0);

                //sets the current image to the index of the filesCopy array
                Image currentImage = Image.FromFile(filesCopy[getCurrentIndex()]);

                //set image viewer to current image index
                picImageViewer.Image = currentImage;

                updateIndexUI();
            
            }

        }


        public void IncCurrentIndex(int step)
        {

            if(getCurrentIndex() >=0 && getCurrentIndex() < ((getFilesArray().Length) - 1))
            { 
                setCurrentIndex((getCurrentIndex() + step));
                setImage(getCurrentIndex());
                  
                lblimgno.Text = "Index: " + getCurrentIndex();

                updateIndexUI();
            }

          

        }

        public void DecCurrentIndex(int step)
        {

            if (getCurrentIndex() > 0 && getCurrentIndex() <= ((getFilesArray().Length) - 1))
            {
                setCurrentIndex((getCurrentIndex() - step));
                setImage(getCurrentIndex());
               
           
                lblimgno.Text = "Index: " + getCurrentIndex();
                updateIndexUI();
            }

           
        }


        public void updateIndexUI()
        {


            //change textbox valies
            //first
            txtbxCurrent.Text = ("" + getFileNo());

            //last textbox

            txtbxLast.Text = ("" +  getFilesArray().Length);


        }


        public void setImage(int index)
        {
            picImageViewer.Image = Image.FromFile(getFilesArrayIndex(index));

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openImagePls();
            
             
        }


      
        //---------------------------


        //ZoomInBtn (Not Functioning)
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            //ZoomNumber += 10;

            lblZoom.Text = "Zoom: " + Convert.ToString(zoomFactor) + "%";
            picImageViewer.Image = Zoom(imageOriginal, new Size(zoomFactor, zoomFactor));
        }


        //ClickImageViewer
        private void picImageViewer_Click(object sender, EventArgs e)
        {

        }


        //Next button
        private void btnNext_Click(object sender, EventArgs e)
        {
            /* Used to change cursor to a hand. Learn more to implement pan function
             *  picImageViewer.Cursor = Cursors.Hand;
             */

            //picImageViewer.Image


            if(getCurrentIndex() < filesArray.Length)
            {
                IncCurrentIndex(1);
            }

           

        }

        //Previous Button
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(getCurrentIndex() > 0)
            {
               DecCurrentIndex(1);
            }
            
        }

        private void btnViewINo_Click(object sender, EventArgs e)
        {
            lblimgno.Text = "Index: " + getCurrentIndex();
        }

        private void txtbxCurrent_TextChanged(object sender, EventArgs e)
        {


            try
            {
                if (txtbxCurrent.Text != "" & getFilesArrayIndex(0) != "")
                {
                    int value = Int32.Parse(txtbxCurrent.Text);

                    if (value > 0 && value <= getFilesArray().Length && getFilesArray().Length > 0)
                    {
                        setImage(value - 1);
               
                    }
                }


            }
            catch(NullReferenceException)
            {

            }
           



            
            
           

        }
    }
}
