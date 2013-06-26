namespace InterviewQuestions.MultipleNumberBySeven
{
	/// <summary>
	/// 47: 7/15
	/// Multiple a number by 7
	/// </summary>
	public class ProblemSolution
	{
		public static int MultipleBySeven(int number)
		{
			return (number << 3) - number;
		}
	}
}