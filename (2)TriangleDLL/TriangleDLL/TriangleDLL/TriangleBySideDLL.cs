using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDLL
{
    public class TriangleBySideDLL
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public double SideA
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


        public TriangleBySideDLL()
        {
            _sideA = 0;
            _sideB = 0;
            _sideC = 0;
        }

        public double Perimeter()
        {
            return _sideA + _sideB + _sideC;
        }

        public double S()
        {
            //return (_sideA + _sideB + _sideC)/2;

            return Perimeter() / 2;
        }

        public double Area()
        {
            /*return Math.Sqrt(((_sideA + _sideB + _sideC) / 2) 
                * (((_sideA + _sideB + _sideC) / 2) - _sideA) 
                * (((_sideA + _sideB + _sideC) / 2) - _sideB) 
                * (((_sideA + _sideB + _sideC) / 2) - _sideC)); */

            return Math.Sqrt(S() * (S() - _sideA) * (S() - _sideB) * (S() - _sideC));
        }

        //for angleBC
        public double AngleBC()
        {
            return ((Math.Acos(((_sideB * _sideB) + (_sideC * _sideC) - (_sideA * _sideA)) / (2 * _sideB * _sideC))) * 180) / Math.PI;
        }

        //for angleAC
        public double AngleAC()
        {
            return ((Math.Acos(((_sideA * _sideA) + (_sideC * _sideC) - (_sideB * _sideB)) / (2 * _sideA * _sideC))) * 180) / Math.PI;
        }

        //for angleAB
        public double AngleAB()
        {
            return ((Math.Acos(((_sideA * _sideA) + (_sideB * _sideB) - (_sideC * _sideC)) / (2 * _sideA * _sideB))) * 180) / Math.PI;
        }

        public string Reality()
        {
            if ((_sideA > _sideB) && (_sideA > _sideC))
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

            if ((_sideB > _sideA) && (_sideB > _sideC))
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

            if ((_sideC > _sideB) && (_sideC > _sideA))
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
