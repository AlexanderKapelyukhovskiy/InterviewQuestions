using System.Collections.Generic;

namespace InterviewQuestions.DepthOfBinaryTreeProblem
{
	public class TreeNode<T>
	{
		public TreeNode<T> Left { get; set; }
		public TreeNode<T> Right { get; set; }
		public T Value { get; set; }
	}

	public class ProblemSolution<T>
	{
		public static int GetTreeDepth(TreeNode<T> top)
		{
			int maxDepth = 0;
			int currentDepth = 0;
			var stack = new Stack<TreeNode<T>>();
			while (top != null || stack.Count != 0)
			{
				if (stack.Count != 0)
				{
					top = stack.Pop();
					top = top.Right;
					if (top == null)
						currentDepth--;
				}
				while (top != null)
				{
					stack.Push(top);
					top = top.Left;
					currentDepth++;
					if (maxDepth < currentDepth)
						maxDepth = currentDepth;
				}
			}
			return maxDepth;
		}
	}
}