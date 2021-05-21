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
    public partial class lecture : Form
    {
        public lecture()
        {
            InitializeComponent();
        }

        private void lecturesDrtailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lecturesDrtailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_databaseDataSet);

        }

        private void lecture_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_databaseDataSet1.LecturesDetails' table. You can move, or remove it, as needed.
            this.lecturesDetailsTableAdapter.Fill(this.aBC_databaseDataSet1.LecturesDetails);
            // TODO: This line of code loads data into the 'aBC_databaseDataSet.LecturesDrtails' table. You can move, or remove it, as needed.
            this.lecturesDrtailsTableAdapter.Fill(this.aBC_databaseDataSet.LecturesDrtails);

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.lecturesDetailsTableAdapter.SearchName(this.aBC_databaseDataSet1.LecturesDetails, button1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.lecturesDrtailsBindingSource.AddNew();
            MessageBox.Show("Data inserted successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.lecturesDrtailsBindingSource.RemoveCurrent();
            MessageBox.Show("Data deleted successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lecturesDrtailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_databaseDataSet);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
