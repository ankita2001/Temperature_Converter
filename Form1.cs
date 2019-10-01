using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Celcius");
            comboBox1.Items.Add("Fahrenheit");
            comboBox1.Items.Add("Kelvin");
            comboBox2.Items.Add("Celcius");
            comboBox2.Items.Add("Fahrenheit");
            comboBox2.Items.Add("Kelvin");

            button1.Enabled = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Celcius" || comboBox2.Text == "Fahrenheit" || comboBox2.Text == "Kelvin")
            {
                textBox1.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Celcius" || comboBox1.Text == "Fahrenheit" || comboBox1.Text == "Kelvin")
            {
                label3.Focus();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Double cTemp;
            Double fTemp;
            Double kTemp;
            Double dTemp;

            dTemp = Double.Parse(textBox1.Text);

            if (comboBox2.Text == "Celcius" && comboBox1.Text == "Celcius")
            {
                label3.Text = Convert.ToString(dTemp);

            }

            if (comboBox2.Text == "Fahrenheit" && comboBox1.Text == "Celcius")
            {
                cTemp = (5.0 / 9.0 * (dTemp - 32));
                label3.Text = Convert.ToString(cTemp);

            }

            if (comboBox2.Text == "Kelvin" && comboBox1.Text == "Celcius")
            {
                cTemp = dTemp - 273.15;
                label3.Text = Convert.ToString(cTemp);

            }



            if (comboBox2.Text == "Celcius" && comboBox1.Text == "Fahrenheit")
            {
                fTemp = ((9.0 / 5.0 * dTemp) + 32);
                label3.Text = Convert.ToString(fTemp);

            }

            if (comboBox2.Text == "Fahrenheit" && comboBox1.Text == "Fahrenheit")
            {
                label3.Text = Convert.ToString(dTemp);

            }

            if (comboBox2.Text == "Kelvin" && comboBox1.Text == "Fahrenheit")
            {
                fTemp = (((dTemp - 273.15) * 9.0 / 5.0) + 32);
                label3.Text = Convert.ToString(fTemp);

            }



            if (comboBox2.Text == "Celcius" && comboBox1.Text == "Kelvin")
            {
                kTemp = dTemp + 273.15;
                label3.Text = Convert.ToString(kTemp);

            }

            if (comboBox2.Text == "Fahrenheit" && comboBox1.Text == "Kelvin")
            {
                kTemp = (((dTemp - 32) * 5.0 / 9.0) + 273.15);
                label3.Text = Convert.ToString(kTemp);

            }

            if (comboBox2.Text == "Kelvin" && comboBox1.Text == "Kelvin")
            {
                label3.Text = Convert.ToString(dTemp);

            }
        }

        
    }
}

