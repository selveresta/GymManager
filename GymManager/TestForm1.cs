﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManager
{
    public partial class TestForm1 : Form
    {
        private mainForm formMain;

        public TestForm1(mainForm fm)
        {
            InitializeComponent();

            formMain = fm;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}