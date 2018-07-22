using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Super_Market
{
    public partial class Form8 : Form
    {
        Myconn conn = new Myconn();

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            Bitmap bim = new Bitmap(@"Market\black-abstract-wallpaper-1920x1080-wallpaper-3.jpg");
            panel1.BackgroundImage = bim;
            panel2.BackgroundImage = bim;

            Bitmap ba = new Bitmap(@"Market\no.png");
            pictureBox2.Image = ba;

            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;

            label1.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label21.Text = "";

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = row.Cells["ID"].Value.ToString();
                    textBox2.Text = row.Cells["CName"].Value.ToString();
                    textBox3.Text = row.Cells["CSex"].Value.ToString();
                    textBox4.Text = row.Cells["CDOB"].Value.ToString();
                    textBox5.Text = row.Cells["CCountry"].Value.ToString();
                    textBox6.Text = row.Cells["CPH"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button3_Enter(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void button4_Enter(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void button5_Enter(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void button5_Leave(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void button6_Enter(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void button6_Leave(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }

        private void button7_Enter(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }

        private void button7_Leave(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void button8_Enter(object sender, EventArgs e)
        {
            panel9.Visible = true;
        }

        private void button8_Leave(object sender, EventArgs e)
        {
            panel9.Visible = false;
        }

        private void button10_Enter(object sender, EventArgs e)
        {
            panel10.Visible = true;
        }

        private void button10_Leave(object sender, EventArgs e)
        {
            panel10.Visible = false;
        }

        private void label22_Click(object sender, EventArgs e)
        {
            try
            {
                conn.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("select * from customers", conn.sqlConnection1);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

                label1.Text = "ID";
                label3.Text = "Name";
                label4.Text = "Sex";
                label5.Text = "Date Of Birth";
                label6.Text = "Country";
                label21.Text = "Phone No";
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;

                conn.sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            try
            {
                conn.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("select * from fruits", conn.sqlConnection1);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

                label1.Text = "ID";
                label3.Text = "Fruit Name";
                label4.Text = "Price";
                label5.Text = "";
                label6.Text = "";
                label21.Text = "";
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;

                conn.sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
          
        }

        private void label9_Click(object sender, EventArgs e)
        {
            try
            {
                conn.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("select * from vegetables", conn.sqlConnection1);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

                label1.Text = "ID";
                label3.Text = "Vegetable NAme";
                label4.Text = "Price";
                label5.Text = "";
                label6.Text = "";
                label21.Text = "";
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;

                conn.sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            try
            {
                conn.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("select * from food", conn.sqlConnection1);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

                label1.Text = "ID";
                label3.Text = "Food Name";
                label4.Text = "Price";
                label5.Text = "";
                label6.Text = "";
                label21.Text = "";
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;

                conn.sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {
            try
            {
                conn.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("select * from fastfood", conn.sqlConnection1);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

                label1.Text = "ID";
                label3.Text = "Fast Food Name";
                label4.Text = "Price";
                label5.Text = "Company Name";
                label6.Text = "Company Price";
                label21.Text = "";
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = false;

                conn.sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
     
        }

        private void label12_Click(object sender, EventArgs e)
        {
            try
            {
                conn.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("select * from cloths", conn.sqlConnection1);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

                label1.Text = "ID";
                label3.Text = "Man Dress";
                label4.Text = "Price";
                label5.Text = "Women Dress";
                label6.Text = "Price";
                label21.Text = "";
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = false;

                conn.sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            try
            {
                conn.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("select * from cosmetics", conn.sqlConnection1);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

                label1.Text = "ID";
                label3.Text = "Item Name";
                label4.Text = "Price";
                label5.Text = "";
                label6.Text = "";
                label21.Text = "";
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;

                conn.sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            try
            {
                conn.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("select * from dryfruits", conn.sqlConnection1);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

                label1.Text = "ID";
                label2.Text = "Dry Fruit Name";
                label4.Text = "Price";
                label5.Text = "";
                label6.Text = "";
                label21.Text = "";
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;

                conn.sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }

}

        