using System;
using System.Collections;
using System.Collections.Generic;

namespace InterviewQuestions.LinkedListManipulation
{
	/// <summary>
	/// 48: 7/17
	/// Linked list manipulation. Operations: add element (to the end, to specific index);
	/// delete element by index; get element by index
	/// </summary>
	/// <typeparam name="T">Type of the list item element</typeparam>
	public class LinkedList<T> : IEnumerable<T>, IEnumerator<T>
	{
		private class LinkedListItem<T>
		{
			public T Value { get; set; }
			public LinkedListItem<T> Next { get; set; }
		}

		private int _count;
		private LinkedListItem<T> _head;
		private LinkedListItem<T> _current;

		public void Add(T value)
		{
			Add(value, -1);
		}

		public void Add(T value, int index)
		{
			if (_head == null)
			{
				if (index != -1 && index != 0)
					throw new ArgumentOutOfRangeException("index");

				_head = new LinkedListItem<T> {Value = value};
				_count = 1;
				return;
			}

			if (index != -1 && (index < 0 || index > _count))
				throw new ArgumentOutOfRangeException("index");

			if (index == 0)
			{
				_head = new LinkedListItem<T> {Value = value, Next = _head};
				_count++;
				return;
			}

			LinkedListItem<T> t = GetElement(index == -1 ? index : index - 1);

			t.Next = new LinkedListItem<T> {Value = value, Next = t.Next};
			_count++;
		}

		public T Get(int index)
		{
			if (_head == null || index < 0 || index > (_count - 1))
				throw new ArgumentOutOfRangeException("index");

			var element = GetElement(index);

			return element.Value;
		}

		public void Remove(int index)
		{
			if (_head == null || (index < 0 || index > _count - 1))
				throw new ArgumentOutOfRangeException("index");
			if (index == 0)
			{
				_head = _head.Next;
				_count--;
				return;
			}

			var element = GetElement(index - 1);
			element.Next = element.Next.Next;
			_count--;
		}

		public int Count
		{
			get { return _count; }
		}

		private LinkedListItem<T> GetElement(int index)
		{
			if (index == 0)
				return _head;

			LinkedListItem<T> t = _head;

			int i = 0;
			while ((index == -1 || i < index) && t.Next != null)
			{
				t = t.Next;
				i++;
			}

			if (index != -1 && i != index)
				throw new ArgumentOutOfRangeException("index");

			return t;
		}

		#region IEnumerable<T>, IEnumerator<T>

		public IEnumerator<T> GetEnumerator()
		{
			return this;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this;
		}


		public T Current
		{
			get { return _current.Value; }
		}

		public void Dispose()
		{
		}

		object IEnumerator.Current
		{
			get { return _current.Value; }
		}

		public bool MoveNext()
		{
			if (_head == null)
				return false;

			if (_current == null)
			{
				_current = _head;
				return true;
			}
			if (_current.Next == null)
			{
				return false;
			}

			_current = _current.Next;
			return true;
		}

		public void Reset()
		{
			_current = _head;
		}

		#endregion
	}
}