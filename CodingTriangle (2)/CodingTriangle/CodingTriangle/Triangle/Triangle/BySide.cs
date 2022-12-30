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
    class TriangleBySide
    {
        private double _sideA1;
        private double _sideB1;
        private double _sideC1;

        public double SideA1
        { 
            get { return _sideA1; }
            set { _sideA1 = value; }
        }

        public double SideB1
        {
            get { return _sideB1; }
            set { _sideB1 = value; }
        }

        public double SideC1
        {
            get { return _sideC1; }
            set { _sideC1 = value; }
        }


        public TriangleBySide()
        {
            _sideA1 = 0;
            _sideB1 = 0;
            _sideC1 = 0;
        }

        public double Perimeter1()
        {
            return _sideA1 + _sideB1 + _sideC1 ;
        }

        public double S1()
        {
            //return (_sideA1 + _sideB1 + _sideC1)/2;

           return Perimeter1() / 2; 
        }

        public  double Area1()
        {
            /*return Math.Sqrt(((_sideA1 + _sideB1 + _sideC1) / 2) 
                * (((_sideA1 + _sideB1 + _sideC1) / 2) - _sideA1) 
                * (((_sideA1 + _sideB1 + _sideC1) / 2) - _sideB1) 
                * (((_sideA1 + _sideB1 + _sideC1) / 2) - _sideC1)); */

            return Math.Sqrt(S1()*(S1()-_sideA1)* (S1() - _sideB1)* (S1() - _sideC1));
        }

        public string Reality()
        {
           if ((_sideA1> _sideB1) && (_sideA1>_sideC1))
            {
                if (_sideB1+_sideC1 > _sideA1)
                {
                    return "Real";
                }
                if (_sideB1 + _sideC1 == _sideA1)
                {
                    return "Null";
                }

                if (_sideB1 + _sideC1 < _sideA1)
                {
                    return "Imaginary";
                }

            }

            return "";
        }

    }
}