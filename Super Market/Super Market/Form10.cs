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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            Bitmap bit = new Bitmap(@"Market\no.png");
            pictureBox3.Image = bit;

            Bitmap bim = new Bitmap(@"Market\download.jpg");
            pictureBox34.Image = bim;

            Bitmap be = new Bitmap(@"Market\ba.jpg");
            panel1.BackgroundImage = be;
            panel2.BackgroundImage = be;

            Bitmap bin = new Bitmap(@"Market\windows__8_v_4_by_bruellkaefer-d3dib4k.jpg");
            groupBox1.BackgroundImage = bin;

            Bitmap a = new Bitmap(@"Market\Cosmetic\0.jpg");
            button4.BackgroundImage = a;
            Bitmap b = new Bitmap(@"Market\Cosmetic\1.jpg");
            button5.BackgroundImage = b;
            Bitmap c = new Bitmap(@"Market\Cosmetic\2.jpg");
            button6.BackgroundImage = c;
            Bitmap d = new Bitmap(@"Market\Cosmetic\3.jpeg");
            button7.BackgroundImage = d;
            Bitmap f = new Bitmap(@"Market\Cosmetic\4.jpeg");
            button8.BackgroundImage = f;
            Bitmap g = new Bitmap(@"Market\Cosmetic\5.jpg");
            button9.BackgroundImage = g;
            Bitmap h = new Bitmap(@"Market\Cosmetic\6.jpeg");
            button10.BackgroundImage = h;
            Bitmap i = new Bitmap(@"Market\Cosmetic\7.jpg");
            button11.BackgroundImage = i;
            Bitmap j = new Bitmap(@"Market\Cosmetic\8.jpg");
            button12.BackgroundImage = j;
            Bitmap k = new Bitmap(@"Market\Cosmetic\9.jpg");
            button13.BackgroundImage = k;
            Bitmap l = new Bitmap(@"Market\Cosmetic\10.jpg");
            Bitmap m = new Bitmap(@"Market\Cosmetic\11.jpeg");
            Bitmap n = new Bitmap(@"Market\Cosmetic\12.jpg");
            Bitmap o = new Bitmap(@"Market\Cosmetic\13.jpeg");
            button14.BackgroundImage = l;
            button15.BackgroundImage = m;
            button16.BackgroundImage = n;
            button17.BackgroundImage = o;
            Bitmap p = new Bitmap(@"Market\Cosmetic\14.jpeg");
            button18.BackgroundImage = p;
            Bitmap q = new Bitmap(@"Market\Cosmetic\15.jpeg");
            button19.BackgroundImage = q;
            Bitmap r = new Bitmap(@"Market\Cosmetic\16.jpeg");
            button20.BackgroundImage = r;
            Bitmap s = new Bitmap(@"Market\Cosmetic\17.jpeg");
            button21.BackgroundImage = s;
            Bitmap t = new Bitmap(@"Market\Cosmetic\18.jpeg");
            button22.BackgroundImage = t;
            Bitmap u = new Bitmap(@"Market\Cosmetic\19.jpeg");
            button23.BackgroundImage = u;
            Bitmap v = new Bitmap(@"Market\Cosmetic\20.jpg");
            button24.BackgroundImage = v;
            Bitmap w = new Bitmap(@"Market\Cosmetic\21.jpg");
            button25.BackgroundImage = w;
            Bitmap x = new Bitmap(@"Market\Cosmetic\22.jpg");
            button26.BackgroundImage = x;
            Bitmap y = new Bitmap(@"Market\Cosmetic\23.jpg");
            button27.BackgroundImage = y;
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
