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
            Dollar product = five.Times(2);
            Assert.AreEqual(10, product.Amount);
            product = five.Times(3);
            Assert.AreEqual(15, product.Amount);
        }

        [Test]
        public void testEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));

            // Second test to begin triangulation:
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));

            // Triangulation is a good strategy to use when ensuring design suports certain axes of variability.
            // 1. Only generalize code once we have 2 examples or more.
            // 2. Briefly ignore duplication between test and model code.
            // 3. When the second example demands a more general solution, then and only then do we generalize.
        } 
    }
}
