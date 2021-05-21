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

namespace ABC_TimetableManagementSystem.GenarateTimetable
{
    
    public partial class genarateTimetable : Form
    {
       
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\ITPM\ABC_TimetableManagementSystem\ABC_database.mdf;Integrated Security=True");
        //Sql
        public genarateTimetable()
        {
            InitializeComponent();
        }

        //backbtn
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }



        private void genarateTimetable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_databaseDataSet.SuitableTable' table. You can move, or remove it, as needed.
            this.suitableTableTableAdapter.Fill(this.aBC_databaseDataSet.SuitableTable);
            // TODO: This line of code loads data into the 'aBC_databaseDataSet.RoomsTable' table. You can move, or remove it, as needed.
            this.roomsTableTableAdapter.Fill(this.aBC_databaseDataSet.RoomsTable);

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                this.suitableTableTableAdapter.SearchRoom(this.aBC_databaseDataSet.SuitableTable, textBoxSearchRoom.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    }
}
