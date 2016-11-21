using System;

using NUnit.Framework;

using WyCash.Core;

namespace WyCash.UnitTests
{
    [TestFixture]
    public class CurrencyTests
    {
        // Test rewritten to capitalize on equality implementation.
        // This allows us to inline more of the test, write it more fluently, and make the Amount property a private field.
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
        } 
    }
}
