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

namespace DatatronTestImageViewer1
{
    public partial class FloatingDialogue : Form
    {

        //Fields

        





        public FloatingDialogue()
        {
            InitializeComponent();
        }

        private void FloatingDialogue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recordDBDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.recordDBDataSet.Table);



        }

        //Next and Save button 
        private void btnNextSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\University\Source\Repos\DT-Image-Viewer\DatatronTestImageViewer1\recordDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand sc = new SqlCommand("Insert into values('"+payroll_IDTextBox.Text+"','"+surnameTextBox.Text+"','"+forenameTextBox.Text+"','"+titleTextBox+"','"+groupTextBox+"');",con);

            int o = sc.ExecuteNonQuery();
            MessageBox.Show(o + "  :Record has been inserted");
            con.Close();

        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
           

        }

        private void tableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.recordDBDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("l");
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }
    }
}
