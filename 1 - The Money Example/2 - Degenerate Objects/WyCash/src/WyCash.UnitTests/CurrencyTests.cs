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
            // Test is changed from last chapter.
            // Goal is to have the five Dollar object remain unchanged from the multiplication.
            //
            // This chapter shows the method of using 'Obvious Implementation' to make the test pass faster, rather than stubbing out behavior.
            // This is done by directly typing in the real implementation as the first step.
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.AreEqual(10, product.Amount);
            product = five.Times(3);
            Assert.AreEqual(15, product.Amount);
        }
    }
}
