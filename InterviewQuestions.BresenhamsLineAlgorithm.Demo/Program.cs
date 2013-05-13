using System;

namespace InterviewQuestions.BresenhamsLineAlgorithm.Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			var c = new CirclePointsCalculator();
			var result = c.GetCircle(new Point(10, 10), 5);
			foreach (var p in result)
			{
				Console.SetCursorPosition(p.X, p.Y);
				Console.Write("*");
			}
			Console.ReadKey();
		}
	}
}
