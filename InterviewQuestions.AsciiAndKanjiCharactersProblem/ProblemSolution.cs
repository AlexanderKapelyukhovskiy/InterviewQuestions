using System;

namespace InterviewQuestions.AsciiAndKanjiCharactersProblem
{
	public class ProblemSolution
	{
		public static bool IsAscii(byte[] data, int index)
		{
			if (index<0 || index>=data.Length)
				throw new IndexOutOfRangeException();

			const long msbMask = 1 << 7;// msb - 10000000

			if (index == 0 && (data[index] & msbMask) != 0) // msb is 1 so this is not an ascii but there is not previous symbol
				throw new Exception("Invalid data, single byte have msb equals to 1 ");

			if ((data[index] & msbMask) != 0)//msb is 1 - so this is not acsii symbol
				return false;

			int currentIndex = index - 1;
			while ((currentIndex) >= 0 && (data[currentIndex] & msbMask) != 0)
			{
				currentIndex--;
			}

			int countOfOnes = (index - currentIndex) - 1;
			return (countOfOnes & 1) == 0;// if count of msb=1 is even then this is ascii
		}
	}
}