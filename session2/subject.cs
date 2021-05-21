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
    public partial class subject : Form
    {
        public subject()
        {
            InitializeComponent();
        }

        private void subjectTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjectTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_databaseDataSet);

        }

        private void subject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_databaseDataSet1.SubjectTable' table. You can move, or remove it, as needed.
            this.subjectTableTableAdapter1.Fill(this.aBC_databaseDataSet1.SubjectTable);
            // TODO: This line of code loads data into the 'aBC_databaseDataSet.SubjectTable' table. You can move, or remove it, as needed.
            this.subjectTableTableAdapter.Fill(this.aBC_databaseDataSet.SubjectTable);

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.subjectTableTableAdapter1.SearchName(this.aBC_databaseDataSet1.SubjectTable, button1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.subjectTableBindingSource.AddNew();
            MessageBox.Show("Data inserted successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjectTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_databaseDataSet);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.subjectTableBindingSource.RemoveCurrent();
            MessageBox.Show("Data deleted successfully");
        }
    }
}
