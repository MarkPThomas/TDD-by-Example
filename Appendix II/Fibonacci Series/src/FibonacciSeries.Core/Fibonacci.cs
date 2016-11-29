namespace FibonacciSeries.Core
{
    // Numbers indicate steps between passing tests.
    public class Fibonacci
    {
        public static int Calc(int value)
        {
            // 1
            //return 0;
            // 2
            if (value == 0) return 0;
            //return 1;
            // 3
            //if (value <= 2) return 1; // 5 - Remove this to tighten condition to below:
            if (value == 1) return 1;
            //return 1+1; // That first '1' is an example of Calc(n-1)
            // 4 - Changed to be more general.
            //return Calc(value - 1) + 1; // The second one is an example of Calc(n-2)
            return Calc(value - 1) + Calc(value - 2);
        }
    }
}
