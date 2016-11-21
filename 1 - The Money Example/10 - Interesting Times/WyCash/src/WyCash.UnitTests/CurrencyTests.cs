using System;

using NUnit.Framework;

using WyCash.Core;

namespace WyCash.UnitTests
{
    // TDD Strategy
    // 1. Write a test
    // 2. Make it compile
    // 3. Run to see that it fails
    // 4. Make it run in the green
    // 5. Remove duplication

    [TestFixture]
    public class CurrencyTests
    {
        [Test]
        public void testMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.AreEqual(Money.Dollar(10), five.Times(2));
            Assert.AreEqual(Money.Dollar(15), five.Times(3));
        }

        [Test]
        public void testEquality()
        {
            Assert.IsTrue(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.IsFalse(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.IsTrue(Money.Franc(5).Equals(Money.Franc(5)));
            Assert.IsFalse(Money.Franc(5).Equals(Money.Franc(6)));
            Assert.IsFalse(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        // 6. Add new test for new equality type
        [Test]
        public void testDifferentClassEquality()
        {
            Assert.IsTrue(new Money(10, "CHF").Equals(new Franc(10, "CHF")));
        }

        [Test]
        public void testFrancMultiplication()
        {
            Money five = Money.Franc(5);
            Assert.AreEqual(Money.Franc(10), five.Times(2));
            Assert.AreEqual(Money.Franc(15), five.Times(3));
        }
        
        [Test]
        public void testCurrency()
        {
            Assert.AreEqual("USD", Money.Dollar(1).Currency());
            Assert.AreEqual("CHF", Money.Franc(1).Currency());
        }

        
    }
}
