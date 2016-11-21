
namespace WyCash.Core
{
    public abstract class Money
    {
        protected int _amount;

        // 4. Push private field to base class
        protected string _currency;

        // 10. Push implementation by constructor to base class
        public Money(int amount, string currency)
        {
            _amount = amount;
            _currency = currency;
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return _amount == money._amount && 
                   GetType().Equals(money.GetType());
        }
        
        public static Dollar Dollar(int amount)
        {
            // 6. Fix changed constructor of the classes to include Currency
            //return new Dollar(amount, null);

            // 8. Bring currency specification into factory method
            return new Dollar(amount, "USD");
        }

        public static Franc Franc(int amount)
        {
            // 6. Fix changed constructor of the classes to include Currency
            //return new Franc(amount, null);

            // 8. Bring currency specification into factory method
            return new Franc(amount, "CHF");
        }

        public abstract Money Times(int multiplier);

        // 2. Create abstract currency method so program will compile
        //public abstract string Currency();
        // 3. Make method implementation explicit, pushing the method back to the base class.
        public string Currency()
        {
            return _currency;
        }

    }
}
