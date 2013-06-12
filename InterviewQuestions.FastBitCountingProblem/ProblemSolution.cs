namespace InterviewQuestions.FastBitCountingProblem
{
	public class ProblemSolution
	{
		public static int BitCount1(int value)
		{
			int count = 0;
			while (value > 0)
			{
				// until all bits are zero
				if ((value & 1) == 1) // check lower bit
					count++;
				value >>= 1; // shift bits, removing lower bit
			}
			return count;
		}

		public static int BitCount2(int i)
		{
			i = i - ((i >> 1) & 0x55555555);
			i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
			return (((i + (i >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24;
		}
	}
}
