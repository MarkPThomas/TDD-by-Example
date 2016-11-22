using System;

namespace WyCash.Core
{
    public class Bank
    {
        public Money Reduce(IExpression source, string to)
        {
            //////////return Money.Dollar(10);
            ////////// 7. Implement new Sum object
            //////Sum sum = (Sum)source;
            //////// 8. Below violates the Law of Demeter.
            //////// Move these into the Sum object.
            ////////int amount = sum.Augend.Amount + sum.Addend.Amount;
            ////////return new Money(amount, to);
            //////return sum.Reduce(to);

            ////// 11. If argument supplied is of Money rather than Sum.
            ////if (source is Money) { return (Money)source; }
            //// 12. If Money implemented Reduce, it could be added to the IExpression Interface
            //if (source is Money) { return (Money)source.Reduce(to); }
            //Sum sum = (Sum)source;
            //return sum.Reduce(to);

            // 14. With polymorphism possible, reduce method to eliminate the casts and class checks.
            return source.Reduce(to);
        }
    }
}
