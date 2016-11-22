using System;

namespace WyCash.Core
{
    public interface IExpression
    {
        // 13. Add Reduce to interface
        Money Reduce(string to);
    }
}
