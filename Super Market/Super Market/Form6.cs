using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Super_Market
{
    public partial class Form6 : Form
    {
        Myconn conn = new Myconn();
        Form14 f14 = new Form14();
        int a;
        int b;
        int c;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            Bitmap bit = new Bitmap(@"Market\no.png");
            pictureBox3.Image = bit;

            Bitmap bim = new Bitmap(@"Market\download.jpg");
            pictureBox34.Image = bim;

            Bitmap be = new Bitmap(@"Market\ba.jpg");
            panel1.BackgroundImage = be;
            panel2.BackgroundImage = be;

            Bitmap bn = new Bitmap(@"Market\695610f6ead5198.jpg");
            groupBox1.BackgroundImage = bn;
            //groupBox2.BackgroundImage = bn;

            Bitmap bin = new Bitmap(@"Market\dry.jpg");
            groupBox2.BackgroundImage = bin;

            Bitmap a = new Bitmap(@"Market\Fruit\33.jpg");
            button4.BackgroundImage = a;
            Bitmap b = new Bitmap(@"Market\Fruit\34.jpg");
            button5.BackgroundImage = b;
            Bitmap c = new Bitmap(@"Market\Fruit\17.jpg");
            button6.BackgroundImage = c;
            Bitmap d = new Bitmap(@"Market\Fruit\18.jpg");
            button7.BackgroundImage = d;
            Bitmap f = new Bitmap(@"Market\Fruit\1.jpg");
            button8.BackgroundImage = f;
            Bitmap g = new Bitmap(@"Market\Fruit\2.png");
            button9.BackgroundImage = g;
            Bitmap h = new Bitmap(@"Market\Fruit\3.jpg");
            button10.BackgroundImage = h;
            Bitmap i = new Bitmap(@"Market\Fruit\4.jpg");
            button11.BackgroundImage = i;
            Bitmap j = new Bitmap(@"Market\Fruit\5.png");
            button12.BackgroundImage = j;
            Bitmap k = new Bitmap(@"Market\Fruit\6.jpg");
            button13.BackgroundImage = k;
            Bitmap l = new Bitmap(@"Market\Fruit\7.jpg");
            button14.BackgroundImage = l;
            Bitmap m = new Bitmap(@"Market\Fruit\8.jpg");
            button15.BackgroundImage = m;
            Bitmap n = new Bitmap(@"Market\Fruit\9.jpg");
            button16.BackgroundImage = n;
            Bitmap o = new Bitmap(@"Market\Fruit\10.jpg");
            button17.BackgroundImage = o;
            Bitmap p = new Bitmap(@"Market\Fruit\11.jpg");
            button18.BackgroundImage = p;
            Bitmap q = new Bitmap(@"MArket\Fruit\12.jpg");
            button19.BackgroundImage = q;
            Bitmap r = new Bitmap(@"MArket\Fruit\35.jpeg");
            button20.BackgroundImage = r;
            Bitmap s = new Bitmap(@"MArket\Fruit\14.jpg");
            button21.BackgroundImage = s;
            Bitmap t = new Bitmap(@"MArket\Fruit\15.jpg");
            button22.BackgroundImage = t;
            Bitmap v = new Bitmap(@"MArket\Fruit\16.jpg");
            button23.BackgroundImage = v;
            Bitmap u = new Bitmap(@"MArket\Fruit\0.jpeg");
            Bitmap w = new Bitmap(@"MArket\Fruit\19.jpg");
            button24.BackgroundImage = u;
            button25.BackgroundImage = w;
            Bitmap x = new Bitmap(@"MArket\Fruit\20.jpg");
            button26.BackgroundImage = x;
            Bitmap y = new Bitmap(@"MArket\Fruit\21.jpg");
            button27.BackgroundImage = y;
            Bitmap z = new Bitmap(@"MArket\Fruit\24.jpg");
            button28.BackgroundImage = z;
            Bitmap aa = new Bitmap(@"MArket\Fruit\25.jpg");
            button29.BackgroundImage = aa;
            Bitmap ab = new Bitmap(@"MArket\Fruit\26.jpg");
            button30.BackgroundImage = ab;
            Bitmap ac = new Bitmap(@"MArket\Fruit\27.jpg");
            button31.BackgroundImage = ac;
            Bitmap ad = new Bitmap(@"MArket\Fruit\28.jpg");
            button32.BackgroundImage = ad;
            Bitmap ae = new Bitmap(@"MArket\Fruit\30.jpg");
            button33.BackgroundImage = ae;
            Bitmap af = new Bitmap(@"MArket\Fruit\31.jpg");
            button34.BackgroundImage = af;
            Bitmap ag = new Bitmap(@"MArket\Fruit\32.jpg");
            button35.BackgroundImage = ag;


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

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (checkBox1.Checked)
                {          
                     a = Convert.ToInt32(label3.Text);
                     b = Convert.ToInt32(textBox1.Text);
                     c = a * b;
                   
                    f14.label27.Text = this.label1.Text;
                    f14.label39.Text = this.label3.Text;
                    f14.label43.Text = this.textBox1.Text;
                    f14.label31.Text = "-";
                    f14.label35.Text = "-";
                    f14.label47.Text = c.ToString();
                    f14.label48.Text = f14.label47.Text;
                    f14.label50.Text = "0";
                    //f14.label28.Text = "";
                    f14.label29.Text = "";
                    f14.label30.Text = "";
                    f14.label32.Text = ""; 
                    f14.label33.Text = "";
                    f14.label34.Text = "";
                    f14.label36.Text = "";
                    f14.label37.Text = "";
                    f14.label38.Text = "";
                   // f14.label39.Text = "";
                    f14.label40.Text = "";
                    f14.label41.Text = "";
                    f14.label42.Text = "";
                    f14.label44.Text = "";
                    f14.label45.Text = "";
                    f14.label46.Text = "";
                    //f14.label47.Text = "";

                    
                    f14.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                if (checkBox2.Checked)
                {
                     a = Convert.ToInt32(label4.Text);
                     b = Convert.ToInt32(textBox2.Text);
                     int d = a * b;
                    // int f = c * d;
                   // Form14 f14 = new Form14();
                    f14.label28.Text = this.label5.Text;
                    f14.label40.Text = this.label4.Text;
                    f14.label44.Text = this.textBox2.Text;
                    f14.label31.Text = "-";
                    f14.label35.Text = "-";
                    f14.label47.Text =d.ToString();
                    f14.label48.Text = f14.label47.Text;
                    f14.label50.Text = "0";
                   // f14.label28.Text = "";
                    f14.label29.Text = "";
                    f14.label30.Text = "";
                    f14.label32.Text = "-"; 
                    f14.label33.Text = "";
                    f14.label34.Text = "";
                    f14.label36.Text = "-";
                    f14.label37.Text = "";
                    f14.label38.Text = "";
                   // f14.label39.Text = "";
                   // f14.label40.Text = "";
                    f14.label41.Text = "";
                    f14.label42.Text = "";
                   // f14.label44.Text = "";
                    f14.label45.Text = "";
                    f14.label46.Text = "";
                    //f14.label47.Text = "";

                    
                    f14.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
