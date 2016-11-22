using System;
using System.Collections.Generic;

namespace WyCash.Core
{
    public class Bank
    {
        private Dictionary<Pair, int> rates = new Dictionary<Pair, int>();

        public Money Reduce(IExpression source, string to)
        {
            return source.Reduce(this, to);
        }

        public int Rate(string from, string to)
        {
            if (from.Equals(to)) { return 1; }
            
            int rate = rates[new Pair(from, to)];
            return rate;
        }

        // 7. Set rates in Bank
        public void AddRate(string from, string to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }

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
