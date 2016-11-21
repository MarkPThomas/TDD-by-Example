
namespace WyCash.Core
{
    // 3. Make class concrete to allow use in Times method.
    //public abstract class Money
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

            // 7. Improve equals to check that currencies are the same, rather than class
            //return _amount == money._amount && 
            //       GetType().Equals(money.GetType());
            return _amount == money._amount &&
                    Currency().Equals(money.Currency());
        }

        // 4. Override ToString for better debugging
        public override string ToString()
        {
            return _amount + " " + _currency;
        }

        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Franc Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        // 4. Make method concrete to allow use in Times method.
        //public abstract Money Times(int multiplier);
        public virtual Money Times(int multiplier)
        {
            // 9. Push Times up into base class
            //return null;
            return new Money(_amount * multiplier, _currency);
        }

        public string Currency()
        {
            return _currency;
        }

    }
}
