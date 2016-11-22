using System;

namespace WyCash.Core
{
    public class Sum : IExpression
    {
        public Money Augend { get; private set; }
        public Money Addend { get; private set; }

        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }

        // 3. Alter Reduce to pass in bank as a parameter, since only Bank should know exchange rates.
        //public Money Reduce(string to)
        //{
        //    int amount = Augend.Amount + Addend.Amount;
        //    return new Money(amount, to);
        //}
        public Money Reduce(Bank bank, string to)
        {
            int amount = Augend.Amount + Addend.Amount;
            return new Money(amount, to);
        }
    }
}
