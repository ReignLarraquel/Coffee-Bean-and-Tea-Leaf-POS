using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cbtlPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bottomBar.Left = 0;
            espresso1.Visible = true;
            nonCoffee1.Visible = false;
            teaLatte1.Visible = false;
            iceBlend1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
            string orderDrink = txtSelected.Text;
            int peso = orderDrink.IndexOf('₱');
            int drink = orderDrink.Length;
            double price = double.Parse(orderDrink.Substring(peso + 1, drink - (peso + 1)));
            int amount = int.Parse(label4.Text);
            double total = amount * price;
            string list = "(" + label4.Text + ") " + txtSelected.Text + "= ₱" + total.ToString() + ".00";
            listBox1.Items.Add(list);

            label4.Text = "0";
            txtSelected.Text = string.Empty;

            if (listBox1.Items.Count > 0)
            {
                button12.Enabled = true;
            }

        }

        private void iceBlend1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iceBlend1_Load_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            bottomBar.Left = 113;
            espresso1.Visible = false;
            nonCoffee1.Visible = false;
            teaLatte1.Visible = false;
            iceBlend1.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bottomBar.Left = 345;
            espresso1.Visible = false;
            nonCoffee1.Visible = true;
            teaLatte1.Visible = false;
            iceBlend1.Visible = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
         
            bottomBar.Left = 0;
            espresso1.Visible = true;
            nonCoffee1.Visible = false;
            teaLatte1.Visible = false;
            iceBlend1.Visible = false;
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            bottomBar.Left = 230;
            espresso1.Visible = false;
            nonCoffee1.Visible = false;
            teaLatte1.Visible = true;
            iceBlend1.Visible = false;

        }

        private void nonCoffee1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            

            int addAmt = int.Parse(label4.Text);
            addAmt++;
            label4.Text = addAmt.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int subAmt = int.Parse(label4.Text);
            if(subAmt > 1)subAmt--;
            label4.Text = subAmt.ToString();
        }

        private void txtSelected_TextChanged(object sender, EventArgs e)
        {
            if (txtSelected.Text != string.Empty)
            {
                label4.Text = "1";
                button6.Enabled = true;
                button7.Enabled = true;

                button4.Enabled = true;
                button8.Enabled = true;


            }
            else
            {
                label4.Text = "0";
                button6.Enabled = false;
                button7.Enabled = false;

                button4.Enabled = false;
                button8.Enabled = false;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            txtSelected.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "PAYMENT:";
            label5.Text = textBox1.Text; 
            textBox1.Text = string.Empty;
            textBox1.Enabled = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {

                double pay = double.Parse(textBox1.Text);
                string text = label5.Text;
                int peso = text.IndexOf('₱');
                int price = text.Length;
                double bill = double.Parse(text.Substring(peso + 1, price - (peso + 1)));

                if (pay >= bill)
                {
                    label1.Text = "CHANGE:";
                    double change = pay - bill;
                    textBox1.Text = "₱" + change.ToString() + ".00";
                    button3.Enabled = true;

                }

                else
                {
                    MessageBox.Show("Not enough money.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = string.Empty;

                }
            }

            else MessageBox.Show("Please pay for the item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "ORDER:";
            listBox1.Items.Clear();
            textBox1.Text = string.Empty;
            label5.Text = string.Empty;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button12.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);

            if (listBox1.Items.Count <= 0)
            {
                button12.Enabled = false;
            }


        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            int counter = listBox1.Items.Count;
            double total = 0;

            if (counter > 0)
            {
                for(int x = 0; counter > x; x++)
                {
                    string item = listBox1.Items[x].ToString();
                    int indexSign = item.LastIndexOf('₱');
                    int text = item.Length;
                    string price = item.Substring(indexSign + 1, text - (indexSign + 1));
                    double dblPrice = double.Parse(price);
                    total += dblPrice;
                    textBox1.Text = "₱" + total.ToString() + ".00";
                }
            
            }
            button1.Enabled = true;
            

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void updateorder(object sender, EventArgs e)
        {
            
        }
    }
}
