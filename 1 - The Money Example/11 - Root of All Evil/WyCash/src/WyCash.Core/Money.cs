
namespace WyCash.Core
{
    public class Money
    {
        protected int _amount;
        protected string _currency;

        public Money(int amount, string currency)
        {
            _amount = amount;
            _currency = currency;
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return _amount == money._amount &&
                    Currency().Equals(money.Currency());
        }

        public override string ToString()
        {
            return _amount + " " + _currency;
        }

        public static Money Dollar(int amount)
        {
            // 1. Replace references to subclass with reference to superclass
            //return new Dollar(amount, "USD");
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            // 1. Replace references to subclass with reference to superclass
            //return new Franc(amount, "CHF");
            return new Money(amount, "CHF");
        }

        public virtual Money Times(int multiplier)
        {
            return new Money(_amount * multiplier, _currency);
        }

        public string Currency()
        {
            return _currency;
        }

    }
}
