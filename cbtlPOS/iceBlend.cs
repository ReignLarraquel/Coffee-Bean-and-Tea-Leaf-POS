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
    public partial class iceBlend : UserControl
    {
        public iceBlend()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iceBlend_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        //The Original Mocha//

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form parent = this.Parent as Form;
            TextBox tocTb = parent.Controls["txtSelected"] as TextBox;

            if (checkBox1.Checked)
            {
                tocTb.Text = "The Original Mocha SGL ₱165.00";
            }
            else if (checkBox2.Checked)
            {
                tocTb.Text = "The Original Mocha DBL ₱185.00";
            }
            else
            {
                tocTb.Text = "The Original Mocha SGL ₱165.00";
            }

            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        //The Original Vanilla//

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form parent = this.Parent as Form;
            TextBox tovTb = parent.Controls["txtSelected"] as TextBox;

            if (checkBox3.Checked)
            {
                tovTb.Text = "The Original Vanilla SGL ₱165.00";
            }
            else if (checkBox4.Checked)
            {
                tovTb.Text = "The Original Vanilla DBL ₱185.00";
            }
            else
            {
                tovTb.Text = "The Original Vanilla SGL ₱165.00";
            }
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        //Caramel//

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
            }
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form parent = this.Parent as Form;
            TextBox tocTb = parent.Controls["txtSelected"] as TextBox;

            if (checkBox5.Checked)
            {
                tocTb.Text = "Caramel SGL ₱180.00";
            }
            else if (checkBox6.Checked)
            {
                tocTb.Text = "Caramel DBL ₱200.00";
            }
            else
            {
                tocTb.Text = "Caramel SGL ₱180.00";
            }

            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }

        //Black Forest//

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form parent = this.Parent as Form;
            TextBox blkTb = parent.Controls["txtSelected"] as TextBox;

            if (checkBox7.Checked)
            {
                blkTb.Text = "Black Forest SGL ₱180.00";
            }
            else if (checkBox8.Checked)
            {
                blkTb.Text = "Black Forest DBL ₱200.00";
            }
            else
            {
                blkTb.Text = "Black Forest SGL ₱180.00";
            }

            checkBox7.Checked = false;
            checkBox8.Checked = false;
        }

        //Hazelnut Chocolate//

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox10.Checked = false;
            }
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form parent = this.Parent as Form;
            TextBox hzlTb = parent.Controls["txtSelected"] as TextBox;

            if (checkBox9.Checked)
            {
                hzlTb.Text = "Hazelnut Chocolate SGL ₱180.00";
            }
            else if (checkBox10.Checked)
            {
                hzlTb.Text = "Hazelnut Chocolate DBL ₱200.00";
            }
            else
            {
                hzlTb.Text = "Hazelnut Chocolate SGL ₱180.00";
            }

            checkBox9.Checked = false;
            checkBox10.Checked = false;
        }

    }
}
