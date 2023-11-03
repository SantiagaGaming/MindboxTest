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
    public class CircleTests
    {
        [TestMethod()]
        public void GetAreaTest()
        {
            Circle circle = new Circle(6);
            var area = circle.GetArea();
            Assert.IsNotNull(area);
        }
    }
}