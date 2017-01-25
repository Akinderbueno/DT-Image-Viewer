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
        public DTImageViewer()
        {
            InitializeComponent();
        }

        private void DTImageViewer_Load(object sender, EventArgs e)
        {


        }


        //Fields --------------------------------------
        private int CURRENT_INDEX;
        private string[] filesArray;
        ImageViewer imgV = new ImageViewer();
        
        
        //---------------------------------------------



        //Toolstrip items ------------------------


        //--------------------------------------

        //Get/Set Methods--------------------------------------

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



        //-----------------------------------------------------
        //General Methods ---------------------------------

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

                //picImageViewer.SizeMode = PictureBoxSizeMode.Zoom;

                setCurrentIndex(0);

                //sets the current image to the index of the filesCopy array
                Image currentImage = Image.FromFile(filesCopy[getCurrentIndex()]);

                //set image viewer to current image index
               // picImageViewer.Image = currentImage;

                updateIndexUI();

            }

        }

        //IncreaseCurrentIndex
        public void IncCurrentIndex(int step)
        {

            if (getCurrentIndex() >= 0 && getCurrentIndex() < ((getFilesArray().Length) - 1))
            {
                setCurrentIndex((getCurrentIndex() + step));
                setImage(getCurrentIndex());

                //lblimgno.Text = "Index: " + getCurrentIndex();

                updateIndexUI();
            }



        }
        //DecreaseCurrentIndex
        public void DecCurrentIndex(int step)
        {

            if (getCurrentIndex() > 0 && getCurrentIndex() <= ((getFilesArray().Length) - 1))
            {
                setCurrentIndex((getCurrentIndex() - step));
                setImage(getCurrentIndex());


                //lblimgno.Text = "Index: " + getCurrentIndex();
                updateIndexUI();
            }


        }

        //UpdateUI
        public void updateIndexUI()
        {


            //change textbox valies
            //first
            txtbxCurrent.Text = ("" + getFileNo());

            //last textbox

            txtbxLast.Text = ("" + getFilesArray().Length);


        }
        //SetImage
        public void setImage(int index)
        {
            //imgV.picImageViewer.Image = Image.FromFile(getFilesArrayIndex(index));

        }
        //ChangeImageValue(with txtbox)
        public void changedImageValue()
        {
            try
            {
                if (txtbxCurrent.Text != "" & getFilesArrayIndex(0) != "")
                {

                    try
                    {
                        int value = Int32.Parse(txtbxCurrent.Text);
                        int index = value - 1;

                        if (value > 0 && value <= getFilesArray().Length && getFilesArray().Length > 0)
                        {
                            setImage(index);
                            setCurrentIndex(index);
                        }
                    }

                    catch (FormatException)
                    {

                    }
                }

            }
            catch (NullReferenceException)
            {
            }
        }



        private void txtbxCurrent_TextChanged(object sender, EventArgs e)
        {

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

                //imgV.picImageViewer.Image.Save(sfd.FileName);
            }
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imageViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageViewer imgV1 = new ImageViewer();
            imgV1.MdiParent = this;
            imgV1.Show();
        }
    }


































}


