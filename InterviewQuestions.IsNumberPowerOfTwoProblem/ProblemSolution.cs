namespace InterviewQuestions.IsNumberPowerOfTwoProblem
{
	/// <summary>
	/// Give a one-line C expression to test whether a number is a power of 2.
	/// </summary>
	public class ProblemSolution
	{
		public static bool IsPowerOfTwo(int x)
		{
			return (x != 0) && ((x & (x - 1)) == 0);
		}
	}
}
