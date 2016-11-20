using System;

using NUnit.Framework;

using WyCash.Core;

namespace WyCash.UnitTests
{
    [TestFixture]
    public class CurrencyTests
    {
        [Test]
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.AreEqual(10, five.Amount);
        }
    }
}
