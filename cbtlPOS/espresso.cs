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
    public partial class espresso : UserControl
    {
        public espresso()
        {
            InitializeComponent();
            
        }

        

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //espresso//

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
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false; 
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
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
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form parent = this.Parent as Form;
            TextBox espTb = parent.Controls["txtSelected"] as TextBox;


            
            if (checkBox1.Checked)
            {
                espTb.Text = "Espresso SGL ₱115.00";
            }
            else if (checkBox2.Checked) 
            {
                espTb.Text = "Espresso DBL ₱130.00";
            }
            else
            {
                espTb.Text = "Espresso SGL ₱115.00";
            }

            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        //Machiato//

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
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
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
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form parent = this.Parent as Form;
            TextBox macTb = parent.Controls["txtSelected"] as TextBox;


            
            if (checkBox3.Checked)
            {
                macTb.Text = "Machiato SGL ₱125.00";
            }
            else if (checkBox4.Checked)
            {
                macTb.Text = "Machiato DBL ₱140.00";
            }
            else
            {
                macTb.Text = "Machiato SGL ₱125.00";
            }

            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        //Cappuccino//

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
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
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
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form parent = this.Parent as Form;
            TextBox cupTb = parent.Controls["txtSelected"] as TextBox;

            if (checkBox5.Checked)
            {
                cupTb.Text = "Cappuccino SGL ₱135.00";
            }
            else if (checkBox6.Checked)
            {
                cupTb.Text = "Cappuccino DBL ₱150.00";
            }
            else
            {
                cupTb.Text = "Cappuccino SGL ₱135.00";
            }

            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }

        //Americano//

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
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
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
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form parent = this.Parent as Form;
            TextBox ameTb = parent.Controls["txtSelected"] as TextBox;

            if (checkBox7.Checked)
            {
                ameTb.Text = "Americano SGL ₱135.00";
            }
            else if (checkBox8.Checked)
            {
                ameTb.Text = "Americano DBL ₱150.00";
            }
            else
            {
                ameTb.Text = "Americano SGL ₱135.00";
            }

            checkBox7.Checked = false;
            checkBox8.Checked = false;
        }

        //Vanilla Latte//

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
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
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
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form parent = this.Parent as Form;
            TextBox vanTb = parent.Controls["txtSelected"] as TextBox;

            if (checkBox9.Checked)
            {
                vanTb.Text = "Vanilla Latte SGL ₱165.00";
            }
            else if (checkBox10.Checked)
            {
                vanTb.Text = "Vanilla Latte DBL ₱180.00";
            }
            else
            {
                vanTb.Text = "Vanilla Latte SGL ₱165.00";
            }

            checkBox9.Checked = false;
            checkBox10.Checked = false;
        }

        //Double Choco//

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
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
                checkBox10.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
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
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form parent = this.Parent as Form;
            TextBox vanTb = parent.Controls["txtSelected"] as TextBox;

            if (checkBox11.Checked)
            {
                vanTb.Text = "Vanilla Latte SGL ₱165.00";
            }
            else if (checkBox12.Checked)
            {
                vanTb.Text = "Vanilla Latte DBL ₱180.00";
            }
            {
                vanTb.Text = "Vanilla Latte SGL ₱165.00";
            }

            checkBox11.Checked = false;
            checkBox12.Checked = false;
        }

        //Caramel Machiato//

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
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
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
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
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form parent = this.Parent as Form;
            TextBox carTb = parent.Controls["txtSelected"] as TextBox;

            if (checkBox13.Checked)
            {
                carTb.Text = "Caramel Machiato SGL ₱170.00";
            }
            else if (checkBox14.Checked)
            {
                carTb.Text = "Caramel Machiato DBL ₱185,00";
            }
            else
            {
                carTb.Text = "Caramel Machiato SGL ₱170.00";
            }

            checkBox13.Checked = false;
            checkBox14.Checked = false;
        }

        //White Chocolate//

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
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
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
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
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form parent = this.Parent as Form;
            TextBox whiTb = parent.Controls["txtSelected"] as TextBox;

            if (checkBox15.Checked)
            {
                whiTb.Text = "White Choco SGL ₱170.00";
            }
            else if (checkBox16.Checked)
            {
                whiTb.Text = "White Choco DBL ₱185.00";
            }
            else
            {
                whiTb.Text = "White Choco SGL ₱170.00";
            }

            checkBox15.Checked = false;
            checkBox16.Checked = false;
        }

        //Hazelnut Chocolate//

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
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
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox18.Checked = false;
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
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
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form parent = this.Parent as Form;
            TextBox hazTb = parent.Controls["txtSelected"] as TextBox;

            if (checkBox17.Checked)
            {
                hazTb.Text = "Hazelnut Chocolate SGL ₱170.00";
            }
            else if (checkBox18.Checked)
            {
                hazTb.Text = "Hazelnut Chocolate DBL ₱185.00";
            }
            else
            {
                hazTb.Text = "Hazelnut Chocolate SGL ₱170.00";
            }

            checkBox17.Checked = false;
            checkBox18.Checked = false;
        }

        private void espresso_Load(object sender, EventArgs e)
        {

        }
    }
}
