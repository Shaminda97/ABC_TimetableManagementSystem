﻿using ABC_TimetableManagementSystem.LocationManagement;
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
            this.Hide();
            locationManagement locationMang = new locationManagement();
            locationMang.ShowDialog();
        }
    }
}
