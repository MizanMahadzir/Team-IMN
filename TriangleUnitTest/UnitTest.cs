using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Trianglelibrary;

namespace TriangleUnitTest
{
    [TestClass]
    public class UnitTestBySide
    {
        [TestMethod]
        public void TestConstructor()
        {
            TriangleBySide atriangle = new TriangleBySide();

            Assert.AreEqual(atriangle.SideA, 0);
            Assert.AreEqual(atriangle.SideB, 0);
            Assert.AreEqual(atriangle.SideC, 0);

        }

        [TestMethod]
        public void TestProperties()
        {
            TriangleBySide atriangle = new TriangleBySide();
            atriangle.SideA = 2;
            atriangle.SideB = 3;
            atriangle.SideC = 4;

            Assert.AreEqual(atriangle.SideA, 2);
            Assert.AreEqual(atriangle.SideB, 3);
            Assert.AreEqual(atriangle.SideC, 4);

        }

        [TestMethod]
        public void TestArea()
        {
            TriangleBySide atriangle = new TriangleBySide();
            atriangle.SideA = 3;
            atriangle.SideB = 4;
            atriangle.SideC = 5;

            Assert.AreEqual(atriangle.Area(), 6);
        }


        [TestMethod]
        public void TestPerimeter()
        {
            TriangleBySide atriangle = new TriangleBySide();
            atriangle.SideA = 3;
            atriangle.SideB = 4;
            atriangle.SideC = 5;

            Assert.AreEqual(atriangle.Perimeter(), 12);
        }


        [TestMethod]
        public void TestAngle()
        {
            TriangleBySide atriangle = new TriangleBySide();
            atriangle.SideA = 3;
            atriangle.SideB = 4;
            atriangle.SideC = 5;

            Assert.AreEqual(atriangle.AngleAB(), 90);
            Assert.AreEqual(atriangle.AngleAC(), 53);
            Assert.AreEqual(atriangle.AngleBC(), 37);

        }

        [TestMethod]
        public void TestHalfPerimeter()
        {
            TriangleBySide atriangle = new TriangleBySide();
            atriangle.SideA = 3;
            atriangle.SideB = 4;
            atriangle.SideC = 5;

            Assert.AreEqual(atriangle.S(), 6);

        }
    }

    [TestClass]
    public class UnitTestByPoint
    {
        [TestMethod]
        public void TestConstructor()
        {
            TriangleByPoint atriangle = new TriangleByPoint();

            Assert.AreEqual(atriangle.SideA(), 0);
            Assert.AreEqual(atriangle.SideB(), 0);
            Assert.AreEqual(atriangle.SideC(), 0);

        }

        [TestMethod]
        public void TestProperties()
        {
            TriangleBySide atriangle = new TriangleBySide();
            atriangle.SideA = 2;
            atriangle.SideB = 3;
            atriangle.SideC = 4;

            Assert.AreEqual(atriangle.SideA, 2);
            Assert.AreEqual(atriangle.SideB, 3);
            Assert.AreEqual(atriangle.SideC, 4);

        }

        [TestMethod]
        public void TestArea()
        {
            TriangleBySide atriangle = new TriangleBySide();
            atriangle.SideA = 3;
            atriangle.SideB = 4;
            atriangle.SideC = 5;

            Assert.AreEqual(atriangle.Area(), 6);
        }


        [TestMethod]
        public void TestPerimeter()
        {
            TriangleBySide atriangle = new TriangleBySide();
            atriangle.SideA = 3;
            atriangle.SideB = 4;
            atriangle.SideC = 5;

            Assert.AreEqual(atriangle.Perimeter(), 12);
        }


        [TestMethod]
        public void TestAngle()
        {
            TriangleBySide atriangle = new TriangleBySide();
            atriangle.SideA = 3;
            atriangle.SideB = 4;
            atriangle.SideC = 5;

            Assert.AreEqual(atriangle.AngleAB(), 90);
            Assert.AreEqual(atriangle.AngleAC(), 53);
            Assert.AreEqual(atriangle.AngleBC(), 37);

        }

        [TestMethod]
        public void TestHalfPerimeter()
        {
            TriangleBySide atriangle = new TriangleBySide();
            atriangle.SideA = 3;
            atriangle.SideB = 4;
            atriangle.SideC = 5;

            Assert.AreEqual(atriangle.S(), 6);

        }
    }
}
