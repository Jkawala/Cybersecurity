﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Width += 4;

                if (pictureBox1.Width >= 600)
                {

                    timer1.Stop();
                    Form2 f2 = new Form2();

                    f2.Show();

                    this.Hide();

                }

            }
            catch (Exception)
            {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
