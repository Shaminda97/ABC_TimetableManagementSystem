using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TimeTable_Management_System_ABC_Institute
{
    public partial class Manage_Tags : Form
    {
        public Manage_Tags()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AMA\source\repos\TimeTable_Management_System_ABC_Institute\ABC_database.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Manage_Tags_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [TagManageTable] (Tag Name,Tag Code,Relative Tag) values ('" +textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            display_data();
            MessageBox.Show("User Successfully Added");
        }

        //To disply data is tag management table
        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [TagManageTable]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataAdap = new SqlDataAdapter(cmd);
            dataAdap.Fill(dta);
            dataGridView2.DataSource = dta;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update [TagManageTable] set name = '" + textBox1.Text + "' where name = '" + textBox2.Text + "';
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            display_data();
            MessageBox.Show("Data updated Successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from [TagManageTable] where name = '" + textBox1.Text + "';
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            display_data();
            MessageBox.Show("Data deleted Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from [TagManageTable] where name = '" + textBox1.Text + "',"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
