﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInal_project
{
    public partial class Monthly_service_report : Form
    {
        public Monthly_service_report()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CEO_Dashbord ceo = new CEO_Dashbord();
        }
    }
}
