using NUnit.Framework;

namespace InterviewQuestions.DeleteElementFromDoublyLinkedList.Tests
{
	[TestFixture]
	public class DoubleLinkedListTests
	{
		[Test]
		public void DeleteSingleElementTest()
		{
			var list = new DoubleLinkedList<int>();
			list.Head = list.Tail = new DoubleLinkedList<int>.DoubleLinkedListItem<int> {Value = 1};
			list.Delete(list.Head);

			Assert.IsNull(list.Head);
			Assert.IsNull(list.Tail);
		}

		[Test]
		public void DeleteHeadTest()
		{
			var list = CreateListWithTwoElements();

			list.Delete(list.Head);

			Assert.That(list.Head, Is.EqualTo(list.Tail));
			Assert.That(list.Head.Value, Is.EqualTo(3));
		}

		[Test]
		public void DeleteTailTest()
		{
			var list = CreateListWithTwoElements();

			list.Delete(list.Tail);

			Assert.That(list.Head, Is.EqualTo(list.Tail));
			Assert.That(list.Head.Value, Is.EqualTo(1));
		}

		[Test]
		public void DeleteMiddleElementTest()
		{
			var list = CreateListWithTwoElements();
			list.Head.Next = new DoubleLinkedList<int>.DoubleLinkedListItem<int>()
				{
					Value = 2,
					Next = list.Tail,
					Previous = list.Head
				};
			list.Tail.Previous = list.Head.Next;

			list.Delete(list.Head.Next);
			Assert.That(list.Head.Next, Is.EqualTo(list.Tail));
			Assert.That(list.Tail.Previous, Is.EqualTo(list.Head));
		}

		private static DoubleLinkedList<int> CreateListWithTwoElements()
		{
			var list = new DoubleLinkedList<int>
			{
				Head = new DoubleLinkedList<int>.DoubleLinkedListItem<int> { Value = 1 },
				Tail = new DoubleLinkedList<int>.DoubleLinkedListItem<int> { Value = 3 }
			};
			list.Head.Next = list.Tail;
			list.Tail.Previous = list.Head;
			return list;
		}
	}
}