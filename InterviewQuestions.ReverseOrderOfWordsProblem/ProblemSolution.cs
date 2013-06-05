using System;
using System.Text;

namespace InterviewQuestions.ReverseOrderOfWordsProblem
{
	public class ProblemSolution
	{
		public static string ReverseOne(string input)
		{
			if (string.IsNullOrEmpty(input))
				return input;

			string[] words = input.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

			int length = words.Length;
			if (length == 1)
				return input;

			var sb = new StringBuilder(words[length - 1]);
			for (int i = length - 2; i >= 0; i--)
			{
				sb.AppendFormat(" {0}", words[i]);
			}
			return sb.ToString();
		}

		public static string ReverseTwo(string input)
		{
			if (string.IsNullOrEmpty(input) || input.LastIndexOf(' ') == -1)
				return input;

			int end = input.Length - 1;
			int begin = 0;
			var sb = new StringBuilder();
			bool found = false;
			for (int i = input.Length - 1; i >= 0; i--)
			{
				if (input[i] == ' ')
				{
					if (end != i)
					{
						sb.AppendFormat((found) ? " {0}" : "{0}", input.Substring(i + 1, end - i));
						found = true;
					}
					end = i - 1;
				}
				else
					begin = i;
			}

			var lastString = input.Substring(begin, end + 1);
			if (string.IsNullOrEmpty(lastString) == false)
				sb.AppendFormat(" {0}", lastString);
			
			return sb.ToString();
		}
	}
}