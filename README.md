# Triangle

1-The DLL version of the GUI based Fraction project at:

https://github.com/MizanMahadzir/Triangle/tree/main/(2)TriangleDLL

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

so the task that have been assigned to our group is completed.

# GOLD STANDARD

The goal standard of this project is to determine various parameters of a triangle based on side and point given by the user.

Side Tab
![image](https://user-images.githubusercontent.com/116859764/215125342-076d879c-6179-4478-9eba-25c47ac8d3c2.png)

Point Tab
![image](https://user-images.githubusercontent.com/116859764/215125069-62c39532-e0bd-424f-8624-e2c8625509ab.png)

1. User will decide to use either to use tab by side or by point.
2. User will need to key in value in box provided.
3. To calculate parameter, user need to click the parameter box given.
4. To calculate area, user need to click the area box given.
5. To calculate angle, user need to click the angle box given.

2-The GUI based Fraction project at:

https://github.com/MizanMahadzir/Triangle/tree/main/(1)Triangle

-Constructors
=For Side
        public TriangleBySideDLL()
        {
            _sideA = 0;
            _sideB = 0;
            _sideC = 0;
        }
=For Point
        public TriangleByPointDLL()
        {
            _x1 = 0;
            _y1 = 0;
            _x2 = 0;
            _y2 = 0;
            _x3 = 0;
            _y3 = 0;
        }

-Methods
=For Side
To find perimeter
        public double Perimeter()
        {
            return _sideA + _sideB + _sideC;
        }
To find half perimeter (S)
        public double S()
        {
            return Perimeter() / 2;
        }
To find area
        public double Area()
        {
            return Math.Sqrt(S() * (S() - _sideA) * (S() - _sideB) * (S() - _sideC));
        }
To find angle
        public double AngleBC()
        {
            return ((Math.Acos(((_sideB * _sideB) + (_sideC * _sideC) - (_sideA * _sideA)) / (2 * _sideB * _sideC))) * 180) / Math.PI;
        }
        public double AngleAC()
        {
            return ((Math.Acos(((_sideA * _sideA) + (_sideC * _sideC) - (_sideB * _sideB)) / (2 * _sideA * _sideC))) * 180) / Math.PI;
        }
        public double AngleAB()
        {
            return ((Math.Acos(((_sideA * _sideA) + (_sideB * _sideB) - (_sideC * _sideC)) / (2 * _sideA * _sideB))) * 180) / Math.PI;
        }
        
=For Point
To find distance
       public double SideA()
        {
            return (Math.Sqrt(((_x2 - _x1) * (_x2 - _x1)) + ((_y2 - _y1) * (_y2 - _y1))));
        }
        public double SideB()
        {
            return (Math.Sqrt(((_x1 - _x3) * (_x1 - _x3)) + ((_y1 - _y3) * (_y1 - _y3))));
        }
        public double SideC()
        {
            return (Math.Sqrt(((_x3 - _x2) * (_x3 - _x2)) + ((_y3 - _y2) * (_y3 - _y2))));
        }
To find perimeter
        public double Perimeter()
        {
            return (Math.Sqrt(((_x2 - _x1) * (_x2 - _x1)) + ((_y2 - _y1) * (_y2 - _y1))))
                + (Math.Sqrt(((_x1 - _x3) * (_x1 - _x3)) + ((_y1 - _y3) * (_y1 - _y3))))
                + (Math.Sqrt(((_x3 - _x2) * (_x3 - _x2)) + ((_y3 - _y2) * (_y3 - _y2))));
        }
To find half perimeter (S)
        public double S()
        {
            return Perimeter() / 2;
        }
To find area
        public double Area()
        {
            return Math.Sqrt(S() * (S() - SideA()) * (S() - SideB()) * (S() - SideC()));
        }
To find angle
        public double AngleBC()
        {
            return ((Math.Acos((SideB() * SideB() + SideC() * SideC() - SideA() * SideA()) / (2 * SideB() * SideC()))) * 180) / Math.PI;
        }
        public double AngleAC()
        {
            return ((Math.Acos((SideA() * SideA() + SideC() * SideC() - SideB() * SideB()) / (2 * SideA() * SideC()))) * 180) / Math.PI;
        }
        public double AngleAB()
        {
            return ((Math.Acos((SideA() * SideA() + SideB() * SideB() - SideC() * SideC()) / (2 * SideA() * SideB()))) * 180) / Math.PI;
        }


Group Members
1. AHMAD WAJDI BIN HAMID 2190770 (Unit Test)
2. MIZAN BIN MAHADZIR 2190772 (Library)
3. NUR IMAN BIN MOHD ANUAR 2190163 (GUI)

