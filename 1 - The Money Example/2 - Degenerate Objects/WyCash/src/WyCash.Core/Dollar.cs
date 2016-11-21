
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

        // Step 1: Change void to Dollar
        // VALUE PATTERN
        // The implementation below of the method returning a new object instead of changing the current object is an implementation of "Value Pattern".
        public Dollar Times(int multiplier)
        {
            // Step 1: Return null to make the function valid. Test fails since null is not expected.
            // Amount *= multiplier;
            // return null;

            // Step 2: Refactor to make this functional.
            return new Dollar(Amount * multiplier);
        }
    }
}
