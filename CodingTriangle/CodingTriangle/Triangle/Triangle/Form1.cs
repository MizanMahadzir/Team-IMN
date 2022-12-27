using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Triangle : Form
    {
        BySide myBySide = new BySide();
        ByPoint myByPoint = new ByPoint();




        public Triangle()
        {
            InitializeComponent();
        }

        private void Perimeter1_button_Click(object sender, EventArgs e)
        {
            double tempA1;
            double tempB1;
            double tempC1;




            try
            {
                tempA1 = Convert.ToInt32(SideA1textBox.Text);
                tempB1 = Convert.ToInt32(SideB1textBox.Text);
                tempC1 = Convert.ToInt32(SideC1textBox.Text);
            }
            catch (Exception excep)
            {
                MsgLabel.Text = "Message: Please give a valid value";
                return;
            }

            myBySide.SideA1 = tempA1;
            myBySide.SideB1 = tempB1;
            myBySide.SideC1 = tempC1;
          


            Perimeter1_label.Text = myBySide.Perimeter1().ToString(" 0.0000000000");
           
        }

        private void Area1_button_Click(object sender, EventArgs e)
        {
            double tempA1;
            double tempB1;
            double tempC1;




            try
            {
                tempA1 = Convert.ToInt32(SideA1textBox.Text);
                tempB1 = Convert.ToInt32(SideB1textBox.Text);
                tempC1 = Convert.ToInt32(SideC1textBox.Text);
            }
            catch (Exception excep)
            {
                MsgLabel.Text = "Message: Please give a valid value";
                return;
            }

            myBySide.SideA1 = tempA1;
            myBySide.SideB1 = tempB1;
            myBySide.SideC1 = tempC1;

            Area1_label.Text = myBySide.Area1().ToString(" 0.0000000000");
        }
    }
}
