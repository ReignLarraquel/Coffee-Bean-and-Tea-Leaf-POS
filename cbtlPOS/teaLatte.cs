﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cbtlPOS
{
    public partial class teaLatte : UserControl
    {
        public teaLatte()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //Matcha Green Tea//
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form parent = this.Parent as Form;
            TextBox mgtTb = parent.Controls["txtSelected"] as TextBox;

            if (checkBox1.Checked)
            {
                mgtTb.Text = "Matcha Green Tea SGL ₱170.00";
            }
            else if (checkBox2.Checked)
            {
                mgtTb.Text = "Matcha Green Tea DBL ₱185.00";
            }
            else
            {
                mgtTb.Text = "Matcha Green Tea SGL ₱170.00";
            }

            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        //Morroccan Mint//
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form parent = this.Parent as Form;
            TextBox morTb = parent.Controls["txtSelected"] as TextBox;

            if (checkBox3.Checked)
            {
                morTb.Text = "Morroccan Mint SGL ₱165.00";
            }
            else if (checkBox4.Checked)
            {
                morTb.Text = "Morroccan Mint DBL ₱180.00";
            }
            else
            {
                morTb.Text = "Morroccan Mint SGL ₱165.00";
            }

            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }


    }
}
