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
        // Step 1: Set this constant to = 10;
        // Step 3: Remove the assignment.
        public int Amount { get; private set; } 

        public Dollar(int amount)
        {
            // Step 1: This is left empty.
            // Step 2: 
            Amount = amount;
        }

        public void Times(int multiplier)
        {
            // Step 1: This is left empty.
            // Step 3: This is changed to to reflect the test setup: 
            //  Amount = 5*2;
            // Step 4: 
            //  Amount = Amount * 2;
            // Step 5:
            Amount *= multiplier;
        }
    }
}
