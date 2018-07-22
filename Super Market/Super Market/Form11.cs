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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            Bitmap bit = new Bitmap(@"Market\no.png");
            pictureBox3.Image = bit;

            Bitmap bim = new Bitmap(@"Market\download.jpg");
            pictureBox34.Image = bim;

            Bitmap be = new Bitmap(@"Market\ba.jpg");
            panel1.BackgroundImage = be;
            panel2.BackgroundImage = be;

            Bitmap bin = new Bitmap(@"Market\asd.jpg");
            groupBox1.BackgroundImage = bin;

            Bitmap a = new Bitmap(@"Market\Food\0.jpg");
            button4.BackgroundImage = a;
            Bitmap b = new Bitmap(@"Market\Food\1.jpg");
            button5.BackgroundImage = b;
            Bitmap c = new Bitmap(@"Market\Food\2.png");
            button6.BackgroundImage = c;
            Bitmap d = new Bitmap(@"Market\Food\3.jpg");
            button7.BackgroundImage = d;
            Bitmap f = new Bitmap(@"Market\Food\4.jpg");
            button8.BackgroundImage = f;
            Bitmap g = new Bitmap(@"Market\Food\5.jpg");
            button9.BackgroundImage = g;
            Bitmap h = new Bitmap(@"Market\Food\6.jpeg");
            button10.BackgroundImage = h;
            Bitmap i = new Bitmap(@"Market\Food\7.jpg");
            button11.BackgroundImage = i;
            Bitmap j = new Bitmap(@"Market\Food\8.jpg");
            button12.BackgroundImage = j;
            Bitmap k = new Bitmap(@"Market\Food\9.jpg");
            button13.BackgroundImage = k;
            Bitmap l = new Bitmap(@"Market\Food\10.jpg");
            button14.BackgroundImage = l;
            Bitmap m = new Bitmap(@"Market\Food\11.jpg");
            button15.BackgroundImage = m;
            Bitmap n = new Bitmap(@"Market\Food\12.jpg");
            button16.BackgroundImage = n;
            Bitmap o = new Bitmap(@"Market\Food\13.jpg");
            button17.BackgroundImage = o;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
