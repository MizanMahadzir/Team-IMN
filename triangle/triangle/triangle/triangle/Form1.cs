
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangle
{
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);
            double txt3 = Convert.ToDouble(textBox3.Text);

            double perimeter1 = txt1 + txt2 + txt3;

            textBox4.Text = perimeter1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);
            double txt3 = Convert.ToDouble(textBox3.Text);

            double s1 = (txt1 + txt2 + txt3)/2;

            double area1 = Math.Sqrt(s1 * (s1 - txt1) * (s1 - txt2)* (s1 - txt3));


            textBox5.Text = area1.ToString();
        }

        private void label6_Click(object sender, EventArgs e) //x1
        {

        }

        private void label7_Click(object sender, EventArgs e) //y1
        {

        }

        private void label8_Click(object sender, EventArgs e) //x2
        {

        }

        private void label9_Click(object sender, EventArgs e) //y2
        {

        }

        private void label10_Click(object sender, EventArgs e) //x3
        {

        }

        private void label11_Click(object sender, EventArgs e) //y3
        {

        }


        private void button3_Click(object sender, EventArgs e) //perimeter 2

        {
            double x1 = Convert.ToDouble(textBox6.Text); //x1
            double y1 = Convert.ToDouble(textBox7.Text); //y1
            double x2 = Convert.ToDouble(textBox8.Text); //x2
            double y2 = Convert.ToDouble(textBox9.Text); //y2
            double x3 = Convert.ToDouble(textBox10.Text); //x3
            double y3 = Convert.ToDouble(textBox11.Text); //y3

            double d1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            double d2 = Math.Sqrt(((x1 - x3) * (x1 - x3)) + ((y1 - y3) * (y1 - y3)));
            double d3 = Math.Sqrt(((x3 - x2) * (x3 - x2)) + ((y3 - y2) * (y3 - y2)));

            double perimeter2 = d1 + d2 + d3;

            textBox12.Text = perimeter2.ToString();
        }

        private void button4_Click(object sender, EventArgs e) //area 2
        {
            double x1 = Convert.ToDouble(textBox6.Text); //x1
            double y1 = Convert.ToDouble(textBox7.Text); //y1
            double x2 = Convert.ToDouble(textBox8.Text); //x2
            double y2 = Convert.ToDouble(textBox9.Text); //y2
            double x3 = Convert.ToDouble(textBox10.Text); //x3
            double y3 = Convert.ToDouble(textBox11.Text); //y3

            double d1 = Math.Sqrt(((x2-x1)* (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            double d2 = Math.Sqrt(((x1 - x3) * (x1 - x3)) + ((y1 - y3) * (y1 - y3)));
            double d3 = Math.Sqrt(((x3 - x2) * (x3 - x2)) + ((y3 - y2) * (y3 - y2)));

            double s2 = (d1 + d2 + d3) / 2;

            double area2 = Math.Sqrt(s2 * (s2 - d1) * (s2 - d2) * (s2 - d3));


            textBox13.Text = area2.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
