using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_TimetableManagementSystem.LocationManagement
{
    public partial class addSuitableRoom : Form
    {
        public addSuitableRoom()
        {
            InitializeComponent();
        }

        private void suitableTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suitableTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_databaseDataSet);

        }

        private void addSuitableRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBC_databaseDataSet.SuitableTable' table. You can move, or remove it, as needed.
            this.suitableTableTableAdapter.Fill(this.aBC_databaseDataSet.SuitableTable);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.suitableTableBindingSource.AddNew();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suitableTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aBC_databaseDataSet);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.suitableTableBindingSource.RemoveCurrent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.suitableTableTableAdapter.SearchSubject(this.aBC_databaseDataSet.SuitableTable, textBoxSearch.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
