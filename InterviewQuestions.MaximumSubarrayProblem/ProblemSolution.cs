using System;

namespace InterviewQuestions.MaximumSubarrayProblem
{
	/// <summary>
	/// You're given an array containing both positive and negative integers and
	/// required to find the sub-array with the largest sum (O(N) a la KBL). Write a
	/// routine in C for the above.
	/// </summary>
	public class ProblemSolution
	{
		public static int[] GetLargestSumSubArray(int[] input)
		{
			int begin = 0;
			int beginTemp = 0;
			int end = 0;

			int maxSoFar = input[0];
			int maxEndingHere = input[0];

			for (int i = 1; i < input.Length; i++)
			{
				if (maxEndingHere < 0)
				{
					maxEndingHere = input[i];
					beginTemp = i;
				}
				else
				{
					maxEndingHere += input[i];
				}

				if (maxEndingHere > maxSoFar)
				{
					maxSoFar = maxEndingHere;
					begin = beginTemp;
					end = i;
				}
			}
			int resSize = end - begin + 1;

			var result = new int[resSize];
			Array.Copy(input, begin, result, 0, resSize);
			return result;
		}
	}
}
