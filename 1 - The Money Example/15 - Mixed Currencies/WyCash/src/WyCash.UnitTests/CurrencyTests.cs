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
            Assert.AreEqual("USD", Money.Dollar(1).Currency);
            Assert.AreEqual("CHF", Money.Franc(1).Currency);
        }

        [Test]
        public void testSimpleAddition()
        {
            Money five = Money.Dollar(5);
            IExpression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(10), reduced);
        }

        [Test]
        public void testPlusReturnsSum()
        {
            Money five = Money.Dollar(5);
            IExpression result = five.Plus(five);
            Sum sum = (Sum)result;
            Assert.AreEqual(five, sum.Augend);
            Assert.AreEqual(five, sum.Addend);
        }

        [Test]
        public void testReduceSum()
        {
            IExpression sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(7), result);
        }

        [Test]
        public void testReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.Reduce(Money.Dollar(1), "USD");
            Assert.AreEqual(Money.Dollar(1), result);
        }

        [Test]
        public void testIdentityRate()
        {
            Assert.AreEqual(1, new Bank().Rate("USD", "USD"));
        }

        [Test]
        public void testReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.Franc(2), "USD");
            Assert.AreEqual(Money.Dollar(1), result);
        }

        [Test]
        public void testArrayEquals()
        {
            Assert.AreEqual(new object[] { "abc" }, new object[] { "abc" });
        }

        [Test]
        public void testMixedAddition()
        {
            // 1. Target test, but has several compile errors due to loose threads left lying around.
            //IExpression fiveBucks = Money.Dollar(5);
            //IExpression tenFrancs = Money.Franc(10);
            //Bank bank = new Bank();
            //bank.AddRate("CHF", "USD", 2);
            //Money result = bank.Reduce(fiveBucks.Plus(tenFrancs), "USD");
            //Assert.AreEqual(Money.Dollar(10), result);

            // 2. Change to make test compile
            //Money fiveBucks = Money.Dollar(5);
            //Money tenFrancs = Money.Franc(10);
            //Bank bank = new Bank();
            //bank.AddRate("CHF", "USD", 2);
            //Money result = bank.Reduce(fiveBucks.Plus(tenFrancs), "USD");
            //Assert.AreEqual(Money.Dollar(10), result);

            // 5. Now the original test should work ... one Plus is added to the IExpression interface.
            IExpression fiveBucks = Money.Dollar(5);
            IExpression tenFrancs = Money.Franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(fiveBucks.Plus(tenFrancs), "USD");
            Assert.AreEqual(Money.Dollar(10), result);
        }
    }
}
