using System;
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
    public partial class nonCoffee : UserControl
    {
        public nonCoffee()
        {
            InitializeComponent();
        }

        //Hot Vanilla//
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
            TextBox hvnTb = parent.Controls["txtSelected"] as TextBox;

            if (checkBox1.Checked)
            {
                hvnTb.Text = "Hot Vanilla SGL ₱145.00";
            }
            else if (checkBox2.Checked)
            {
                hvnTb.Text = "Hot Vanilla DBL ₱160.00";
            }
            else
            {
                hvnTb.Text = "Hot Vanilla SGL ₱145.00";
            }

            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        //Hot Choco//
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
            TextBox hchTb = parent.Controls["txtSelected"] as TextBox;

            if (checkBox3.Checked)
            {
                hchTb.Text = "Hot Choco SGL ₱145.00";
            }
            else if (checkBox4.Checked)
            {
                hchTb.Text = "Hot Choco DBL ₱160.00";
            }
            else
            {
                hchTb.Text = "Hot Choco SGL ₱145.00";
            }

            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }
    }
}
