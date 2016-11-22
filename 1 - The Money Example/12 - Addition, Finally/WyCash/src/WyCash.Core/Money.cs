
namespace WyCash.Core
{
    // 4. Add interface for lightweight implementation
    public class Money : IExpression
    {
        protected int _amount;

        protected string _currency;
        public string Currency()
        {
            return _currency;
        }


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
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public virtual Money Times(int multiplier)
        {
            return new Money(_amount * multiplier, _currency);
        }

        // 2. Add new method to compile
        //public Money Plus(Money addend)
        //{
        //    return new Money(_amount + addend._amount, _currency);
        //}
        // 4. Add interface for lightweight implementation
        public IExpression Plus(Money addend)
        {
            return new Money(_amount + addend._amount, _currency);
        }
    }
}
