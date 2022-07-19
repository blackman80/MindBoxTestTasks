using System;
using NUnit.Framework;
using AreaCalculation;

namespace LibraryTests
{
    public class AreaTriangleTests
    {
		[TestCase(0, 5, 2)]
		[TestCase(17, 0, 11)]
		[TestCase(16, 6, 0)]
		[TestCase(14, -10, 6)]
		[TestCase(-4, 11, 7)]
		[TestCase(19, 16, -1)]
		public void TriangleWithErrorSidesTest(double a, double b, double c)
		{
			Assert.Catch<ArgumentException>(() => new AreaTriangle(a, b, c));
		}

		[Test]
		public void NotCorrectSidesTriangleTest()
		{
			Assert.Catch<ArgumentException>(() => new AreaTriangle(5, 4, 22));
		}

		[TestCase(6, 8, 10, ExpectedResult = true)]
		[TestCase(7, 24, 25, ExpectedResult = true)]
		[TestCase(4, 12, 10, ExpectedResult = false)]
		[TestCase(3, 4.5, 5, ExpectedResult = false)]
		public bool RightTriangleTest(double a, double b, double c)
		{
			// Data
			var triangle = new AreaTriangle(a, b, c);

			// Act
			var isRight = triangle.CheckIsRightTriangle();

			// Assert 
			return isRight;
		}

		[Test]
		public void GetCorrectTriangleSquareTest()
		{
			// Data
			double side1 = 7, side2 = 10, side3 = 5;
			double expected = 16.248;

			// Act
			var triangle = new AreaTriangle(side1, side2, side3);
			var square = triangle.GetSquareThisFigure();

			// Assert
			Assert.AreEqual(expected, triangle.GetSquareThisFigure());
		}
	}
}
