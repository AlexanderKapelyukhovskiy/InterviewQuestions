using System;
using NUnit.Framework;

namespace InterviewQuestions.InsertInSortedListProblem.Tests
{
	public class ProblemSolutionTests
	{
		[Test]
		[TestCase(new[] { 1, 4, 5 }, new[] { 1, 3, 4, 5 }, 3)]
		[TestCase(new[] { 2, 4, 5 }, new[] { 1, 2, 4, 5 }, 1)]
		[TestCase(new[] { 2, 4, 5 }, new[] { 2, 4, 5, 6 }, 6)]
		public void InsertTest(int[] listValues, int[] listValuesAfterInsert, int value)
		{
			var newHead = ProblemSolution.Insert(CreateLinkedList(listValues), value);

			VerifyList(listValuesAfterInsert, newHead);
		}

		private static void VerifyList(int[] array, LinkedListItem<int> head)
		{
			Assert.IsNotNull(head);
			int i = 0;
			while (head != null)
			{
				Assert.That(head.Value, Is.EqualTo(array[i]));
				head = head.Next;
				i++;
			}
		}

		private static LinkedListItem<T> CreateLinkedList<T>(T[] listValues) where T : IComparable
		{
			var head = new LinkedListItem<T> { Value = listValues[0] };
			LinkedListItem<T> p = head;
			for (int i = 1; i < listValues.Length; i++)
			{
				p.Next = new LinkedListItem<T> { Value = listValues[i] };
				p = p.Next;
			}
			return head;
		}
	}
}