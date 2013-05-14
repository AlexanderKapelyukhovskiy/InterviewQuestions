using System;

namespace InterviewQuestions.PrintLongProblem
{
	/// <summary>
	/// Given only putchar (no sprintf, itoa, etc.) write a routine putlong that prints
	/// out an unsigned long in decimal.
	/// </summary>
	public class ProblemSolution
	{
		public static void PrintLong1(long value, Action<int> print)
		{
			if (value < 10)
			{
				print((int)value);
			}
			else
			{
				PrintLong1(value / 10, print);
				print((int)(value % 10));
			}
		}

		public static void PrintLong2(long value, Action<int> print)
		{
			long i = 10;
			while (i < value)
			{
				i *= 10;
			}
			i /= 10;

			while (i >= 10)
			{
				long r = (value / i);
				print((int)r);
				value = value - r * i;
				i /= 10;
			}
			print((int)value);
		}
	}
}
