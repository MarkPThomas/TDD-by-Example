using System;

namespace WyCash.Core
{
    public interface IExpression
    {
        Money Reduce(Bank bank, string to);

        // 6. Move Plus into the interface
        IExpression Plus(IExpression addend);
    }
}
