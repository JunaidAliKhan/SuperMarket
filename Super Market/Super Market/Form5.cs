using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Super_Market
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; 

            Bitmap bit = new Bitmap(@"Market\back.jpg");
            panel1.BackgroundImage = bit;
            panel2.BackgroundImage = bit;

            Bitmap bin = new Bitmap(@"Market\images.png");
            pictureBox1.Image = bin;

            Bitmap baa = new Bitmap(@"Market\two.png");
            pictureBox2.Image = baa;

            Bitmap ba = new Bitmap(@"Market\no.png");
            pictureBox3.Image = ba;

            Bitmap bia = new Bitmap(@"Market\gmail.jpg");
            pictureBox4.Image = bia;

            Bitmap b = new Bitmap(@"Market\center.jpg");
            panel3.BackgroundImage = b;

            Bitmap bi = new Bitmap(@"Market\download.jpg");
            pictureBox5.Image = bi;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            this.Hide();
        }
    }
}
