﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation
{
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin123")
            {
                Admin next = new Admin();
                next.Show();
            }
            else
            {
                MessageBox.Show("istifadəçi adı vəya şifrə yanlışdır");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservation back= new Reservation();
            back.Show();
        }
    }
}
