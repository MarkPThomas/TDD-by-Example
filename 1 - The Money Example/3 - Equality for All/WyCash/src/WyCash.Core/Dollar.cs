using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyCash.Core
{
    // Note: Steps of refactoring are preserved and annotated below.
    // This illustrates the minimum steps needed to make the test pass first.
    // Then it shows how the class is modified to remove duplication, as well as dependency on test parameters - without breaking the test.
    public class Dollar 
    {
        public int Amount { get; private set; } 

        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            // 1. First step to make the test pass.
            //return true;

            // 2. Generalize equality based on triangulation tests
            Dollar dollar = (Dollar)obj;
            return Amount == dollar.Amount;
        }
    }
}
