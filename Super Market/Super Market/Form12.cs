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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            Bitmap bit = new Bitmap(@"Market\no.png");
            pictureBox3.Image = bit;

            Bitmap bim = new Bitmap(@"Market\download.jpg");
            pictureBox34.Image = bim;

            Bitmap be = new Bitmap(@"Market\ba.jpg");
            panel1.BackgroundImage = be;
            panel2.BackgroundImage = be;

            Bitmap ma = new Bitmap(@"Market\manback.jpg");
            groupBox1.BackgroundImage = ma;
            Bitmap me = new Bitmap(@"Market\womenback.jpg");
            groupBox2.BackgroundImage = me;

            Bitmap a = new Bitmap(@"Market\Clothes\0.jpg");
            button4.BackgroundImage = a;
            Bitmap b = new Bitmap(@"Market\Clothes\1.jpg");
            button5.BackgroundImage = b;
            Bitmap c = new Bitmap(@"Market\Clothes\2.jpg");
            button6.BackgroundImage = c;
            Bitmap d = new Bitmap(@"Market\Clothes\3.jpg");
            button7.BackgroundImage = d;
            Bitmap f = new Bitmap(@"Market\Clothes\4.jpg");
            button8.BackgroundImage = f;
            Bitmap g = new Bitmap(@"Market\Clothes\5.jpg");
            button9.BackgroundImage = g;
            Bitmap h = new Bitmap(@"Market\Clothes\7.jpg");
            button10.BackgroundImage = h;
            Bitmap i = new Bitmap(@"Market\Clothes\8.jpg");
            button11.BackgroundImage = i;
            Bitmap j = new Bitmap(@"Market\Clothes\9.jpg");
            button12.BackgroundImage = j;
            Bitmap k = new Bitmap(@"Market\Clothes\10.jpg");
            button13.BackgroundImage = k;
            Bitmap l = new Bitmap(@"Market\Clothes\11.jpg");
            button14.BackgroundImage = l;
            Bitmap m = new Bitmap(@"Market\Clothes\13.jpg");
            button15.BackgroundImage = m;
            Bitmap n = new Bitmap(@"Market\Clothes\14.jpeg");
            button16.BackgroundImage = n;
            Bitmap o = new Bitmap(@"Market\Clothes\15.jpeg");
            button17.BackgroundImage = o;
            Bitmap p = new Bitmap(@"Market\Clothes\16.jpeg");
            button18.BackgroundImage = p;
            Bitmap q = new Bitmap(@"Market\Clothes\17.jpeg");
            button19.BackgroundImage = q;
            Bitmap r = new Bitmap(@"Market\Clothes\18.jpeg");
            button20.BackgroundImage = r;
            Bitmap s = new Bitmap(@"Market\Clothes\19.jpeg");
            button21.BackgroundImage = s;
            Bitmap t = new Bitmap(@"Market\Clothes\20.jpg");
            button22.BackgroundImage = t;
            Bitmap u = new Bitmap(@"Market\Clothes\21.jpg");
            button23.BackgroundImage = u;
            Bitmap v = new Bitmap(@"Market\Clothes\22.jpg");
            button24.BackgroundImage = v;
            Bitmap w = new Bitmap(@"Market\Clothes\23.jpg");
            Bitmap x = new Bitmap(@"Market\Clothes\24.jpg");
            button25.BackgroundImage = w;
            button26.BackgroundImage = x;
            //Bitmap y = new Bitmap(@"Market\Clothes\0.jpg");
            //button27.BackgroundImage = y;
            Bitmap z = new Bitmap(@"Market\Clothes\12.jpg");
            Bitmap aa = new Bitmap(@"Market\Clothes\25.jpg");
            Bitmap ab = new Bitmap(@"Market\Clothes\28.jpg");
            Bitmap ac = new Bitmap(@"Market\Clothes\29.jpg");
            Bitmap ad = new Bitmap(@"Market\Clothes\31.jpg");
            Bitmap ae = new Bitmap(@"Market\Clothes\32.jpg");
            Bitmap af = new Bitmap(@"Market\Clothes\33.jpg");
            Bitmap ag = new Bitmap(@"Market\Clothes\34.jpg");
            Bitmap ah = new Bitmap(@"Market\Clothes\35.jpeg");
            Bitmap ai = new Bitmap(@"Market\Clothes\36.jpg");
            button29.BackgroundImage = z;
            button30.BackgroundImage = aa;
            button31.BackgroundImage = ab;
            button32.BackgroundImage = ac;
            button33.BackgroundImage = ad;
            button35.BackgroundImage = ae;
            button36.BackgroundImage = af;
            button37.BackgroundImage = ag;
            button38.BackgroundImage = ah;
            button39.BackgroundImage = ai;
            Bitmap aj = new Bitmap(@"Market\Clothes\37.jpeg");
            button41.BackgroundImage = aj;
            Bitmap ak = new Bitmap(@"Market\Clothes\38.jpeg");
            button42.BackgroundImage = ak;
            Bitmap al = new Bitmap(@"Market\Clothes\39.jpeg");
            button43.BackgroundImage = al;
            Bitmap am = new Bitmap(@"Market\Clothes\40.jpeg");
            button44.BackgroundImage = am;
            Bitmap an = new Bitmap(@"Market\Clothes\41.jpeg");
            button45.BackgroundImage = an;
            Bitmap ao = new Bitmap(@"Market\Clothes\42.jpg");
            button47.BackgroundImage = ao;
            Bitmap ap = new Bitmap(@"Market\Clothes\43.jpg");
            button48.BackgroundImage = ap;
            Bitmap aq = new Bitmap(@"Market\Clothes\44.jpg");
            button49.BackgroundImage = aq;
            Bitmap ar = new Bitmap(@"Market\Clothes\45.jpg");
            button50.BackgroundImage = ar;
            Bitmap at = new Bitmap(@"Market\Clothes\47.jpg");
            button51.BackgroundImage = at;
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
        }
    }
}
