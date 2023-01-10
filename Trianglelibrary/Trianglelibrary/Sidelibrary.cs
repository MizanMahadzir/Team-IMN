using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trianglelibrary
{
    public class TriangleBySide
    {
        private double _sideA; //define
        private double _sideB;
        private double _sideC;

        public double SideA //setter and getter
        {
            get { return _sideA; }
            set { _sideA = value; }
        }

        public double SideB
        {
            get { return _sideB; }
            set { _sideB = value; }
        }

        public double SideC
        {
            get { return _sideC; }
            set { _sideC = value; }
        }


        public TriangleBySide() //constructor
        {
            _sideA = 0;
            _sideB = 0;
            _sideC = 0;
        }

        //for perimeter
        public double Perimeter() //method
        {
            return _sideA + _sideB + _sideC;
        }

        //for half perimeter
        public double S() //method
        {
            //return (_sideA + _sideB + _sideC)/2;

            return Perimeter() / 2;
        }

        //for area
        public double Area() //method
        {
            /*return Math.Sqrt(((_sideA + _sideB + _sideC) / 2) 
                * (((_sideA + _sideB + _sideC) / 2) - _sideA) 
                * (((_sideA + _sideB + _sideC) / 2) - _sideB) 
                * (((_sideA + _sideB + _sideC) / 2) - _sideC)); */

            return Math.Sqrt(S() * (S() - _sideA) * (S() - _sideB) * (S() - _sideC));
        }

        //reality of triangle
        public string Reality() //method
        {
            if ((_sideA > _sideB) && (_sideA > _sideC)) //longest side (sideA)
            {
                if (_sideB + _sideC > _sideA)
                {
                    return "Real";
                }
                if (_sideB + _sideC == _sideA)
                {
                    return "Null";
                }

                if (_sideB + _sideC < _sideA)
                {
                    return "Imaginary";
                }

            }

            if ((_sideB > _sideA) && (_sideB > _sideC)) //longest side (sideB)
            {
                if (_sideA + _sideC > _sideB)
                {
                    return "Real";
                }
                if (_sideA + _sideC == _sideB)
                {
                    return "Null";
                }

                if (_sideA + _sideC < _sideB)
                {
                    return "Imaginary";
                }

            }

            if ((_sideC > _sideB) && (_sideC > _sideA)) //longest side (sideC)
            {
                if (_sideB + _sideA > _sideC)
                {
                    return "Real";
                }
                if (_sideB + _sideA == _sideC)
                {
                    return "Null";
                }

                if (_sideB + _sideA < _sideC)
                {
                    return "Imaginary";
                }

            }

            return "";
        }

    }
}
