﻿
using System;

namespace WyCash.Core
{
    // Note: Steps of refactoring are preserved and annotated below.
    // This illustrates the minimum steps needed to make the test pass first.
    // Then it shows how the class is modified to remove duplication, as well as dependency on test parameters - without breaking the test.
    public class Dollar : Money
    {
        // 3. Create a private field to make the Currency method more generic.
        // private string _currency = "USD";
        // 4. Push private field to base class

        // 5. Add currency parameter to constructor to begin specifying currency in a factory method.
        //public Dollar(int amount, string currency)
        //{
        //    _amount = amount;

        //    // 9. Switch assignment to instance variable
        //    //_currency = "USD";
        //    _currency = currency;
        //}
        // 10. Push implementation by constructor to base class
        public Dollar(int amount, string currency)
            : base(amount, currency)
        {

        }

        // 2. Implement Currency from the abstract class.
        //public override string Currency()
        //{
        //    //return "USD";

        //    // 3. Create a private field to make the Currency method more generic.
        //    return _currency;
        //}
        // 4. Push method back down to base class.

        // 6. Fix changed constructor of the classes to include Currency
        public override Money Times(int multiplier)
        {
            // 7. Remove Factory method that was not phased out
            //return new Dollar(_amount * multiplier, null);
            return Money.Dollar(_amount * multiplier);
        }
    }
}
