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
    public partial class Form3 : Form
    {
        Myconn conn = new Myconn();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = System.DateTime.Now.ToString();
            textBox2.PasswordChar = '*';

            Bitmap bit = new Bitmap(@"Market\wall.png");
            panel1.BackgroundImage = bit;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            AcceptButton = button2;


            this.label5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if ( textBox1.Text == "junaid" && textBox2.Text == "karachi" )
            {
                Form5 f9 = new Form5();
                f9.Show();
                this.Hide();
            }

            else if ( textBox1.Text == "admin" && textBox2.Text == "1234" )
            {
                Form8 f8 = new Form8();
                f8.Show();
                this.Hide();
            }

            else
            {
                label5.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
