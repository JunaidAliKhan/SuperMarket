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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //panel1.Visible = false;
            //panel2.Visible = false;

            Bitmap bit = new Bitmap(@"Market\no.png");
            pictureBox3.Image = bit;

            Bitmap bim = new Bitmap(@"Market\download.jpg");
            pictureBox34.Image = bim;

            Bitmap be = new Bitmap(@"Market\ba.jpg");
            panel1.BackgroundImage = be;
            panel2.BackgroundImage = be;

            Bitmap bin = new Bitmap(@"Market\12345.jpg");
            groupBox1.BackgroundImage = bin;

            Bitmap a = new Bitmap(@"Market\Vegetables\0.jpg");
            button4.BackgroundImage = a;
            Bitmap b = new Bitmap(@"Market\Vegetables\1.png");
            button5.BackgroundImage = b;
            Bitmap c = new Bitmap(@"Market\Vegetables\2.jpg");
            Bitmap d = new Bitmap(@"Market\Vegetables\3.jpg");
            button6.BackgroundImage = c;
            button7.BackgroundImage = d;
            Bitmap f = new Bitmap(@"Market\Vegetables\4.jpeg");
            button8.BackgroundImage = f;
            Bitmap g = new Bitmap(@"Market\Vegetables\5.jpg");
            button9.BackgroundImage = g;
            Bitmap h = new Bitmap(@"Market\Vegetables\6.jpg");
            button10.BackgroundImage = h;
            Bitmap i = new Bitmap(@"Market\Vegetables\7.jpg");
            button11.BackgroundImage = i;
            Bitmap j = new Bitmap(@"Market\Vegetables\8.jpg");
            button12.BackgroundImage = j;
            Bitmap k = new Bitmap(@"Market\Vegetables\9.jpg");
            button13.BackgroundImage = k;
            Bitmap l = new Bitmap(@"Market\Vegetables\10.jpg");
            button14.BackgroundImage = l;
            Bitmap m = new Bitmap(@"Market\Vegetables\11.jpg");
            button15.BackgroundImage = m;
            Bitmap n = new Bitmap(@"Market\Vegetables\12.jpg");
            button16.BackgroundImage = n;
            Bitmap o = new Bitmap(@"Market\Vegetables\13.jpg");
            button17.BackgroundImage = o;
            Bitmap p = new Bitmap(@"Market\Vegetables\14.jpg");
            button18.BackgroundImage = p;
            Bitmap q = new Bitmap(@"Market\Vegetables\15.jpg");
            button19.BackgroundImage = q;
            Bitmap r = new Bitmap(@"Market\Vegetables\16.jpg");
            button20.BackgroundImage = r;
            Bitmap s = new Bitmap(@"Market\Vegetables\17.jpg");
            button21.BackgroundImage = s;
            Bitmap t = new Bitmap(@"Market\Vegetables\18.png");
            button22.BackgroundImage = t;
            Bitmap u = new Bitmap(@"Market\Vegetables\19.jpg");
            button23.BackgroundImage = u;
            Bitmap v = new Bitmap(@"Market\Vegetables\20.jpg");
            button24.BackgroundImage = v;
            Bitmap w = new Bitmap(@"Market\Vegetables\21.png");
            button25.BackgroundImage = w;
            Bitmap x = new Bitmap(@"Market\Vegetables\22.jpg");
            button26.BackgroundImage = x;
            Bitmap y = new Bitmap(@"Market\Vegetables\23.jpg");
            button27.BackgroundImage = y;
            Bitmap z = new Bitmap(@"Market\Vegetables\24.jpg");
            button28.BackgroundImage = z;
            Bitmap aa = new Bitmap(@"Market\Vegetables\25.jpg");
            button29.BackgroundImage = aa;
            Bitmap ab = new Bitmap(@"Market\Vegetables\26.png");
            button30.BackgroundImage = ab;
            Bitmap ac = new Bitmap(@"Market\Vegetables\27.png");
            button31.BackgroundImage = ac;
            Bitmap ad = new Bitmap(@"Market\Vegetables\28.jpg");
            button32.BackgroundImage = ad;
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
