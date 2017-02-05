using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace DatatronTestImageViewer1
{
    public partial class FloatingDialogue : Form
    {

        //Fields

        //public DTImageViewer DTI = new DTImageViewer();


        //private var imageViewer1 = new DTImageViewer();

        //string newString = newDti.getFilesArrayIndex(0);




        //private DTImageViewer DTI = new DTImageViewer();



        public FloatingDialogue()
        {
            InitializeComponent();

            //this.DTI = DTIm;
            //newDti = imgV.getFilesArrayIndex(0);

            //var newDti = new DTImageViewer();

        }

        private void FloatingDialogue_Load(object sender, EventArgs e)
        {
            



        }

        //Next and Save button 
        private void btnNextSave_Click(object sender, EventArgs e)
        {


           

            AddToDatabase();


        }
  

        public void AddToDatabase()
        {

            string connString = ("SERVER=109.73.168.215;PORT=3306;database=robihari_datatron;UID=robihari_robi;PASSWORD=rUc!uZkqre$1;");


            MySqlConnection conn = new MySqlConnection(connString);
            //String insertQuery = "INSERT INTO robihari_datatron.exportcsv(Image_Name,Payroll_ID,Surname,Forename,Job_Title,Department) VALUES ('0124.tif', '124', 'Davies', 'Cale', 'Engineer', 'Software');";
            String insertQuery = "INSERT INTO robihari_datatron.exportcsv(Image_Name,Payroll_ID,Surname,Forename,Job_Title,Department) VALUES ('newDti','" + payroll_IDTextBox.Text + "','" + surnameTextBox.Text + "','" + titleTextBox.Text + "','" + titleTextBox.Text + "','" + groupTextBox.Text + "');";
            conn.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, conn);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Inserted");
            }
            else
            {
                MessageBox.Show("Data NOT Inserted");
            }


            conn.Close();


        }


        public void SaveToCSV()
        {




        }


        private void btnNxt_Click(object sender, EventArgs e)
        {
            ////DTImageViewer dtIV = new DTImageViewer();
            //if(getCurrentIndex() < filesArray.Length)
            //{
            //    DTImageViewer.IncCurrentIndex(1);
            //}


            //var IV = new ImageViewer();
            //var DTI = new DTImageViewer();

            //IV.IncCurrentIndex(1);
            //DTI.updateIndexUI();





        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            //try access object method from different class here


        }


        private void SelectFromDatabase()
        {

        }



        private void RandomCollection()
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\University\Source\Repos\DT-Image-Viewer\DatatronTestImageViewer1\recordDB.mdf;Integrated Security=True");
            //con.Open();

            //SqlCommand sc = new SqlCommand("Insert into values('"+payroll_IDTextBox.Text+"','"+surnameTextBox.Text+"','"+forenameTextBox.Text+"','"+titleTextBox+"','"+groupTextBox+"');"z);

            //int o = sc.ExecuteNonQuery();
            //MessageBox.Show(o + "  :Record has been inserted");
            //con.Close();




            //string constring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\University\Source\Repos\DT-Image-Viewer\DatatronTestImageViewer1\recordDB.mdf;Integrated Security=True");

            //string query = ("insert into recordDB.Table (Payroll ID,Surname,Forename,Title,Group) values('"+this.payroll_IDTextBox.Text+"','"+this.surnameTextBox.Text+"','"+this.forenameTextBox.Text+"','"+this.titleTextBox.Text+"','"+this.groupTextBox.Text+"') ; ");

            //SqlConnection conDatabase = new SqlConnection(constring);
            //SqlCommand cmdDatabase = new SqlCommand(query);

            //SqlDataReader myReader;

            //try
            //{
            //    conDatabase.Open();
            //    myReader = cmdDatabase.ExecuteReader();
            //    MessageBox.Show("Saved");

            //    while (myReader.Read())
            //    {

            //    }

            //} catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}



            //MySqlCommand command = conn
            //("insert into recordDB.Table (Payroll ID,Surname,Forename,Title,Group) values('"+this.payroll_IDTextBox.Text+"','"+this.surnameTextBox.Text+"','"+this.forenameTextBox.Text+"','"+this.titleTextBox.Text+"','"+this.groupTextBox.Text+"') ; ");

            // MySqlConnection conDatabase = new MySqlConnection(conString);


            //command.CommandText = "INSERT INTO exportcsv (Imagename,PayrollID,Surname,Forename,JobTitle,Department) VALUES('0123.tif','123','Harid','Robi','Engineer','Software');";


            //            try
            //            {
            //                MySqlConnection conn = new MySqlConnection();
            //                conn.ConnectionString = conString;
            //                conn.Open();
            //                MessageBox.Show("Connection Success!");
            //}
            //            catch (MySql.Data.MySqlClient.MySqlException ex)
            //            {
            //                MessageBox.Show(ex.Message);
            //            }

            //string connString = ("SERVER=109.73.168.215;PORT=3306;database=robihari_datatron;UID=robihari_robi;PASSWORD=rUc!uZkqre$1;");

            //MySqlConnection conn = new MySqlConnection(connString);
            //MySqlCommand command = conn.CreateCommand();
            //command.CommandText = ("SELECT * FROM exportcsv ;");
            ////conn.Open();
            ////command.ExecuteNonQuery();


            //try
            //{

            //    conn.Open();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}

            //MySqlDataReader reader = command.ExecuteReader();


            //while (reader.Read())
            //{
            //    MessageBox.Show(reader["text"].ToString());

            //}

        }

        private void btnGetImgnm_Click(object sender, EventArgs e)
        {
            //var glo = new GlobalV();
            //var getImgVName = DTI;
           

            string imgN = "";
            int currentIndex = GlobalV.getCurrentIndex();
           
            imgN = GlobalV.getFilesArrayIndex(currentIndex);
            txtbImgnm.Text = imgN;

           // txtbImgnm.Text = getImgVName.testVal;


        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            
        }
    }
}
