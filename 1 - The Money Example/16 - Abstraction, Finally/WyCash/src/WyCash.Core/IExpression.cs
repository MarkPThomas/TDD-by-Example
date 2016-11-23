using System;

namespace WyCash.Core
{
    public interface IExpression
    {
        Money Reduce(Bank bank, string to);
        IExpression Plus(IExpression addend);

        // 5. Move Times into interface
        IExpression Times(int multiplier);
    }
}
