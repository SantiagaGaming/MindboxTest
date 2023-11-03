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
    public class FigureDefinerTests
    {
        [TestMethod()]
        public void DefineTest()
        {
            FigureDefiner figureDefinerCircle = new FigureDefiner(5);
            FigureDefiner figureDefinerTriangle = new FigureDefiner(5, 5, 5);
            var resultCircle = figureDefinerCircle.Define();
            var resultTirangle = figureDefinerTriangle.Define();
            Assert.IsNotNull(resultCircle);
            Assert.IsNotNull(resultTirangle);
        }
    }
}