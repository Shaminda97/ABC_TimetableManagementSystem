using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ABC_TimetableManagementSystem.AddSession
{
    public partial class addSession : Form
    {
        
        public addSession()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.addaSessionTableBindingSource.AddNew();
            MessageBox.Show("Data inserted successfully");
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addaSessionTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_databaseDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.addaSessionTableBindingSource.RemoveCurrent();
            MessageBox.Show("Data deleted successfully");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addSession_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_databaseDataSet.AddaSessionTable' table. You can move, or remove it, as needed.
            this.addaSessionTableTableAdapter.Fill(this.aBC_databaseDataSet.AddaSessionTable);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
