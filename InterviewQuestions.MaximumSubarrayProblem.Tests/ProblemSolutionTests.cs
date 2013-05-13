using NUnit.Framework;

namespace InterviewQuestions.MaximumSubarrayProblem.Tests
{
	[TestFixture]
	public class ProblemSolutionTests
	{
		[Test]
		[TestCase(new[] { 1, 3, 4, -7, 2, 3 }, new[] { 1, 3, 4})]
		[TestCase(new[] { 1, 3, 4, -10, 2, 7 }, new[] { 2, 7 })]
		public void FindSubarrayTest(int[] input, int[] expected)
		{
			var result = ProblemSolution.GetLargestSumSubArray(input);
			Assert.That(result, Is.EquivalentTo(expected));
		}
	}
}