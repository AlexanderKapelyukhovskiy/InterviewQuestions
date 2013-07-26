using NUnit.Framework;
namespace InterviewQuestions.StringCleaner.Tests
{
	[TestFixture]
	public class StringExtensionTests
	{
		[Test]
		[TestCase("Hello Wborld", "b", "Hello World")]
		public void RemoveTest(string s2, string s1, string result)
		{
			Assert.That(s2.Remove(s1), Is.EqualTo(result));
		}
	}
}