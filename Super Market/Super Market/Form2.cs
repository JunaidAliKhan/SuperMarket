using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Super_Market
{
    public partial class Form2 : Form
    {
        Myconn conn = new Myconn();
        int count = 0;
        Bitmap bim = new Bitmap(@"Market\a.jpg");
        Bitmap b = new Bitmap(@"Market\b.jpg");
        Bitmap bit = new Bitmap(@"Market\mm.png");

        int counter = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;

            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;

            textBox4.PasswordChar = '*';
            textBox5.PasswordChar = '*';

            comboBox3.Text = "--------------------Select One----------------------";
            string[] a = { "Male", "Female" };
            comboBox1.Items.AddRange(a);

            string[] b = { "What was your childhood nickname?","What is the name of your favorite childhood friend?",
                             "In what city or town did your mother and father meet?","What is the middle name of your oldest child?",
                             "What is your favorite team?","What is your favorite movie?",
                             "What was your favorite sport in high school?","What was your favorite food as a child?",
                         "What is the first name of the boy or girl that you first kissed?","What was the make and model of your first car?",
                         "What was the name of the hospital where you were born?","Who is your childhood sports hero?",
                         "What school did you attend for sixth grade?","What was the last name of your third grade teacher?",
                         "In what town was your first job?","What was the name of the company where you had your first job?" };

            comboBox3.Items.AddRange(b);

            string[] c = { "Afghanistan",
                            "Albania",
                            "Algeria",
                            "Andorra",
                            "Angola",
                            "Antigua and Barbuda",
                            "Argentina",
                            "Armenia",
                            "Aruba",
                            "Australia",
                            "Austria",
                            "Azerbaijan",
                            "Bahamas"," The Bahrain",
                            "Bangladesh",
                            "Barbados",
                            "Belarus",
                            "Belgium",
                            "Belize",
                            "Benin",
                            "Bolivia",
                            "Bosnia", "Herzegovina",
                            "Botswana",
                            "Brazil",
                            "Brunei",
                            "Bulgaria",
                            "Burkina Faso",
                            "Burma",
                            "Burundi",
                            "Cambodia",
                            "Cameroon",
                            "Canada",
                            "Cabo Verde",
                            "Central African Republic Chad",
                            "Chile",
                            "China",
                            "Colombia",
                            "Comoros",
                            "Congo, Democratic Republic of the",
                            "Congo, Republic of the Costa Rica",
                            "Cote d Ivoire",
                            "Croatia",
                            "Cuba",
                            "Curacao",
                            "Cyprus",
                            "Czechia",
                            "Denmark",
                            "Djibouti",
                            "Dominica",
                            "Dominican Republic",
                            "East Timor (see Timor-Leste)",
                            "Ecuador",
                            "Egypt",
                            "El Salvador",
                            "Equatorial Guinea",
                            "Eritrea",
                            "Estonia",
                            "Ethiopia",
                            "Fiji",
                            "Finland",
                            "France",
                            "Gabon",
                            "Gambia",
                            "Georgia",
                            "Germany",
                            "Ghana",
                            "Greece",
                            "Grenada",
                            "Guatemala",
                            "Guinea",
                            "Guinea-Bissau",
                            "Guyana",
                            "Haiti",
                            "Holy See",
                            "Honduras",
                            "Hong Kong",
                            "Hungary",
                            "Iceland",
                            "India",
                            "Indonesia",
                            "Iran",
                            "Iraq",
                            "Ireland",
                            "Israel",
                            "Italy",
                            "Jamaica",
                            "Japan",
                            "Jordan",
                            "Kazakhstan",
                            "Kenya",
                            "Kiribati",
                            "Korea, North",
                            "Korea, South",
                            "Kosovo",
                            "Kuwait",
                            "Kyrgyzstan",
                            "Laos",
                            "Latvia",
                            "Lebanon",
                            "Lesotho",
                            "Liberia",
                            "Libya",
                            "Liechtenstein",
                            "Lithuania",
                            "Luxembourg",
                            "Macau",
                            "Macedonia",
                            "Madagascar",
                            "Malawi",
                            "Malaysia",
                            "Maldives",
                            "Mali",
                            "Malta",
                            "Marshall Islands",
                            "Mauritania",
                            "Mauritius",
                            "Mexico",
                            "Micronesia",
                            "Moldova",
                            "Monaco",
                            "Mongolia",
                            "Montenegro",
                            "Morocco",
                            "Mozambique",
                            "Namibia",
                            "Nauru",
                            "Nepal",
                            "Netherlands",
                            "New Zealand",
                            "Nicaragua",
                            "Niger",
                            "Nigeria",
                            "North Korea",
                            "Norway",
                            "Oman",
                            "Pakistan",
                            "Palau",
                            "Palestinian Territories",
                            "Panama",
                            "Papua New Guinea",
                            "Paraguay",
                            "Peru",
                            "Philippines",
                            "Poland",
                            "Portugal",
                            "Qatar",
                            "Romania",
                            "Russia",
                            "Rwanda",
                            "Saint Kitts" , "Nevis",
                            "Saint Lucia",
                            "Saint Vincent", "the Grenadines",
                            "Samoa",
                            "San Marino",
                            "Sao Tome ", "Principe",
                            "Saudi Arabia",
                            "Senegal",
                            "Serbia",
                            "Seychelles",
                            "Sierra Leone",
                            "Singapore",
                            "Sint Maarten",
                            "Slovakia",
                            "Slovenia",
                            "Solomon Islands",
                            "Somalia",
                            "South Africa",
                            "South Korea",
                            "South Sudan",
                            "Spain",
                            "Sri Lanka",
                            "Sudan",
                            "Suriname",
                            "Swaziland",
                            "Sweden",
                            "Switzerland",
                            "Syria",
                            "Taiwan",
                            "Tajikistan",
                            "Tanzania",
                            "Thailand",
                            "Timor-Leste",
                            "Togo",
                            "Tonga",
                            "Trinidad and Tobago",
                            "Tunisia",
                            "Turkey",
                            "Turkmenistan",
                            "Tuvalu",
                            "Uganda",
                            "Ukraine",
                            "United Arab Emirates",
                            "United Kingdom",
                            "Uruguay",
                            "Uzbekistan",
                            "Vanuatu",
                            "Venezuela",
                            "Vietnam",
                            "Yemen",
                            "Zambia",
                            "Zimbabwe"};

            comboBox2.Items.AddRange(c);


            pictureBox2.Image = bim;


            pictureBox1.Image = bit;
            pictureBox3.Image = bit;
            pictureBox4.Image = bit;
            pictureBox5.Image = bit;
            pictureBox6.Image = bit;
            pictureBox11.Image = bit;
            pictureBox8.Image = bit;
            pictureBox9.Image = bit;
            pictureBox10.Image = bit;

            try
            {
                conn.sqlConnection1.Open();
                SqlCommand cmd = new  SqlCommand("select count(id) from Customers", conn.sqlConnection1);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    count = Convert.ToInt32(dr[0]);
                    count++;
                    label26.Text = "0" + count.ToString();

                }
                conn.sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                pictureBox1.Visible = true;

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                pictureBox1.Visible = false;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                pictureBox3.Visible = false;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                pictureBox3.Visible = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                pictureBox11.Visible = true;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                pictureBox11.Visible = false;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                pictureBox4.Visible = true;
            }

            if (textBox4.Text.Length <= 8)
            {
                MessageBox.Show("Please Complete The Requirement");
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                pictureBox4.Visible = false;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                pictureBox5.Visible = true;
            }
              
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                pictureBox5.Visible = false;
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                pictureBox8.Visible = true;
            }
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                pictureBox8.Visible = false;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                pictureBox6.Visible = true;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                pictureBox6.Visible = false;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                pictureBox9.Visible = true;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                pictureBox9.Visible = false;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                pictureBox10.Visible = true;
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                pictureBox10.Visible = false;
            }
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {
                comboBox3.Text = "--------------------Select One----------------------";
            }
        }

        private void comboBox3_Enter(object sender, EventArgs e)
        {
            if (comboBox3.Text == "--------------------Select One----------------------")
            {
                comboBox3.Text = "";
                comboBox3.ForeColor = Color.Black;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";

            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;

            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;

            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox11.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;

            if (pictureBox2.Image == bim)
            {
                pictureBox2.Image = b;
            }
            else
            {
                Bitmap c = new Bitmap(@"Market\c.jpg");
                pictureBox2.Image = c;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.sqlConnection1.Open();
                SqlCommand cmd = new  SqlCommand("insert into customers(id,cname,clastname,cusername,cpassword,csex,cdob,ccountry,cph,ccode) values(@id,@cname,@clastname,@cusername,@cpassword,@csex,@cdob,@ccountry,@cph,@ccode)", conn.sqlConnection1);
                cmd.Parameters.AddWithValue("@id",label26.Text.ToString());
                cmd.Parameters.AddWithValue("@cname", textBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@clastname", textBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@cusername", textBox3.Text.ToString());
                cmd.Parameters.AddWithValue("@cpassword", textBox4.ToString());

                cmd.Parameters.AddWithValue("@csex", comboBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@cdob", textBox9.Text.ToString());
                cmd.Parameters.AddWithValue("@ccountry", comboBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@cph", textBox6.Text.ToString());
                cmd.Parameters.AddWithValue("@ccode", textBox8.Text.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show(":Your Account Is Create:");
                conn.sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show( MessageBoxIcon.Warning + ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            counter = textBox4.Text.Length;
            counter++;
            if (textBox4.Text.Length == 1)
            {
                label19.Visible = true;
                label22.Visible = true;
            }

            if (textBox4.Text.Length == 5)
            {
                label20.Visible = true;
                label23.Visible = true;
                label22.Visible = false;
            }

            if (textBox4.Text.Length == 8)
            {
                label21.Visible = true;
                label24.Visible = true;
                label22.Visible = false;
                label23.Visible = false;
            }

            if (textBox4.Text.Length == 0)
            {
                label19.Visible = false;
                label20.Visible = false;
                label22.Visible = false;
                label21.Visible = false;
                label24.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
            }
        }
    }
}
