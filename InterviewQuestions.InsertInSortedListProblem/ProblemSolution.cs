using System;

namespace InterviewQuestions.InsertInSortedListProblem
{
	public class LinkedListItem<T> where T : IComparable
	{
		public T Value { get; set; }
		public LinkedListItem<T> Next { get; set; }
	}

	public class ProblemSolution
	{
		public static LinkedListItem<T> Insert<T>(LinkedListItem<T> head, T value) where T : IComparable
		{
			var item = new LinkedListItem<T> {Value = value};
			if (head == null)
				return item;

			LinkedListItem<T> current = head;

			if (current.Value.CompareTo(value) > 0)
			{
				item.Next = head;
				return item;
			}


			while (current.Next != null && current.Next.Value.CompareTo(value) < 0)
			{
				current = current.Next;
			}

			if (current.Next == null)
				current.Next = item;
			else
			{
				item.Next = current.Next;
				current.Next = item;
			}
			
			return head;
		}
	}
}