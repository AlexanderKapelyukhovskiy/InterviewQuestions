using NUnit.Framework;

namespace InterviewQuestions.FastBitCountingProblem.Tests
{
	[TestFixture]
	public class ProblemSolutionTests
	{
		[Test]
		[TestCase(0,0)]
		[TestCase(1, 1)]
		[TestCase(2, 1)]
		[TestCase(3, 2)]
		public void BitCount1Test(int value, int expextedCount)
		{
			int count = ProblemSolution.BitCount1(value);
			Assert.That(count, Is.EqualTo(expextedCount));
		}


		[Test]
		[TestCase(0, 0)]
		[TestCase(1, 1)]
		[TestCase(2, 1)]
		[TestCase(3, 2)]
		public void BitCount2Test(int value, int expextedCount)
		{
			int count = ProblemSolution.BitCount2(value);
			Assert.That(count, Is.EqualTo(expextedCount));
		}
	}
}