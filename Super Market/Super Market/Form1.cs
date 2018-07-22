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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 13)
            {
                imageNumber = 1;
            }

            pictureBox1.ImageLocation = string.Format(@"Market\{0}.jpg", imageNumber);
            imageNumber++;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Bitmap bit = new Bitmap(@"Market\red.png");
            //button1.BackgroundImage = bit;

            Bitmap bim = new Bitmap(@"Market\01.jpg");
            pictureBox1.Image = bim;

            Bitmap bin = new Bitmap(@"Market\images.png");
            pictureBox2.Image = bin;

            Bitmap baa = new Bitmap(@"Market\two.png");
            pictureBox3.Image = baa;

            Bitmap bia = new Bitmap(@"Market\gmail.jpg");
            pictureBox4.Image = bia;

            Bitmap bi = new Bitmap(@"Market\download.jpg");
            pictureBox5.Image = bi;

            Bitmap b = new Bitmap(@"Market\1234.png");
            panel2.BackgroundImage = b;

            Bitmap bw = new Bitmap(@"Market\1234.png");
            panel1.BackgroundImage = bw;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Transparent;
        }
    }
}
