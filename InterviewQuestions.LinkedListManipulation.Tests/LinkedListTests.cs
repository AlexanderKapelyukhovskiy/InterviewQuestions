using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace InterviewQuestions.LinkedListManipulation.Tests
{
	[TestFixture]
	public class LinkedListTests
	{
		private LinkedList<int> _list;

		[SetUp]
		public void SetUp()
		{
			_list = new LinkedList<int>();
		}

		[Test]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void AddOutOfRange1Test()
		{
			_list.Add(0, 1);
		}

		[Test]
		public void AddFirstTest()
		{
			Assert.That(_list.Count, Is.EqualTo(0));
			_list.Add(0);
			Assert.That(_list.Count, Is.EqualTo(1));
		}

		[Test]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void AddOutOfRange2Test()
		{
			_list.Add(0);
			_list.Add(0, 2);
		}

		[Test]
		[TestCase(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
		public void EnumerateListTest(int[] array, int[] expectedValues)
		{
			_list = CreateList(array);

			int i = 0;
			foreach (var item in _list)
			{
				Assert.That(item, Is.EqualTo(expectedValues[i++]));
			}
		}

		[Test]
		public void AddSecondTest()
		{
			_list.Add(0);
			_list.Add(1);
			_list.Add(2, 1);
			Assert.That(_list.Count, Is.EqualTo(3));
			_list.Add(3, 2);
			Assert.That(_list.Count, Is.EqualTo(4));
			_list.Add(4, 2);
			Assert.That(_list.Count, Is.EqualTo(5));
			_list.Add(-1, 0);
			Assert.That(_list.Count, Is.EqualTo(6));
			_list.Add(5, 6);
			Assert.That(_list.Count, Is.EqualTo(7));
			int i = 0;
			var array = new [] {-1, 0, 2, 4, 3, 1, 5};
			foreach (var item in _list)
			{
				Assert.That(item, Is.EqualTo(array[i++]));
			}
		}

		[Test]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		[TestCase(0)]
		public void GetOutOfRangeEmptyTest(int index)
		{
			_list.Get(index);
		}

		[Test]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		[TestCase(-100)]
		[TestCase(-1)]
		[TestCase(1)]
		[TestCase(2)]
		[TestCase(1000)]
		public void GetOutOfRangeTest(int index)
		{
			_list.Add(0);
			_list.Get(index);
		}

		[Test]
		public void GetTest()
		{
			var array = new[] { 0, 1, 4, 2, 3 };
			_list = CreateList(array);
			for (int i = 0; i < array.Length; i++)
			{
				Assert.That(_list.Get(i), Is.EqualTo(array[i]));
			}
		}

		[Test]
		[ExpectedException(typeof (ArgumentOutOfRangeException))]
		[TestCase(0)]
		public void RemoveOutOfRangeEmptyTest(int index)
		{
			_list.Remove(index);
		}

		[Test]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		[TestCase(-10)]
		[TestCase(-2)]
		[TestCase(-1)]
		[TestCase(1)]
		[TestCase(2)]
		[TestCase(10)]
		public void RemoveOutOfRangeTest(int index)
		{
			_list.Add(0);
			_list.Remove(index);
		}

		[Test]
		[TestCase(new[] { 1, 2, 3 }, 0, new [] { 2, 3 },1)]
		[TestCase(new[] { 1, 2, 3 }, 1, new [] { 1, 3 },2)]
		[TestCase(new[] { 1, 2, 3 }, 2, new[] { 1, 2 },3),]
		[TestCase(new[] { 1 }, 0, new int[] { },4)]
		public void RemoveTest(int[] array, int index, int[] expectedResult, int dummy)
		{
			_list = CreateList(array);
			_list.Remove(index);
			for (int i = 0; i < expectedResult.Length; i++)
			{

				Assert.That(_list.Get(i), Is.EqualTo(expectedResult[i]));
			}
		}

		private LinkedList<T> CreateList<T>(T[] array)
		{
			var list = new LinkedList<T>();
			foreach (T t in array)
			{
				list.Add(t);
			}
			return list;
		}
	}
}