using NUnit.Framework;

namespace InterviewQuestions.DepthOfBinaryTreeProblem.Tests
{
	[TestFixture]
	public class ProblemSolutionTests
	{
		[Test]
		public void GetSingleLeaveTreeDepthTest()
		{
			var top = new TreeNode<int> { Value = 1 };
			Assert.That(ProblemSolution<int>.GetTreeDepth(top), Is.EqualTo(1));
		}

		[Test]
		public void GetTreeDepthTest()
		{
			var top = BuildTree1();
			Assert.That(ProblemSolution<int>.GetTreeDepth(top),Is.EqualTo(5));
		}

		[Test]
		public void GetTreeDepthLeftSecondTest()
		{
			var top = BuildTree1(0, true);
			Assert.That(ProblemSolution<int>.GetTreeDepth(top), Is.EqualTo(4));
		}

		[Test]
		public void GetTreeDepthRightLongerDepthTest()
		{
			var top = BuildTree1();
			Assert.That(ProblemSolution<int>.GetTreeDepth(top), Is.EqualTo(5));
		}

		[Test]
		[TestCase(3, 5)]
		[TestCase(4, 6)]
		public void GetTreeDepthLongSecondLeftTest(int addCount, int depth)
		{
			var top = BuildTree1(addCount);
			Assert.That(ProblemSolution<int>.GetTreeDepth(top), Is.EqualTo(depth));
		}

		[Test]
		public void CrazyTest()
		{
			var top = BuildTree1(4, false, true);
			Assert.That(ProblemSolution<int>.GetTreeDepth(top), Is.EqualTo(7));
		}

		private TreeNode<int> BuildTree1(int leavCount = 0, bool leftIsLonger = false, bool addTreeToLeave = false)
		{
			TreeNode<int> t;
			TreeNode<int> rightTail;
			var top =
				new TreeNode<int>
					{
						Value = 1,
						Left = t = new TreeNode<int> {Value = 2},
						Right =
							new TreeNode<int>
								{
									Value = 3,
									Left
										= new TreeNode<int>
											{
												Value = 4,
												Left = new TreeNode<int> {Value = 5}
											},
									Right
										= rightTail
										  = new TreeNode<int>
											  {
												  Value = 6,
												  Right =
													  new TreeNode<int>
														  {
															  Value = 7,
															  Right = new TreeNode<int> {Value = 8}
														  }
											  }
								}
					};
			if (leftIsLonger)
				rightTail.Right = null;

			for (int i = 0; i < leavCount; i++)
			{
				if (addTreeToLeave && i == leavCount-2)
					t.Right = new TreeNode<int> { Value = 99, Right = new TreeNode<int> { Value = 100 } };

				t.Left = new TreeNode<int> {Value = i + 9};
				t = t.Left;
			}
			return top;
		}
	}
}