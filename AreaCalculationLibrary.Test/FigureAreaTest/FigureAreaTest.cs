using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaCalculationLibrary.Test.FigureAreaTest
{
    [TestClass]
    public class FigureAreaTest
    {
        FigureArea.FigureArea figureArea = new FigureArea.FigureArea();

        [TestMethod]
        public void CircleAreaSearch()
        {
            //arrange
            const double circleRadius = 5;
            const double expected = 78.54;

            //act

            double actual = figureArea.CircleAreaSearch(circleRadius);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleArea_three_sides()
        {
            //arrange
            const double firstSide = 3;
            const double secondSide = 5;
            const double thirdSide = 6;
            const double expected = 7.48;

            //act

            double actual = figureArea.TriangleArea(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleArea_two_sides_and_agle()
        {
            //arrange
            const double firstSide = 3;
            const double secondSide = 4;
            const int agle = 30;
            const double expected = 3;

            //act

            double actual = figureArea.TriangleArea(firstSide, secondSide, agle);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
