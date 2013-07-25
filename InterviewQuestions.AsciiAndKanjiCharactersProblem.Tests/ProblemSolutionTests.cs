using System;
using NUnit.Framework;

namespace InterviewQuestions.AsciiAndKanjiCharactersProblem.Tests
{
	[TestFixture]
	public class ProblemSolutionTests
	{
		[Test]
		[TestCase(1, new byte[] { 0, 1, 128 }, 2, false)]
		[TestCase(2, new byte[] { 0, 127, 1 }, 2, true)]
		[TestCase(3, new byte[] { 0, 128, 1 }, 2, false)]
		[TestCase(4, new byte[] { 128, 128, 1 }, 2, true)]
		[TestCase(5, new byte[] { 0, 128, 128, 1 }, 3, true)]
		[TestCase(6, new byte[] {0, 128, 128, 128, 1 }, 4, false)]
		[TestCase(7, new byte[] { 128, 128, 128, 128, 1 }, 4, true)]
		[TestCase(8, new byte[] { 0, 1, 128 }, 0, true)]
		public void IsAsciiTest(int testCaseIndex, byte[] data, int index, bool result )
		{
			Assert.That(ProblemSolution.IsAscii(data, index), Is.EqualTo(result));
		}

		[Test]
		[TestCase(new byte[] { 0, 1, 128 }, -1)]
		[TestCase(new byte[] { 0, 1, 128 }, 3)]
		[ExpectedException(typeof(IndexOutOfRangeException))]
		public void OutOutOfRangeTest(byte[] data, int index)
		{
			ProblemSolution.IsAscii(data, index);
		}

		[Test]
		[ExpectedException]
		[TestCase(new byte[] { 128, 1, 128 }, 0)]
		public void InvalidDataTest(byte[] data, int index)
		{
			ProblemSolution.IsAscii(data, index);
		}
	}
}