﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2
{
    public partial class uroven : Form
    {
        public uroven()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 uus_aken = new Form1();
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 uus_aken = new Form2();
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.Show();
        }
    }
}
