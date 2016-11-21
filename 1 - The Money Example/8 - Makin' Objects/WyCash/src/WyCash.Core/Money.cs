
namespace WyCash.Core
{
    public abstract class Money
    {
        protected int _amount;


        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return _amount == money._amount && 
                   GetType().Equals(money.GetType());
        }

        // 2. Create a factory method to reduce direct references to the subclass
        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Franc Franc(int amount)
        {
            return new Franc(amount);
        }

        public abstract Money Times(int multiplier);
    }
}
