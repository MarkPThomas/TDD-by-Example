
namespace WyCash.Core
{
    public class Money
    {
        protected int _amount;


        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return _amount == money._amount && 
                   GetType().Equals(money.GetType());
        }
    }
}
