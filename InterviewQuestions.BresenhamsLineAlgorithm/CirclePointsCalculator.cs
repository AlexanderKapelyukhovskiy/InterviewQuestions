using System.Collections.Generic;

namespace InterviewQuestions.BresenhamsLineAlgorithm
{
	/// <summary>
	/// Write a routine to draw a circle (x ** 2 + y ** 2 = r ** 2) without making use
	/// of any floating point computations at all.
	/// </summary>
	public class CirclePointsCalculator
	{
		public Point[] GetCircle(Point p, int radius)
		{
			int x0 = p.X;
			int y0 = p.Y;

			int x = 0;
			int y = radius;
			int delta = 2 - 2 * radius;

			var circle = new List<Point>();
			while (y >= 0)
			{
				circle.Add(new Point(x0 + x, y0 + y));
				circle.Add(new Point(x0 + x, y0 - y));
				circle.Add(new Point(x0 - x, y0 + y));
				circle.Add(new Point(x0 - x, y0 - y));
				int error = 2 * (delta + y) - 1;
				if (delta < 0 && error <= 0)
				{
					++x;
					delta += 2 * x + 1;
					continue;
				}
				error = 2 * (delta - x) - 1;
				if (delta > 0 && error > 0)
				{
					--y;
					delta += 1 - 2 * y;
					continue;
				}
				++x;
				delta += 2 * (x - y);
				--y;
			}
			return circle.ToArray();
		}
	}
}