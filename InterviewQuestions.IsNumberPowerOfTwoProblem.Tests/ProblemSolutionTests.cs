using NUnit.Framework;

namespace InterviewQuestions.IsNumberPowerOfTwoProblem.Tests
{
	[TestFixture]
	public class ProblemSolutionTests
	{
		[Test]
		[TestCase(2, true)]
		[TestCase(3, false)]
		[TestCase(128, true)]
		[TestCase(234, false)]
		public void IsPowerOfTwoTest(int x, bool result)
		{
			bool r = ProblemSolution.IsPowerOfTwo(x);
			Assert.That(r, Is.EqualTo(result));
		}
	}
}
