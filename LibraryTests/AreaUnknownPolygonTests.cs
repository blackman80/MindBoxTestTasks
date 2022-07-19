using System;
using NUnit.Framework;
using AreaCalculation;

namespace LibraryTests
{
    internal class AreaUnknownPolygonTests
    {
		[Test]
		public void UnknownPolygonCheckCorrectSquareFiveAngles()
		{
			//data
			double expected = 30;

			//act
			var polygon = new AreaUnknownPolygon(
				new GetVector(3, 4),
				new GetVector(5, 11),
				new GetVector(12, 8),
				new GetVector(9, 5),
				new GetVector(5, 6));

			// Assert
			Assert.AreEqual(expected, polygon.GetSquareThisFigure());
		}

		[Test]
		public void UnknownPolygonCheckCorrectSquareFourAngles()
		{
			//data
			double expected = 26.5;

			//act
			var polygon = new AreaUnknownPolygon(
				new GetVector(3, 4),
				new GetVector(5, 11),
				new GetVector(12, 8),
				new GetVector(7, 6));

			// Assert
			Assert.AreEqual(expected, polygon.GetSquareThisFigure());
		}

		[Test]
		public void UnknownPolygonCheckCorrectSquareSevenAngles()
		{
			//data
			double expected = 713.5;

			//act
			var polygon = new AreaUnknownPolygon(
				new GetVector(10, 14),
				new GetVector(22, 8),
				new GetVector(38, 12),
				new GetVector(44, 19),
				new GetVector(10, 55),
				new GetVector(17, 22),
				new GetVector(7, 6));

			// Assert
			Assert.AreEqual(expected, polygon.GetSquareThisFigure());
		}
	}
}
