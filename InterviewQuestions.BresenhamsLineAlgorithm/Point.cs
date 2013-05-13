namespace InterviewQuestions.BresenhamsLineAlgorithm
{
	public class Point
	{
		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		public int X { get; private set; }

		public int Y { get; private set; }

		public override string ToString()
		{
			return string.Format("{0}.{1}", X, Y);
		}
	}
}