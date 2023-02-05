# **TRIANGLE**


## 1-The DLL version of the GUI based Triangle project at:

https://github.com/MizanMahadzir/Triangle/tree/main/(2)TriangleDLL

the GUI exe version for the unified numeral

Gold standard link for triangle calculator using side as parameter: 

https://www.triangle-calculator.com/?q=a%3D5+b%3D3+c%3D6&submit=Solve

Gold standard link for triangle calculator using point as parameter: 

https://www.triangle-calculator.com/?what=vc&a=2&a1=5&3dd=3D&a2=&b=7&b1=4&b2=&c=5&c1=5&c2=&submit=Solve&3d=0

### GOLD STANDARD

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

## 2-The GUI based Triangle project at:

https://github.com/MizanMahadzir/Triangle/tree/main/(1)Triangle

**Constructors**

_For Side_

        public TriangleBySideDLL()
        {
            _sideA = 0;
            _sideB = 0;
            _sideC = 0;
        }
        
_For Point_

        public TriangleByPointDLL()
        {
            _x1 = 0;
            _y1 = 0;
            _x2 = 0;
            _y2 = 0;
            _x3 = 0;
            _y3 = 0;
        }

**Methods**

_For Side_

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
        
_For Point_

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

