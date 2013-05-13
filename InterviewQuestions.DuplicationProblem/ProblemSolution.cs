using System;
using System.Collections.Generic;

namespace InterviewQuestions.DuplicationProblem
{
	/// <summary>
	/// Given an array of size N in which every number is between 1 and N, determine
	/// if there are any duplicates in it. You are allowed to destroy the array if you like.
	/// </summary>
	public class ProblemSolution
	{
		/// <summary>
		/// If we can't use additional memory
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static bool IsThereDuplications1(int[] input)
		{
			int s = 0;
			Array.ForEach(input, e => s += e);
			int size = input.Length;
			return s != (size * (size + 1) / 2);
		}

		/// <summary>
		/// If input is not really big
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static bool IsThereDuplications2(int[] input)
		{
			var exist = new bool[input.Length];
			for (int i = 0; i < input.Length; i++)
			{
				int index = input[i] - 1;
				if (exist[index])
					return true;
				exist[index] = true;
			}
			return false;
		}

		/// <summary>
		/// Rest cases
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static bool IsThereDuplications3(int[] input)
		{
			var d = new Dictionary<int, bool>();
			for (int i = 0; i < input.Length; i++)
			{
				int key = input[i];
				if (d.ContainsKey(key))
					return true;
				d[key] = true;
			}
			return false;
		}
	}
}