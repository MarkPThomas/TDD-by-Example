using System;
using System.Collections.Generic;

namespace WyCash.Core
{
    public class Bank
    {
        // 6. Storing the rates in the Bank object
        // Deviating from book by using Dictionary rather than HashTable in C# as it is a better implementation: http://stackoverflow.com/questions/301371/why-is-dictionary-preferred-over-hashtable
        private Dictionary<Pair, int> rates = new Dictionary<Pair, int>();

        public Money Reduce(IExpression source, string to)
        {
            //return source.Reduce(to);
            // 3. Alter Reduce to pass in bank as a parameter, since only Bank should know exchange rates.
            return source.Reduce(this, to);
        }

        // 4. Move rate calculation into Bank.
        public int Rate(string from, string to)
        {
            // 12. Add check for handling identical currencies
            if (from.Equals(to)) { return 1; }
            
            //return (from.Equals("CHF") && to.Equals("USD"))
            //    ? 2
            //    : 1;
            // 8. Then rates can be looked up when asked
            int rate = rates[new Pair(from, to)];
            return rate;
        }

        // 7. Set rates in Bank
        public void AddRate(string from, string to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }

        // 5. Since we assume the array equality test fails, we quickly create a real object for the key in testing.
        // No tests are being written for these because we are writing the code in the context of a refactoring.
        // If we get to the payoff of the refactoring and all of the tests run, then we expect the code to have been exercised.
        // Separate tests would be a good idea if the logic became the least complex.
        private class Pair
        {
            private string _from;
            private string _to;

            public Pair(string from, string to)
            {
                _from = from;
                _to = to;
            }

            public override bool Equals(object obj)
            {
                Pair pair = (Pair)obj;
                return _from.Equals(pair._from) && _to.Equals(pair._to);
            }

            public override int GetHashCode()
            {
                // This is a terrible hash value but has the advantage of being easy to implement to get running quickly.
                // Currency lookup will look like a linear search.
                // Later, when we get lots of currencies, we can do a more thorough job with real usage data.
                return 0;
            }
        }
    }
}
