using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyCash.Core
{
    public interface IExpression
    {
        // 13. Add Reduce to interface
        Money Reduce(string to);
    }
}
