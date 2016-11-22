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
            Assert.IsFalse(Money.Franc(5).Equals(Money.Dollar(5)));
        }
        
        [Test]
        public void testCurrency()
        {
            Assert.AreEqual("USD", Money.Dollar(1).Currency());
            Assert.AreEqual("CHF", Money.Franc(1).Currency());
        }

        [Test]
        public void testSimpleAddition()
        {
            // 1. New simple test of basic addtition of the same currency type
            //Money sum = Money.Dollar(5).Plus(Money.Dollar(5));
            //Assert.AreEqual(Money.Dollar(10), sum);

            // 3. Change test to handle two different currency types
            // In this case, addition is done preserving currencies, which are finally converted and changed into a total sum by a Bank object.
            Money five = Money.Dollar(5);
            IExpression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(10), reduced);
        }
    }
}
