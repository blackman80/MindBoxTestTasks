using System;
using AreaCalculation.Interfaces;

namespace AreaCalculation
{
    public class AreaCircle : IFigure
    {
        public double Radius { get; }
        public AreaCircle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус круга меньше или равен нулю.");
            }
            Radius = radius;
        }

        public double GetSquareThisFigure()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 3);
        }
    }
}
