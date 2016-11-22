using System;

namespace WyCash.Core
{
    public class Sum : IExpression
    {
        // 4. These can now be IExpression
        //public Money Augend { get; private set; }
        //public Money Addend { get; private set; }
        public IExpression Augend { get; private set; }
        public IExpression Addend { get; private set; }

        // 4. These can now be IExpression
        //public Sum(Money augend, Money addend)
        public Sum(IExpression augend, IExpression addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            // 3. Implement reduction. This was not done after earlier implementation.
            //int amount = Augend.Amount + Addend.Amount;
            //return new Money(amount, to);
            int amount = Augend.Reduce(bank, to).Amount +
                         Addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }

        // 7. Move Plus into the interface requires this. We'll stub it out for now.
        public IExpression Plus(IExpression addend)
        {
            return null;
        }
    }
}
