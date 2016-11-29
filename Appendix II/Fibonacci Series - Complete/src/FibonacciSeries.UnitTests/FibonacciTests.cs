using System;
using System.Runtime.Remoting.Channels;
using NUnit.Framework;

using FibonacciSeries.Core;

namespace FibonacciSeries.UnitTests
{
    [TestFixture]
    public class FibonacciTests
    {
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(2, ExpectedResult = 1)]
        [TestCase(3, ExpectedResult = 2)]
        public int TestFibonacci(int x)
        {
            return Fibonacci.Calc(x);
        }
    }
}
