using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_TimetableManagementSystem
{
    public partial class manage_session : Form
    {
        public manage_session()
        {
            InitializeComponent();
        }

        private void manageSessionTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manageSessionTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_databaseDataSet1);

        }

        private void manage_session_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_databaseDataSet1.ManageSessionTable' table. You can move, or remove it, as needed.
            this.manageSessionTableTableAdapter.Fill(this.aBC_databaseDataSet1.ManageSessionTable);

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.manageSessionTableTableAdapter.SearchName(this.aBC_databaseDataSet1.ManageSessionTable, button1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.manageSessionTableBindingSource.AddNew();
            MessageBox.Show("Data inserted successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.manageSessionTableBindingSource.RemoveCurrent();
            MessageBox.Show("Data deleted successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manageSessionTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_databaseDataSet1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
