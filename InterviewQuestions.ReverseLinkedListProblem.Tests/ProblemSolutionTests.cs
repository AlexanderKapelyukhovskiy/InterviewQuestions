using NUnit.Framework;

namespace InterviewQuestions.ReverseLinkedListProblem.Tests
{
	[TestFixture]
	public class ProblemSolutionTests
	{
		[Test]
		[TestCase(new[] { 1 }, new[] { 1 })]
		[TestCase(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
		[TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
		public void ReverseFirstVersionTest(int[] listValues, int[] reversedValues)
		{
			var head = CreateLinkedList(listValues);
			LinkedListItem<int> reversedHead = ProblemSolution<int>.ReverseFirstVersion(head);
			Assert.IsNotNull(reversedHead);
			int i = 0;
			while (reversedHead != null)
			{
				Assert.That(reversedHead.Value, Is.EqualTo(reversedValues[i]));
				reversedHead = reversedHead.Next;
				i++;
			}
		}

		[Test]
		[TestCase(new[] {1}, new[] {1})]
		[TestCase(new[] {1, 2, 3}, new[] {3, 2, 1})]
		[TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] {9, 8, 7, 6, 5, 4, 3, 2, 1 })]
		public void ReverseTest(int[] listValues, int[] reversedValues)
		{
			var head = CreateLinkedList(listValues);
			LinkedListItem<int> reversedHead = ProblemSolution<int>.Reverse(head);
			Assert.IsNotNull(reversedHead);
			int i = 0;
			while (reversedHead != null)
			{
				Assert.That(reversedHead.Value, Is.EqualTo(reversedValues[i]));
				reversedHead = reversedHead.Next;
				i++;
			}
		}

		private static LinkedListItem<T> CreateLinkedList<T>(T[] listValues)
		{
			var head = new LinkedListItem<T> {Value = listValues[0]};
			LinkedListItem<T> p = head;
			for (int i = 1; i < listValues.Length; i++)
			{
				p.Next = new LinkedListItem<T> {Value = listValues[i]};
				p = p.Next;
			}
			return head;
		}
	}
}