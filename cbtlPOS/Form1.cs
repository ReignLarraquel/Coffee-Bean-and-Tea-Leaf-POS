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
    }
}
