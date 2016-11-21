
namespace WyCash.Core
{
    // Note: Steps of refactoring are preserved and annotated below.
    // This illustrates the minimum steps needed to make the test pass first.
    // Then it shows how the class is modified to remove duplication, as well as dependency on test parameters - without breaking the test.
    public class Franc : Money
    { 
        public Franc(int amount)
        {
            _amount = amount;
        }

        // 1. Change Value Pattern to return 'Money'
        public override Money Times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }

       
    }
}
