using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trianglelibrary
{
    class TriangleByPoint
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


        public TriangleByPoint()
        {
            _x1 = 0;
            _y1 = 0;
            _x2 = 0;
            _y2 = 0;
            _x3 = 0;
            _y3 = 0;

        }

        //public double SideA2()
        // {
        //    return (Math.Sqrt(((_x2 - _x1) * (_x2 - _x1)) + ((_y2 - _y1) * (_y2 - _y1))));
        //}

        // public double SideB2()
        //{
        //    return (Math.Sqrt(((_x1 - _x3) * (_x1 - _x3)) + ((_y1 - _y3) * (_y1 - _y3))));
        //}

        // public double SideC2()
        // {
        //     return (Math.Sqrt(((_x3 - _x2) * (_x3 - _x2)) + ((_y3 - _y2) * (_y3 - _y2))));
        // }

        public double SideA2()
        {
            return (Math.Sqrt(((_x2 - _x1) * (_x2 - _x1)) + ((_y2 - _y1) * (_y2 - _y1))));
        }
        public double SideB2()
        {
            return (Math.Sqrt(((_x1 - _x3) * (_x1 - _x3)) + ((_y1 - _y3) * (_y1 - _y3))));
        }
        public double SideC2()
        {
            return (Math.Sqrt(((_x3 - _x2) * (_x3 - _x2)) + ((_y3 - _y2) * (_y3 - _y2))));
        }
        public double Perimeter2()
        {
            return (Math.Sqrt(((_x2 - _x1) * (_x2 - _x1)) + ((_y2 - _y1) * (_y2 - _y1))))
                + (Math.Sqrt(((_x1 - _x3) * (_x1 - _x3)) + ((_y1 - _y3) * (_y1 - _y3))))
                + (Math.Sqrt(((_x3 - _x2) * (_x3 - _x2)) + ((_y3 - _y2) * (_y3 - _y2))));

        }

        public double S2()
        {
            return Perimeter2() / 2;

            // return Perimeter2 / 2; 
        }

        public double Area2()
        {
            return Math.Sqrt(S2() * (S2() - SideA2()) * (S2() - SideB2()) * (S2() - SideC2()));

            //return Math.Sqrt(S2*(S2-SideA2)* (S2 - SideB2)* (S2 - SideC2));
        }
        public string Reality2()
        {
            if ((SideA2() > SideB2()) && (SideA2() > SideC2()))
            {
                if (SideB2() + SideC2() > SideA2())
                {
                    return "Real";
                }
                if (SideB2() + SideC2() == SideA2())
                {
                    return "Null";
                }

                if (SideB2() + SideC2() < SideA2())
                {
                    return "Imaginary";
                }

            }

            return "";
        }

    }
}
