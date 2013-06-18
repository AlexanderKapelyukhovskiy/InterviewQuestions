using NUnit.Framework;
namespace InterviewQuestions.MultipleNumberBySeven.Tests
{
	[TestFixture]
	public class ProblemSolutionTests
	{
		[Test]
		[TestCase(4, 28)]
		[TestCase(5, 35)]
		public void MultipleNumberBySevenTest(int number, int expectedResult)
		{
			int result = ProblemSolution.MultipleBySeven(number);
			Assert.That(result, Is.EqualTo(expectedResult));
		}
	}
}