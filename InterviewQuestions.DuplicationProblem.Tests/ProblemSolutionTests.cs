using NUnit.Framework;

namespace InterviewQuestions.DuplicationProblem.Tests
{
	[TestFixture]
	public class ProblemSolutionTests
	{
		[Test]
		[TestCase(new[] { 1, 3, 2, 4 }, false)]
		[TestCase(new[] { 1, 3, 2, 1 }, true)]
		public void IsThereDuplications1Test(int[] input, bool answer)
		{
			bool result = ProblemSolution.IsThereDuplications1(input);
			Assert.That(result, Is.EqualTo(answer));
		}

		[Test]
		[TestCase(new[] { 1, 3, 2, 4 }, false)]
		[TestCase(new[] { 1, 3, 2, 1 }, true)]
		public void IsThereDuplications2Test(int[] input, bool answer)
		{
			bool result = ProblemSolution.IsThereDuplications2(input);
			Assert.That(result, Is.EqualTo(answer));
		}

		[Test]
		[TestCase(new[] { 1, 3, 2, 4 }, false)]
		[TestCase(new[] { 1, 3, 2, 1 }, true)]
		public void IsThereDuplications3Test(int[] input, bool answer)
		{
			bool result = ProblemSolution.IsThereDuplications3(input);
			Assert.That(result, Is.EqualTo(answer));
		}
	}
}
