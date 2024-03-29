﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace service_center.functional
{
    public partial class forTest : Form
    {
        public forTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyMessageBox.Show(Validation.OnlyLetters(textBox1.Text).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            MyMessageBox.Show(Validation.PhoneNumberValidate(textBox2.Text).ToString());
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyMessageBox.Show(Validation.PassportID(textBox3.Text).ToString());
        }
    }
}
