using AreaCalculation.Interfaces;

namespace AreaCalculation
{
    public class GetVector : IVector
    {
		public float X { get; }
		public float Y { get; }
		public GetVector(float x, float y)
		{
			X = x;
			Y = y;
		}
	}
}
