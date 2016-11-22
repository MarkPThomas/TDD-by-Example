
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

        public virtual Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }

        public IExpression Plus(Money addend)
        {
            return new Sum(this, addend);
        }

        // 3. Alter Reduce to pass in bank as a parameter, since only Bank should know exchange rates.
        //public Money Reduce(string to)
        public Money Reduce(Bank bank, string to)
        {
            ////return this;
            //// 2. Implement method just to make the test pass.
            //int rate = (Currency.Equals("CHF") && to.Equals("USD"))
            //    ? 2
            //    : 1;
            //// 4. Move rate calculation into Bank.
            int rate = bank.Rate(Currency, to);
            return new Money(Amount / rate, to);
        }
    }
}
