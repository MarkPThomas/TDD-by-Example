
using System;

namespace WyCash.Core
{
    // Note: Steps of refactoring are preserved and annotated below.
    // This illustrates the minimum steps needed to make the test pass first.
    // Then it shows how the class is modified to remove duplication, as well as dependency on test parameters - without breaking the test.
    public class Dollar : Money
    {
        public Dollar(int amount, string currency)
            : base(amount, currency)
        {

        }

        // 9. Push Times up into base class
        //public override Money Times(int multiplier)
        //{
        //    // 1. Inline factory method, but this time using currency from base class, which as conveniently been set to the correct value
        //    //return Money.Dollar(_amount * multiplier);
        //    //return new Dollar(_amount * multiplier, _currency);
        //    // 8. Now that equality check is improved, bring back step 2.
        //    return new Money(_amount * multiplier, _currency);
        //}
    }
}
