using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_TimetableManagementSystem.GenarateTimetable
{
    public partial class genarateTimetable : Form
    {
        public genarateTimetable()
        {
            InitializeComponent();
        }

        private void roomsTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomsTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_databaseDataSet);

        }

        private void genarateTimetable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_databaseDataSet.RoomsTable' table. You can move, or remove it, as needed.
            this.roomsTableTableAdapter.Fill(this.aBC_databaseDataSet.RoomsTable);

        }

        

        private void searchRoombutton_Click(object sender, EventArgs e)
        {
            try
            {
                this.roomsTableTableAdapter.SearchRoomNo(this.aBC_databaseDataSet.RoomsTable, searchRoomtextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
