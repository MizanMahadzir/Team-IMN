using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDLL
{
    public class TriangleByPointDLL
    {
        private double _x1;
        private double _y1;
        private double _x2;
        private double _y2;
        private double _x3;
        private double _y3;


        public double X1
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


        public TriangleByPointDLL()
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
        public double Perimeter()
        {
            return (Math.Sqrt(((_x2 - _x1) * (_x2 - _x1)) + ((_y2 - _y1) * (_y2 - _y1))))
                + (Math.Sqrt(((_x1 - _x3) * (_x1 - _x3)) + ((_y1 - _y3) * (_y1 - _y3))))
                + (Math.Sqrt(((_x3 - _x2) * (_x3 - _x2)) + ((_y3 - _y2) * (_y3 - _y2))));

        }

        public double S()
        {
            return Perimeter() / 2;

            // return Perimeter / 2; 
        }

        public double Area()
        {
            return Math.Sqrt(S() * (S() - SideA()) * (S() - SideB()) * (S() - SideC()));

            //return Math.Sqrt(S*(S-SideA)* (S - SideB)* (S - SideC));
        }

        //for angleBC
        public double AngleBC()
        {
            return ((Math.Acos((SideB() * SideB() + SideC() * SideC() - SideA() * SideA()) / (2 * SideB() * SideC()))) * 180) / Math.PI;
        }

        //for angleAC
        public double AngleAC()
        {
            return ((Math.Acos((SideA() * SideA() + SideC() * SideC() - SideB() * SideB()) / (2 * SideA() * SideC()))) * 180) / Math.PI;
        }

        //for angleAB
        public double AngleAB()
        {
            return ((Math.Acos((SideA() * SideA() + SideB() * SideB() - SideC() * SideC()) / (2 * SideA() * SideB()))) * 180) / Math.PI;
        }

        public string Reality()
        {
            if ((SideA() > SideB()) && (SideA() > SideC()))
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

            if ((SideB() > SideA()) && (SideB() > SideC()))
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

            if ((SideC() > SideB()) && (SideC() > SideA()))
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
