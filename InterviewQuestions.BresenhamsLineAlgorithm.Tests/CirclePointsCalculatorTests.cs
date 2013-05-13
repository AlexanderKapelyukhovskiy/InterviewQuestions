using System;
using NUnit.Framework;

namespace InterviewQuestions.BresenhamsLineAlgorithm.Tests
{
	[TestFixture]
	public class CirclePointsCalculatorTests
	{
		[Test]
		[TestCase(0, 0, 5, 
			new[] { 0, 0, 0, 0, 1, 1, -1, -1, 2, 2, -2, -2, 3, 3, -3, -3, 4, 4, -4, -4, 4, 4, -4, -4, 5, 5, -5, -5, 6, 6, -6, -6, 6, 6, -6, -6 },
			new[] { 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 9, 1, 9, 1, 9, 1, 9, 1, 8, 2, 8, 2, 7, 3, 7, 3, 6, 4, 6, 4, 5, 5, 5, 5, })]
		public void GetCircleTest(int x, int y, int r, int[] xs, int[] ys)
		{
			var a = new CirclePointsCalculator();
			var result = a.GetCircle(new Point(x, r), r);
			Assert.IsNotNull(result);

			Assert.That(Array.ConvertAll(result, p => p.X), Is.EquivalentTo(xs));
			Assert.That(Array.ConvertAll(result, p => p.Y), Is.EquivalentTo(ys));
		}
	}
}