using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TimeTable_Management_System_ABC_Institute
{
    public partial class Generate_Time_Tables_Lecturer : Form
    {
        public Generate_Time_Tables_Lecturer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generate_Time_Tables_Lecturer generate_Time_Tables_Lecturer = new Generate_Time_Tables_Lecturer();
            generate_Time_Tables_Lecturer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Generate_Time_Tables generate_Time_Tables = new Generate_Time_Tables();
            generate_Time_Tables.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
