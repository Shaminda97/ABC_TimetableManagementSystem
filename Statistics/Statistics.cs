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

           //pieChart for years vs subjects
            chart1.Titles.Add("Subjects");
           /* connection.Open();
            SqlCommand cmdS1 = new SqlCommand("SELECT COUNT (*) FROM [StudentTable] WHERE Acadamic Year & Sem= 'Y1S1' OR  Acadamic year & Sem= 'Y1S2' ", connection);
            int firstYrStd = (int)cmdS1.ExecuteScalar();

            SqlCommand cmdS2 = new SqlCommand("SELECT COUNT (*) FROM [StudentTable] WHERE Acadamic year & Sem= 'Y2S1' OR  Acadamic year & Sem= 'Y2S2'", connection);
            int secondYrStd = (int)cmdS2.ExecuteScalar();

            SqlCommand cmdS3 = new SqlCommand("SELECT COUNT (*) FROM [StudentTable] WHEREAcadamic year & Sem= 'Y3S1' OR  Acadamic year & Sem= 'Y3S2'", connection);
            int thirdYrStd = (int)cmdS3.ExecuteScalar();

            SqlCommand cmdS4 = new SqlCommand("SELECT COUNT (*) FROM [StudentTable] WHERE Acadamic year & Sem= 'Y4S1' OR  Acadamic year & Sem= 'Y4S2'", connection);
            int forthYrStd = (int)cmdS4.ExecuteScalar();

            chart1.Series["s2"].Points.AddXY("1st", firstYrStd);
            chart1.Series["s2"].Points.AddXY("2nd", secondYrStd);
            chart1.Series["s2"].Points.AddXY("3rd", thirdYrStd);
            chart1.Series["s2"].Points.AddXY("4th", forthYrStd);
            connection.Close();*/
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        

        
    }
}
