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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            Bitmap bit = new Bitmap(@"Market\no.png");
            pictureBox3.Image = bit;

            Bitmap bim = new Bitmap(@"Market\download.jpg");
            pictureBox34.Image = bim;

            Bitmap be = new Bitmap(@"Market\ba.jpg");
            panel1.BackgroundImage = be;
            panel2.BackgroundImage = be;

            Bitmap bin = new Bitmap(@"Market\oolaaalaa.jpg");
            groupBox1.BackgroundImage = bin;


            Bitmap a = new Bitmap(@"Market\Fast food\0.jpg");
            button4.BackgroundImage = a;
            Bitmap b = new Bitmap(@"Market\Fast food\1.png");
            button5.BackgroundImage = b;
            Bitmap c = new Bitmap(@"Market\Fast food\4.png");
            button6.BackgroundImage = c;
            Bitmap d = new Bitmap(@"Market\Fast food\5.jpeg");
            button7.BackgroundImage = d;
            Bitmap f = new Bitmap(@"Market\Fast food\7.jpg");
            button8.BackgroundImage = f;
            Bitmap g = new Bitmap(@"Market\Fast food\8.png");
            button9.BackgroundImage = g;
            Bitmap h = new Bitmap(@"Market\Fast food\9.jpeg");
            button10.BackgroundImage = h;
            Bitmap i = new Bitmap(@"Market\Fast food\10.jpg");
            button11.BackgroundImage = i;
            Bitmap j = new Bitmap(@"Market\Fast food\11.png");
            button12.BackgroundImage = j;
            Bitmap k = new Bitmap(@"Market\Fast food\13.jpg");
            button13.BackgroundImage = k;
            Bitmap l = new Bitmap(@"Market\Fast food\15.jpeg");
            button14.BackgroundImage = l;
            Bitmap m = new Bitmap(@"Market\Fast food\18.png");
            button15.BackgroundImage = m;
            Bitmap n = new Bitmap(@"Market\Fast food\20.jpg");
            button16.BackgroundImage = n;
            Bitmap o = new Bitmap(@"Market\Fast food\22.jpeg");
            button17.BackgroundImage = o;
            Bitmap p = new Bitmap(@"Market\Fast food\23.jpg");
            button18.BackgroundImage = p;
            Bitmap q = new Bitmap(@"Market\Fast food\25.jpeg");
            button19.BackgroundImage = q;
            Bitmap r = new Bitmap(@"Market\Fast food\27.jpg");
            //Bitmap a = new Bitmap(@"Market\Fast food\0.jpg");
            button20.BackgroundImage = r;
            Bitmap s = new Bitmap(@"Market\Fast food\28.png");
            button21.BackgroundImage = s;
            Bitmap t = new Bitmap(@"Market\Fast food\31.jpg");
            button22.BackgroundImage = t;
            Bitmap u = new Bitmap(@"Market\Fast food\33.jpg");
            button23.BackgroundImage = u;
            Bitmap v = new Bitmap(@"Market\Fast food\34.jpeg");
            button24.BackgroundImage = v;
            Bitmap w = new Bitmap(@"Market\Fast food\35.jpg");
            button25.BackgroundImage = w;
            Bitmap x = new Bitmap(@"Market\Fast food\36.jpeg");
            button26.BackgroundImage = x;
            Bitmap y = new Bitmap(@"Market\Fast food\37.jpg");
            button27.BackgroundImage = y;
            Bitmap z = new Bitmap(@"Market\Fast food\38.jpeg");
            button28.BackgroundImage = z;
            Bitmap aa = new Bitmap(@"Market\Fast food\39.jpg");
            button29.BackgroundImage = aa;
            Bitmap ab = new Bitmap(@"Market\Fast food\59.jpg");
            button30.BackgroundImage = ab;
            Bitmap ac = new Bitmap(@"Market\Fast food\41.jpg");
            button31.BackgroundImage = ac;
            Bitmap ad = new Bitmap(@"Market\Fast food\43.jpg");
            button32.BackgroundImage = ad;
            Bitmap ae = new Bitmap(@"Market\Fast food\44.jpeg");
            button33.BackgroundImage = ae;
            Bitmap af = new Bitmap(@"Market\Fast food\45.jpg");
            button34.BackgroundImage = af;
            Bitmap ag = new Bitmap(@"Market\Fast food\47.jpeg");
            button35.BackgroundImage = ag;
            Bitmap ah = new Bitmap(@"Market\Fast food\48.jpg");
            button36.BackgroundImage = ah;
            Bitmap ai = new Bitmap(@"Market\Fast food\50.jpg");
            //Bitmap a = new Bitmap(@"Market\Fast food\0.jpg");
            button37.BackgroundImage = ai;
            Bitmap aj = new Bitmap(@"Market\Fast food\52.jpg");
            button38.BackgroundImage = aj;
            Bitmap ak = new Bitmap(@"Market\Fast food\54.jpeg");
            button39.BackgroundImage = ak;
            Bitmap al = new Bitmap(@"Market\Fast food\55.jpg");
            button40.BackgroundImage = al;
            Bitmap am = new Bitmap(@"Market\Fast food\56.jpeg");
            button41.BackgroundImage = am;
            Bitmap an = new Bitmap(@"Market\Fast food\57.jpg");
            button42.BackgroundImage = an;
            Bitmap ao = new Bitmap(@"Market\Fast food\58.jpeg");
            button43.BackgroundImage = ao;
            
          
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

        private void button34_Click(object sender, EventArgs e)
        {

        }
    }
}
