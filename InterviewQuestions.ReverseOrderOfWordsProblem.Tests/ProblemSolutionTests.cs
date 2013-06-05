using NUnit.Framework;
namespace InterviewQuestions.ReverseOrderOfWordsProblem.Tests
{
	[TestFixture]
	public class ProblemSolutionTests
	{
		[Test]
		[TestCase(null,null)]
		[TestCase("", "")]
		[TestCase("test", "test")]
		[TestCase("test1 test2", "test2 test1")]
		[TestCase(" test1  test2  test3 ", "test3 test2 test1")]
		public void ReverseOneTest(string input, string expextedResult)
		{
			string result = ProblemSolution.ReverseOne(input);
			Assert.That(result, Is.EqualTo(expextedResult));
		}

		[Test]
		[TestCase(null, null)]
		[TestCase("", "")]
		[TestCase("test", "test")]
		[TestCase("test1 test2", "test2 test1")]
		[TestCase(" test1  t  test2  test3 ", "test3 test2 t test1")]
		public void ReverseTwoTest(string input, string expextedResult)
		{
			string result = ProblemSolution.ReverseTwo(input);
			Assert.That(result, Is.EqualTo(expextedResult));
		}
	}
}