using System;
using NUnit.Framework;
using AreaCalculation;

namespace LibraryTests
{
    public class AreaCircleTests
    {
        [Test]
        public void NegativeNotCorrectRadiusCircle()
        {
            Assert.Catch<ArgumentException>(() => new AreaCircle(-10));
        }

        [Test]
        public void GetCorrectCircleSquare()
        {
            //data
            double expected = 1134.115;

            //act
            var circle = new AreaCircle(19);

            // Assert
            Assert.AreEqual(expected, circle.GetSquareThisFigure());
        }
    }
}