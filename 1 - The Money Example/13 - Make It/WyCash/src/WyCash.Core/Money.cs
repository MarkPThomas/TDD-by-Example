
namespace WyCash.Core
{
    public class Money : IExpression
    {
        // 9. Amount needs to be public due to Sum.Reduce
        //protected int _amount;
        public int Amount { get; private set; }

        // 9a. The setup below is styled from Java. Change to C# style.
        //protected string _currency;
        //public string Currency()
        //{
        //    return _currency;
        //}
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
            // 3. Return a Sum to handle the class cast exception
            //return new Money(_amount + addend._amount, _currency);
            return new Sum(this, addend);
        }

        // 12. If Money implemented Reduce, it could be added to the IExpression Interface
        public Money Reduce(string to)
        {
            return this;
        }
    }
}
