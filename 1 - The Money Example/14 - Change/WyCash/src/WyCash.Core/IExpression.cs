using System;

namespace WyCash.Core
{
    public interface IExpression
    {
        // 3. Alter Reduce to pass in bank as a parameter, since only Bank should know exchange rates.
        //Money Reduce(string to);
        Money Reduce(Bank bank, string to);
    }
}
