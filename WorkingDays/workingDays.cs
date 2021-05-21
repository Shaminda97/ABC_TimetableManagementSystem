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
    public partial class workingDays : Form
    {
        
        public workingDays()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.workingDaysandHoursTableBindingSource.AddNew();
            MessageBox.Show("Data inserted successfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workingDaysandHoursTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_databaseDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.workingDaysandHoursTableBindingSource.RemoveCurrent();
            MessageBox.Show("Data deleted successfully");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void workingDaysandHoursTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workingDaysandHoursTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_databaseDataSet);

        }

        private void workingDaysandHoursTableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.workingDaysandHoursTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_databaseDataSet);

        }

        private void workingDays_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_databaseDataSet.WorkingDaysandHoursTable' table. You can move, or remove it, as needed.
            this.workingDaysandHoursTableTableAdapter.Fill(this.aBC_databaseDataSet.WorkingDaysandHoursTable);

        }
    }
}
