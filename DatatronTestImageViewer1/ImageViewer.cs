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
    public partial class ImageViewer : Form


    {
        
        public ImageViewer()
        {
            InitializeComponent();
        }

        public string[] filesArray;
        public int CURRENT_INDEX;
        



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

        //IncreaseCurrentIndex
        public void IncCurrentIndex(int step)
        {
            MessageBox.Show(getFilesArrayIndex(0));

            if (getCurrentIndex() >= 0 && getCurrentIndex() < ((getFilesArray().Length) - 1))
            {
                setCurrentIndex((getCurrentIndex() + step));
                setImage(getCurrentIndex());

                //lblimgno.Text = "Index: " + getCurrentIndex();

                
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
               
            }


        }


        //SetImage
        public void setImage(int index)
        {
            picImageViewer.Image = Image.FromFile(getFilesArrayIndex(index));
            //MessageBox.Show("gets image");
        }

        

        public void ImageViewer_Load(object sender, EventArgs e)
        {

        }

        // Use this event handler for the FormClosing event.


        private void ImageViewer_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("Closed");
        }

       
    }
}
