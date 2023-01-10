using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trianglelibrary
{
    public class TriangleByPoint
    {
        private double _x1; //define
        private double _y1;
        private double _x2;
        private double _y2;
        private double _x3;
        private double _y3;


        public double X1 //setter and getter
        {
            get { return _x1; }
            set { _x1 = value; }
        }

        public double Y1
        {
            get { return _y1; }
            set { _y1 = value; }
        }

        public double X2
        {
            get { return _x2; }
            set { _x2 = value; }
        }

        public double Y2
        {
            get { return _y2; }
            set { _y2 = value; }
        }

        public double X3
        {
            get { return _x3; }
            set { _x3 = value; }
        }

        public double Y3
        {
            get { return _y3; }
            set { _y3 = value; }
        }


        public TriangleByPoint() //constructor
        {
            _x1 = 0;
            _y1 = 0;
            _x2 = 0;
            _y2 = 0;
            _x3 = 0;
            _y3 = 0;

        }

        //public double SideA()
        // {
        //    return (Math.Sqrt(((_x2 - _x1) * (_x2 - _x1)) + ((_y2 - _y1) * (_y2 - _y1))));
        //}

        // public double SideB()
        //{
        //    return (Math.Sqrt(((_x1 - _x3) * (_x1 - _x3)) + ((_y1 - _y3) * (_y1 - _y3))));
        //}

        // public double SideC()
        // {
        //     return (Math.Sqrt(((_x3 - _x2) * (_x3 - _x2)) + ((_y3 - _y2) * (_y3 - _y2))));
        // }

        //for sideA
        public double SideA() //method
        {
            return (Math.Sqrt(((_x2 - _x1) * (_x2 - _x1)) + ((_y2 - _y1) * (_y2 - _y1))));
        }

        //for sideB
        public double SideB() //method
        {
            return (Math.Sqrt(((_x1 - _x3) * (_x1 - _x3)) + ((_y1 - _y3) * (_y1 - _y3))));
        }

        //for sideC
        public double SideC() //method
        {
            return (Math.Sqrt(((_x3 - _x2) * (_x3 - _x2)) + ((_y3 - _y2) * (_y3 - _y2))));
        }

        //for perimeter
        public double Perimeter() //method
        {
            return (Math.Sqrt(((_x2 - _x1) * (_x2 - _x1)) + ((_y2 - _y1) * (_y2 - _y1))))
                + (Math.Sqrt(((_x1 - _x3) * (_x1 - _x3)) + ((_y1 - _y3) * (_y1 - _y3))))
                + (Math.Sqrt(((_x3 - _x2) * (_x3 - _x2)) + ((_y3 - _y2) * (_y3 - _y2))));

        }

        //for half perimeter
        public double S() //method
        {
            return Perimeter() / 2;

            // return Perimeter / 2; 
        }

        //for area
        public double Area() //method
        {
            return Math.Sqrt(S() * (S() - SideA()) * (S() - SideB()) * (S() - SideC()));

            //return Math.Sqrt(S*(S-SideA)* (S - SideB)* (S - SideC));
        }

        //for reality of triangle
        public string Reality() //method
        {
            if ((SideA() > SideB()) && (SideA() > SideC())) //longest side (sideA)
            {
                if (SideB() + SideC() > SideA())
                {
                    return "Real";
                }
                if (SideB() + SideC() == SideA())
                {
                    return "Null";
                }

                if (SideB() + SideC() < SideA())
                {
                    return "Imaginary";
                }

            }

            if ((SideB() > SideA()) && (SideB() > SideC())) //longest side (sideB)
            {
                if (SideA() + SideC() > SideB())
                {
                    return "Real";
                }
                if (SideA() + SideC() == SideB())
                {
                    return "Null";
                }

                if (SideA() + SideC() < SideB())
                {
                    return "Imaginary";
                }

            }

            if ((SideC() > SideB()) && (SideC() > SideA())) //longest side (sideC)
            {
                if (SideB() + SideA() > SideC())
                {
                    return "Real";
                }
                if (SideB() + SideA() == SideC())
                {
                    return "Null";
                }

                if (SideB() + SideA() < SideC())
                {
                    return "Imaginary";
                }

            }

            return "";
        }

    }
}
