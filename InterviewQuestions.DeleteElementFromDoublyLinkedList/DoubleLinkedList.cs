namespace InterviewQuestions.DeleteElementFromDoublyLinkedList
{
	public class DoubleLinkedList<T>
	{
		public class DoubleLinkedListItem<T>
		{
			public T Value { get; set; }
			public DoubleLinkedListItem<T> Previous { get; set; }
			public DoubleLinkedListItem<T> Next { get; set; }
		}

		public DoubleLinkedListItem<T> Head { get; set; }
		public DoubleLinkedListItem<T> Tail { get; set; }

		public void Delete(DoubleLinkedListItem<T> element)
		{
			if (element.Previous != null && element.Next != null)
			{
				element.Next.Previous = element.Previous;
				element.Previous.Next = element.Next;
			}
			else if (element.Previous == null && element.Next == null)
			{
				Head = null;
				Tail = null;
			}
			else if (element.Previous == null)
			{
				Head = element.Next;
				element.Next.Previous = null;
			}
			else
			{
				Tail = element.Previous;
				element.Previous.Next = null;
			}
		}
	}
}