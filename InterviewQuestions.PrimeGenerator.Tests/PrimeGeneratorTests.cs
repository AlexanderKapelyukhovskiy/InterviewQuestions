using NUnit.Framework;

namespace InterviewQuestions.PrimeGenerator.Tests
{
    [TestFixture]
    public class PrimeGeneratorTests
    {
        [TestCase(2, new[] {2})]
        [TestCase(3, new[] { 2, 3 })]
        [TestCase(5, new[] { 2, 3, 5 })]
        [TestCase(10, new[] { 2, 3, 5, 7 })]
        public void Test(int maxValue, int[] expectedResults)
        {
            var results = PrimeGenerator.GeneratePrimeNumbers(maxValue);
            Assert.That(results, Is.EquivalentTo(expectedResults));
        }
    }
}