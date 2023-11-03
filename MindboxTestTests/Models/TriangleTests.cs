using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTest.Models.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void GetAreaTest()
        {
            Triangle triangle = new Triangle(5, 5, 5);
            var area = triangle.GetArea();
            Assert.IsNotNull(area);
        }

        [TestMethod()]
        public void IsRectangularTest()
        {
            Triangle triangle = new Triangle(25, 24, 7);
            var result = triangle.IsRectangular();
            Assert.IsTrue(result);
        }
    }
}