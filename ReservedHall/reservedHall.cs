using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ABC_TimetableManagementSystem.ReservedHall
{
    public partial class reservedHall : Form
    {
        
        public reservedHall()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reservedHallArrangementTableBindingSource.AddNew();
            MessageBox.Show("Data inserted successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservedHallArrangementTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_databaseDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void reservedHall_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_databaseDataSet.ReservedHallArrangementTable' table. You can move, or remove it, as needed.
            this.reservedHallArrangementTableTableAdapter.Fill(this.aBC_databaseDataSet.ReservedHallArrangementTable);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.reservedHallArrangementTableBindingSource.RemoveCurrent();
            MessageBox.Show("Data deleted successfully");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
