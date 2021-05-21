using ABC_TimetableManagementSystem.LocationManagement;
using ABC_TimetableManagementSystem.Statistics;
using ABC_TimetableManagementSystem.GenarateTimetable;
using ABC_TimetableManagementSystem.AddSession;
using ABC_TimetableManagementSystem.NotAvailableTime;
using ABC_TimetableManagementSystem.ReservedHall;


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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLocation_Click(object sender, EventArgs e)
        {
            //navigate to the location management
            this.Hide();
            locationManagement locationMang = new locationManagement();
            locationMang.ShowDialog();
        }

        private void buttonStat_Click(object sender, EventArgs e)
        {
            this.Hide();
            statistics stat = new statistics();
            stat.ShowDialog();
        }

        private void buttonTimetable_Click(object sender, EventArgs e)
        {
            this.Hide();
            genarateTimetable genTimetbl = new genarateTimetable();
            genTimetbl.ShowDialog();
        }

        private void buttonWorkingDays_Click(object sender, EventArgs e)
        {
            this.Hide();
            workingDays stat = new workingDays();
            stat.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            reservedHall stat = new reservedHall();
            stat.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            notAvailableTime stat = new notAvailableTime();
            stat.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            addSession stat = new addSession();
            stat.ShowDialog();
        }
    }
}
