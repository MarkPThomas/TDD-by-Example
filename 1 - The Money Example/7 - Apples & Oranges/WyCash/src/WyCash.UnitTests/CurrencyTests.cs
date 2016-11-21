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
            Dollar five = new Dollar(5);
            Assert.AreEqual(new Dollar(10), five.Times(2));
            Assert.AreEqual(new Dollar(15), five.Times(3));
        }

        [Test]
        public void testEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
            Assert.IsTrue(new Franc(5).Equals(new Franc(5)));
            Assert.IsFalse(new Franc(5).Equals(new Franc(6)));
            // 1. Added new test to ensure that Dollars and Francs are different, despite inheriting from the same base class.
            Assert.IsFalse(new Franc(5).Equals(new Dollar(5)));
        }

        [Test]
        public void testFrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.AreEqual(new Franc(10), five.Times(2));
            Assert.AreEqual(new Franc(15), five.Times(3));
        }
        
    }
}
