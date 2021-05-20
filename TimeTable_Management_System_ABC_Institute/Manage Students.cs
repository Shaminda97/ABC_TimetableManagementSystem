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


namespace TimeTable_Management_System_ABC_Institute
{
    public partial class ManageStudents : Form
    {
        public ManageStudents() => InitializeComponent();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AMA\source\repos\TimeTable_Management_System_ABC_Institute\ABC_database.mdf;Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [StudentTable] (AcadamicYear,Semester,Programme,GroupNumber,SubGroupNumber,GroupID,SubGroupID) values ('" + acedemicyearTb.Text + "','" + semesterTb.Text + "','" + programTb.Text + "','" + groupnoTb.Text + "','" + subgroupnoTb.Text + "','" + groupidTb.Text + "','" + subgroupidTb.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            acedemicyearTb.Text = "";
            semesterTb.Text = "";
            programTb.Text = "";
            groupnoTb.Text = "";
            subgroupnoTb.Text = "";
            groupidTb.Text = "";
            subgroupidTb.Text = "";
            display_data();
            MessageBox.Show("StudGroup Successfully Added");
        }

        //To disply data is student management table
        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [StudentTable]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataAdap = new SqlDataAdapter(cmd);
            dataAdap.Fill(dta);
            dataGridView1.DataSource = dta;
            con.Close();
        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update [StudentTable] set name = '" + groupidTb.Text + "' where name = '"+groupidTb.Text+"';
            cmd.ExecuteNonQuery();
            con.Close();
            acedemicyearTb.Text = "";
            semesterTb.Text = "";
            programTb.Text = "";
            groupnoTb.Text = "";
            subgroupnoTb.Text = "";
            groupidTb.Text = "";
            subgroupidTb.Text = "";
            display_data();
            MessageBox.Show("Data updated Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from [StudentTable] where name = '" + groupidTb.Text+ "';
            cmd.ExecuteNonQuery();
            con.Close();
            acedemicyearTb.Text = "";
            semesterTb.Text = "";
            programTb.Text = "";
            groupnoTb.Text = "";
            subgroupnoTb.Text = "";
            groupidTb.Text = "";
            subgroupidTb.Text = "";
            display_data();
            MessageBox.Show("Data deleted Successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from [StudentTable] where name = '" + groupidTb.Text+ "',"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            acedemicyearTb.Text = "";
            semesterTb.Text = "";
            programTb.Text = "";
            groupnoTb.Text = "";
            subgroupnoTb.Text = "";
            groupidTb.Text = "";
            subgroupidTb.Text = "";
        }

        

        private void acedemicyearTb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
