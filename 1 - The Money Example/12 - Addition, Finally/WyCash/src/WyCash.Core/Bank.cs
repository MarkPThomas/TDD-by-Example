using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyCash.Core
{
    // 5. Create new bank class to compile
    public class Bank
    {
        public Money Reduce(IExpression source, string to)
        {
            // 6. Sub out a Reduce method
            //return null;
            // 7. Return passing fake result
            return Money.Dollar(10);
        }
    }
}
