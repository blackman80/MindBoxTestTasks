using System;
using AreaCalculation.Interfaces;

namespace AreaCalculation
{
    public class AreaTriangle : IFigure
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public AreaTriangle(double side1, double side2, double side3)
        {
            // проверка ввода
            if (side1 <= 0)
                throw new ArgumentException("Сторона 1 меньше или равна 0.");
            if (side2 <= 0)
                throw new ArgumentException("Сторона 2 меньше или равна 0.");
            if (side3 <= 0)
                throw new ArgumentException("Сторона 3 меньше или равна 0.");

            if (side1 > side2 + side3 || side2 > side1 + side3 || side3 > side1 + side2)
            {
                throw new ArgumentException("Наибольшая сторона треугольника должна быть меньше суммы других сторон");
            }

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double GetSquareThisFigure()
        {
            double halfPerimeter = (Side1 + Side2 + Side3) / 2;
            double square = Math.Round(Math.Sqrt(
                halfPerimeter
                * (halfPerimeter - Side1)
                * (halfPerimeter - Side2)
                * (halfPerimeter - Side3)
            ), 3);

            return square;
        }

        public bool CheckIsRightTriangle()
        {
            double maxSide = 0;
            maxSide = Side2 > Side1 ? Side2 : Side1;
            maxSide = maxSide > Side3 ? maxSide : Side3;
            if (maxSide == Side1)
                return Math.Pow(Side2, 2) + Math.Pow(Side3, 2) == Math.Pow(maxSide, 2);
            if (maxSide == Side2)
                return Math.Pow(Side1, 2) + Math.Pow(Side3, 2) == Math.Pow(maxSide, 2);
            return Math.Pow(Side1, 2) + Math.Pow(Side2, 2) == Math.Pow(maxSide, 2);
        }
    }
}

