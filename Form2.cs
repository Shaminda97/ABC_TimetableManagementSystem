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

namespace ABC_TimetableManagementSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="E:\YEAR_3_SEMESTER_1\ITPM\time table\ABC_database.mdf";Integrated Security=True;Connect Timeout=30");
        

        private void studentTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_databaseDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_databaseDataSet.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.aBC_databaseDataSet.StudentTable);
            // TODO: This line of code loads data into the 'aBC_databaseDataSet.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.aBC_databaseDataSet.StudentTable);

        }

        private void studentTableListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentTableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_databaseDataSet);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void button1_Click(object sender,EventArgs e)
        {
         
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into StudentTable ('" + IDTb.Text + "','" + acadamic_Year_TextBox.Text + "','" + semesterNumericUpDown.Value + "','" + programTextBox.Text + "','" + group_NoTextBox.Text + "','" + sub_Group_NoTextBox.Text + ")", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Group Successfully Added");
            }
             
            {

            }
        }

        private void programmeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
