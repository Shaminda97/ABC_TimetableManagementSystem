using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TimeTable_Management_System_ABC_Institute
{
    public partial class Consecetive_sessions : Form
    {
        public Consecetive_sessions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consecetive_sessions consecetive_Sessions = new Consecetive_sessions();
            consecetive_Sessions.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Parallel_sessions parallel_Sessions = new Parallel_sessions();
            parallel_Sessions.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Non_Available_Times non_Available_Times = new Non_Available_Times();
            non_Available_Times.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NonOverlapping nonOverlapping = new NonOverlapping();
            nonOverlapping.Show();
        }
    }
}
