using System;
using System.Collections.Generic;
using System.Linq;
using AreaCalculation.Interfaces;

namespace AreaCalculation
{
    public class AreaUnknownPolygon : IFigure
	{
		public List<GetVector> VectorPoints;

		public AreaUnknownPolygon(params GetVector[] dots)
		{
			VectorPoints = dots.ToList();
		}

		public double GetSquareThisFigure()
		{
			double sum = 0;
			int j = 0;
			var p1 = VectorPoints[0];
			var p2 = VectorPoints[0];
			for (int i = 0; i < VectorPoints.Count; i++)
			{
				j = (i + 1) % VectorPoints.Count;
				p1 = VectorPoints[i];
				p2 = VectorPoints[j];

				sum += p1.X * p2.Y - p1.Y * p2.X;
			}
			return Math.Abs(sum) / 2;
		}
	}
}
