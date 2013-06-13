using System;

namespace InterviewQuestions.ReverseLinkedListProblem
{
	public class LinkedListItem<T>
	{
		public T Value { get; set; }
		public LinkedListItem<T> Next { get; set; }
	}

	public class ProblemSolution<T>
	{
		

		public static LinkedListItem<T> Reverse(LinkedListItem<T> head)
		{
			if (head == null)
				return null;

			LinkedListItem<T> previous = null;
			LinkedListItem<T> current = head;
			while (current.Next != null)
			{
				LinkedListItem<T> t = current.Next;
				current.Next = previous;
				previous = current;
				current = t;
			}
			return current;
		}

		[Obsolete]
		public static LinkedListItem<T> ReverseFirstVersion(LinkedListItem<T> head)
		{
			if (head == null)
				return null;

			LinkedListItem<T> next = head.Next;
			LinkedListItem<T> current = head;
			while (next != null)
			{
				LinkedListItem<T> t = next.Next;
				next.Next = current;
				current = next;
				next = t;
			}
			head.Next = null;
			return current;
		}
	}
}