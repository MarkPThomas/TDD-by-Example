using NUnit.Framework;

using FibonacciSeries.Core;

namespace FibonacciSeries.UnitTests
{
    // Numbers indicate steps between passing tests.
    [TestFixture]
    public class FibonacciTests
    {
        // 1-2
        //[Test]
        //public void TestFibonacci()
        // 3
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(2, ExpectedResult = 1)]
        [TestCase(3, ExpectedResult = 2)]
        public int TestFibonacci(int x)
        {
            //// 1
            //Assert.AreEqual(0, Fibonacci.Calc(0));
            //// 2
            //Assert.AreEqual(1, Fibonacci.Calc(1));
            // 3
            return Fibonacci.Calc(x);
        }
    }
}
