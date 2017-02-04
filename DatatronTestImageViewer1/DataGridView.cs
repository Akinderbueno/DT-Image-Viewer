using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DatatronTestImageViewer1
{
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private void btnLoadTable_Click(object sender, EventArgs e)
        {

            string connString = ("SERVER=109.73.168.215;PORT=3306;database=robihari_datatron;UID=robihari_robi;PASSWORD=rUc!uZkqre$1;");


            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = ("SELECT * FROM exportcsv ;");


            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = command;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();



                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);



            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }


        public void OpenConnection()
        {
            string connString = ("SERVER=109.73.168.215;PORT=3306;database=robihari_datatron;UID=robihari_robi;PASSWORD=rUc!uZkqre$1;");


            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();

        }

        private void DataGridView_Load(object sender, EventArgs e)
        {

        }
    }
}
