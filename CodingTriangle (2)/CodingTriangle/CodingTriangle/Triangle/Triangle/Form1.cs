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
        TriangleBySide myBySide = new TriangleBySide();
        TriangleByPoint myByPoint = new TriangleByPoint();




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
                tempA1 = Convert.ToDouble(SideA1textBox.Text);
                tempB1 = Convert.ToDouble(SideB1textBox.Text);
                tempC1 = Convert.ToDouble(SideC1textBox.Text);
                MsgLabel1.Text = "Message";
            }
            catch (Exception excep)
            {
                MsgLabel1.Text = "Message: Please give a valid value";
                return;
            }

            myBySide.SideA1 = tempA1;
            myBySide.SideB1 = tempB1;
            myBySide.SideC1 = tempC1;
          


            Perimeter1_label.Text = myBySide.Perimeter1().ToString(" 0.0000000000");
            RealityTriangle1Label.Text = "Triangle reality = " + myBySide.Reality();

        }

        private void Area1_button_Click(object sender, EventArgs e)
        {
            double tempA1;
            double tempB1;
            double tempC1;




            try
            {
                tempA1 = Convert.ToDouble(SideA1textBox.Text);
                tempB1 = Convert.ToDouble(SideB1textBox.Text);
                tempC1 = Convert.ToDouble(SideC1textBox.Text);
                MsgLabel1.Text = "Message";
            }
            catch (Exception excep)
            {
                MsgLabel1.Text = "Message: Please give a valid value";
                return;
            }

            myBySide.SideA1 = tempA1;
            myBySide.SideB1 = tempB1;
            myBySide.SideC1 = tempC1;

            Area1_label.Text = myBySide.Area1().ToString(" 0.0000000000");
            RealityTriangle1Label.Text = "Triangle reality = " + myBySide.Reality();
        }

  

        private void Perimeter2_button_Click(object sender, EventArgs e)
        {
            double tempX1;
            double tempX2;
            double tempX3;
            double tempY1;
            double tempY2;
            double tempY3;




            try
            {
                tempX1 = Convert.ToDouble(X1textBox.Text);
                tempX2 = Convert.ToDouble(X2textBox.Text);
                tempX3 = Convert.ToDouble(X3textBox.Text);
                tempY1 = Convert.ToDouble(Y1textBox.Text);
                tempY2 = Convert.ToDouble(Y2textBox.Text);
                tempY3 = Convert.ToDouble(Y3textBox.Text);
                MsgLabel2.Text = "Message";
            }
            catch (Exception excep)
            {
                MsgLabel2.Text = "Message: Please give a valid value";
                return;
            }

            myByPoint.X1 = tempX1;
            myByPoint.Y1 = tempY1;
            myByPoint.X2 = tempX2;
            myByPoint.Y2 = tempY2;
            myByPoint.X3 = tempX3;
            myByPoint.Y3 = tempY3;




            Perimeter2_label.Text = myByPoint.Perimeter2().ToString(" 0.0000000000");
            RealityTriangle2Label.Text = "Triangle reality = " + myByPoint.Reality2();
        }

        private void Area2_button_Click(object sender, EventArgs e)
        {
            double tempX1;
            double tempX2;
            double tempX3;
            double tempY1;
            double tempY2;
            double tempY3;




            try
            {
                tempX1 = Convert.ToDouble(X1textBox.Text);
                tempX2 = Convert.ToDouble(X2textBox.Text);
                tempX3 = Convert.ToDouble(X3textBox.Text);
                tempY1 = Convert.ToDouble(Y1textBox.Text);
                tempY2 = Convert.ToDouble(Y2textBox.Text);
                tempY3 = Convert.ToDouble(Y3textBox.Text);
                MsgLabel2.Text = "Message";
            }
            catch (Exception excep)
            {
                MsgLabel2.Text = "Message: Please give a valid value";
                return;
            }

            myByPoint.X1 = tempX1;
            myByPoint.Y1 = tempY1;
            myByPoint.X2 = tempX2;
            myByPoint.Y2 = tempY2;
            myByPoint.X3 = tempX3;
            myByPoint.Y3 = tempY3;

            Area2_label.Text = myByPoint.Area2().ToString(" 0.0000000000");
            RealityTriangle2Label.Text = "Triangle reality = " + myByPoint.Reality2();
        }


    }
}

