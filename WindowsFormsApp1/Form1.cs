﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userTop1.BringToFront();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void panel3_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void button3_Click(object sender, EventArgs e)
            {
            userDrink1.BringToFront();
            }

            private void button2_Click(object sender, EventArgs e)
            {
            userFood1.BringToFront();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            userTop1.BringToFront();
        }

        private void userTop1_Load(object sender, EventArgs e)
        {

        }
    }
}
