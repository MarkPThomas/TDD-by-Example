using System;

namespace WyCash.Core
{
    // 2. Add new class to compile
    // 5. Sum needs to implement IExpression to be returned by Money.Plus
    public class Sum : IExpression
    {
        public Money Augend { get; private set; }
        public Money Addend { get; private set; }

        // 4. Sum needs a constructor
        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Reduce(string to)
        {
            // 8. Moved from Bank to avoid breaking the Law of Demeter.
            int amount = Augend.Amount + Addend.Amount;
            return new Money(amount, to);
        }
    }
}
