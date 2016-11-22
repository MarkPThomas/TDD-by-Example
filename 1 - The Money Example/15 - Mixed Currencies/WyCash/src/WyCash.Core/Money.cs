
namespace WyCash.Core
{
    public class Money : IExpression
    {
        public int Amount { get; private set; }

        public string Currency { get; private set; }


        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return Amount == money.Amount &&
                    Currency.Equals(money.Currency);
        }

        public override string ToString()
        {
            return Amount + " " + Currency;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        // 4. The function can now return IExpression
        //public virtual Money Times(int multiplier)
        //{
        //    return new Money(Amount * multiplier, Currency);
        //}
        public virtual IExpression Times(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }

        // 4. The argument can now be IExpression
        //public IExpression Plus(Money addend)
        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(Currency, to);
            return new Money(Amount / rate, to);
        }
    }
}
