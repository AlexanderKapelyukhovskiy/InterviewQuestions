using System.Diagnostics;
using NUnit.Framework;

namespace InterviewQuestions.PrintLongProblem.Tests
{
	[TestFixture]
	public class ProblemSolutionTests
	{
		[Test]
		public void PrintLong1Test()
		{
			ProblemSolution.PrintLong1(123141413240, v => Trace.Write(" " + v + " "));
		}

		[Test]
		public void PrintLong2Test()
		{
			ProblemSolution.PrintLong2(123141413240, v => Trace.Write(" " + v + " "));
		}
	}
}
