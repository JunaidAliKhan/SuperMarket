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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(@"Market\1234.png");
            panel1.BackgroundImage = b;
            panel2.BackgroundImage = b;

            this.Icon.ToBitmap();
        }
    }
}
