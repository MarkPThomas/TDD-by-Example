using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries.Core
{
    public class Fibonacci
    {
        public static int Calc(int value)
        {
            if (value == 0) return 0;
            if (value == 1) return 1;
            return Calc(value - 1) + Calc(value - 2);
        }
    }
}
