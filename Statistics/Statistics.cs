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

namespace ABC_TimetableManagementSystem.Statistics
{
    public partial class statistics : Form
    {
        int totalSubjects;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\ITPM\ABC_TimetableManagementSystem\ABC_database.mdf;Integrated Security=True;Connect Timeout=30");
        public statistics()
        {
            InitializeComponent();

            //pieChart for years vs subjects
            chart1.Titles.Add("Subjects");
            connection.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT (*) FROM [SubjectTable] WHERE Offerd_year= 1", connection);
            int firstYr = (int)cmd1.ExecuteScalar();

            SqlCommand cmd2 = new SqlCommand("SELECT COUNT (*) FROM [SubjectTable] WHERE Offerd_year= 2", connection);
            int secondYr = (int)cmd2.ExecuteScalar();

            SqlCommand cmd3 = new SqlCommand("SELECT COUNT (*) FROM [SubjectTable] WHERE Offerd_year= 3", connection);
            int thirdYr = (int)cmd3.ExecuteScalar();

            SqlCommand cmd4 = new SqlCommand("SELECT COUNT (*) FROM [SubjectTable] WHERE Offerd_year= 4", connection);
            int forthYr = (int)cmd4.ExecuteScalar();

            chart1.Series["s1"].Points.AddXY("1st", firstYr);
            chart1.Series["s1"].Points.AddXY("2nd", secondYr);
            chart1.Series["s1"].Points.AddXY("3rd", thirdYr);
            chart1.Series["s1"].Points.AddXY("4th", forthYr);
            connection.Close();

            //pieChart for years vs student
            chartStudent.Titles.Add("Students");
            connection.Open();
            SqlCommand cmdS1 = new SqlCommand("SELECT COUNT (*) FROM [StudentTable] WHERE AcadamicYear = 1 ", connection);//AcadamicYearAndSem LIKE 'Y1%' "
            int firstYrStd = (int)cmdS1.ExecuteScalar();

            SqlCommand cmdS2 = new SqlCommand("SELECT COUNT (*) FROM [StudentTable] WHERE AcadamicYear =2", connection);
            int secondYrStd = (int)cmdS2.ExecuteScalar();

            SqlCommand cmdS3 = new SqlCommand("SELECT COUNT (*) FROM [StudentTable] WHERE AcadamicYear = 3", connection);
            int thirdYrStd = (int)cmdS3.ExecuteScalar();

            SqlCommand cmdS4 = new SqlCommand("SELECT COUNT (*) FROM [StudentTable] WHERE AcadamicYear = 4", connection);
            int forthYrStd = (int)cmdS4.ExecuteScalar();

            chartStudent.Series["s2"].Points.AddXY("1st", firstYrStd);
            chartStudent.Series["s2"].Points.AddXY("2nd", secondYrStd);
            chartStudent.Series["s2"].Points.AddXY("3rd", thirdYrStd);
            chartStudent.Series["s2"].Points.AddXY("4th", forthYrStd);
            connection.Close();


            //pieChart for lecturers vs ranking
            chartLect.Titles.Add("Lecturers");
            connection.Open();
            SqlCommand cmdc1 = new SqlCommand("SELECT COUNT (*) FROM [LecturesDetails] WHERE Level= 1", connection);
            int lvl1 = (int)cmdc1.ExecuteScalar();

            SqlCommand cmdc2 = new SqlCommand("SELECT COUNT (*) FROM [LecturesDetails] WHERE Level= 2", connection);
            int lvl2 = (int)cmdc2.ExecuteScalar();

            SqlCommand cmdc3 = new SqlCommand("SELECT COUNT (*) FROM [LecturesDetails] WHERE Level= 3", connection);
            int lvl3 = (int)cmdc3.ExecuteScalar();

            SqlCommand cmcd4 = new SqlCommand("SELECT COUNT (*) FROM [LecturesDetails] WHERE Level= 4", connection);
            int lvl4 = (int)cmcd4.ExecuteScalar();

            SqlCommand cmcd5 = new SqlCommand("SELECT COUNT (*) FROM [LecturesDetails] WHERE Level= 5", connection);
            int lvl5 = (int)cmcd5.ExecuteScalar();

            SqlCommand cmcd6 = new SqlCommand("SELECT COUNT (*) FROM[LecturesDetails] WHERE Level= 6", connection);
            int lvl6 = (int)cmcd6.ExecuteScalar();

            chartLect.Series["s1"].Points.AddXY("Prof", lvl1);
            chartLect.Series["s1"].Points.AddXY("As.Prof", lvl2);
            chartLect.Series["s1"].Points.AddXY("Se.Lec(HG)", lvl3);
            chartLect.Series["s1"].Points.AddXY("Se.Lec", lvl4);
            chartLect.Series["s1"].Points.AddXY("Lec", lvl5);
            chartLect.Series["s1"].Points.AddXY("As.Lec", lvl6);
            connection.Close();

            //Total Lecturer
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM [LecturesDetails] ", connection);
            textBoxTotLec.Text = cmd.ExecuteScalar().ToString();
            connection.Close();

            //Total Subject
            connection.Open();
            SqlCommand cmdTotSubj = new SqlCommand("SELECT COUNT (*) FROM [SubjectTable] ", connection);
            textBoxTotSubj.Text = cmdTotSubj.ExecuteScalar().ToString();
            connection.Close();

            //Total Student
            connection.Open();
            SqlCommand cmdTotStu = new SqlCommand("SELECT COUNT (*) FROM [StudentTable] ", connection);
            textBoxTotStudent.Text = cmdTotStu.ExecuteScalar().ToString();
            connection.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        

        
    }
}
