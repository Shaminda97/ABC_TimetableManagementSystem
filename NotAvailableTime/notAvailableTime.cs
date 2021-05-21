using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ABC_TimetableManagementSystem.NotAvailableTime
{
    public partial class notAvailableTime : Form
    {
        
        public notAvailableTime()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.notAvailableTimesBindingSource.AddNew();
            MessageBox.Show("Data inserted successfully");
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.notAvailableTimesBindingSource.RemoveCurrent();
            MessageBox.Show("Data deleted successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notAvailableTimesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_databaseDataSet);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void notAvailableTime_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_databaseDataSet.AddaSessionTable' table. You can move, or remove it, as needed.
            this.addaSessionTableTableAdapter.Fill(this.aBC_databaseDataSet.AddaSessionTable);
            // TODO: This line of code loads data into the 'aBC_databaseDataSet.NotAvailableTimes' table. You can move, or remove it, as needed.
            this.notAvailableTimesTableAdapter.Fill(this.aBC_databaseDataSet.NotAvailableTimes);

        }
    }
}
