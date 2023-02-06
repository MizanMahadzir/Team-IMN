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
                tempA1 = Convert.ToInt32(SideA1textBox.Text);
                tempB1 = Convert.ToInt32(SideB1textBox.Text);
                tempC1 = Convert.ToInt32(SideC1textBox.Text);
                MsgLabel1.Text = "Message";
            }
            catch (Exception excep)
            {
                MsgLabel1.Text = "Message: Please give a valid value";
                return;
            }

            myBySide.SideA = tempA1;
            myBySide.SideB = tempB1;
            myBySide.SideC = tempC1;
          


            Perimeter1_label.Text = myBySide.Perimeter().ToString(" 0.0000000000");
            RealityTriangle1Label.Text = "Triangle reality = " + myBySide.Reality();

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
                MsgLabel1.Text = "Message";
            }
            catch (Exception excep)
            {
                MsgLabel1.Text = "Message: Please give a valid value";
                return;
            }

            myBySide.SideA = tempA1;
            myBySide.SideB = tempB1;
            myBySide.SideC = tempC1;

            Area1_label.Text = myBySide.Area().ToString(" 0.0000000000");
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
                tempX1 = Convert.ToInt32(X1textBox.Text);
                tempX2 = Convert.ToInt32(X2textBox.Text);
                tempX3 = Convert.ToInt32(X3textBox.Text);
                tempY1 = Convert.ToInt32(Y1textBox.Text);
                tempY2 = Convert.ToInt32(Y2textBox.Text);
                tempY3 = Convert.ToInt32(Y3textBox.Text);
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




            Perimeter2_label.Text = myByPoint.Perimeter().ToString(" 0.0000000000");
            RealityTriangle2Label.Text = "Triangle reality = " + myByPoint.Reality();
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
                tempX1 = Convert.ToInt32(X1textBox.Text);
                tempX2 = Convert.ToInt32(X2textBox.Text);
                tempX3 = Convert.ToInt32(X3textBox.Text);
                tempY1 = Convert.ToInt32(Y1textBox.Text);
                tempY2 = Convert.ToInt32(Y2textBox.Text);
                tempY3 = Convert.ToInt32(Y3textBox.Text);
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

            Area2_label.Text = myByPoint.Area().ToString(" 0.0000000000");
            RealityTriangle2Label.Text = "Triangle reality = " + myByPoint.Reality();
        }

        private void angleAB_button_point_Click(object sender, EventArgs e)
        {
            double tempX1;
            double tempX2;
            double tempX3;
            double tempY1;
            double tempY2;
            double tempY3;




            try
            {
                tempX1 = Convert.ToInt32(X1textBox.Text);
                tempX2 = Convert.ToInt32(X2textBox.Text);
                tempX3 = Convert.ToInt32(X3textBox.Text);
                tempY1 = Convert.ToInt32(Y1textBox.Text);
                tempY2 = Convert.ToInt32(Y2textBox.Text);
                tempY3 = Convert.ToInt32(Y3textBox.Text);
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

            angleAB_label_point.Text = myByPoint.AngleAB().ToString(" 0.00");
        }

        private void angleAC_button_point_Click(object sender, EventArgs e)
        {
            double tempX1;
            double tempX2;
            double tempX3;
            double tempY1;
            double tempY2;
            double tempY3;




            try
            {
                tempX1 = Convert.ToInt32(X1textBox.Text);
                tempX2 = Convert.ToInt32(X2textBox.Text);
                tempX3 = Convert.ToInt32(X3textBox.Text);
                tempY1 = Convert.ToInt32(Y1textBox.Text);
                tempY2 = Convert.ToInt32(Y2textBox.Text);
                tempY3 = Convert.ToInt32(Y3textBox.Text);
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

            angleAC_label_point.Text = myByPoint.AngleAC().ToString(" 0.00");
        }

        private void angleBC_button_point_Click(object sender, EventArgs e)
        {
            double tempX1;
            double tempX2;
            double tempX3;
            double tempY1;
            double tempY2;
            double tempY3;




            try
            {
                tempX1 = Convert.ToInt32(X1textBox.Text);
                tempX2 = Convert.ToInt32(X2textBox.Text);
                tempX3 = Convert.ToInt32(X3textBox.Text);
                tempY1 = Convert.ToInt32(Y1textBox.Text);
                tempY2 = Convert.ToInt32(Y2textBox.Text);
                tempY3 = Convert.ToInt32(Y3textBox.Text);
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

            angleBC_label_point.Text = myByPoint.AngleBC().ToString(" 0.00");
        }

        private void angleAB_button_side_Click(object sender, EventArgs e)
        {
            double tempA1;
            double tempB1;
            double tempC1;




            try
            {
                tempA1 = Convert.ToInt32(SideA1textBox.Text);
                tempB1 = Convert.ToInt32(SideB1textBox.Text);
                tempC1 = Convert.ToInt32(SideC1textBox.Text);
                MsgLabel1.Text = "Message";
            }
            catch (Exception excep)
            {
                MsgLabel1.Text = "Message: Please give a valid value";
                return;
            }

            myBySide.SideA = tempA1;
            myBySide.SideB = tempB1;
            myBySide.SideC = tempC1;

            angleAB_label_side.Text = myBySide.AngleAB().ToString(" 0.00");
        }

        private void angleAC_button_side_Click(object sender, EventArgs e)
        {
            double tempA1;
            double tempB1;
            double tempC1;




            try
            {
                tempA1 = Convert.ToInt32(SideA1textBox.Text);
                tempB1 = Convert.ToInt32(SideB1textBox.Text);
                tempC1 = Convert.ToInt32(SideC1textBox.Text);
                MsgLabel1.Text = "Message";
            }
            catch (Exception excep)
            {
                MsgLabel1.Text = "Message: Please give a valid value";
                return;
            }

            myBySide.SideA = tempA1;
            myBySide.SideB = tempB1;
            myBySide.SideC = tempC1;

            angleAC_label_side.Text = myBySide.AngleAC().ToString(" 0.00");
        }

        private void angleBC_button_side_Click(object sender, EventArgs e)
        {
            double tempA1;
            double tempB1;
            double tempC1;




            try
            {
                tempA1 = Convert.ToInt32(SideA1textBox.Text);
                tempB1 = Convert.ToInt32(SideB1textBox.Text);
                tempC1 = Convert.ToInt32(SideC1textBox.Text);
                MsgLabel1.Text = "Message";
            }
            catch (Exception excep)
            {
                MsgLabel1.Text = "Message: Please give a valid value";
                return;
            }

            myBySide.SideA = tempA1;
            myBySide.SideB = tempB1;
            myBySide.SideC = tempC1;

            angleBC_label_side.Text = myBySide.AngleBC().ToString(" 0.00");
        }
    }
}

