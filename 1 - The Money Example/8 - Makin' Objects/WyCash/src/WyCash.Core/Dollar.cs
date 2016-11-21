
namespace WyCash.Core
{
    // Note: Steps of refactoring are preserved and annotated below.
    // This illustrates the minimum steps needed to make the test pass first.
    // Then it shows how the class is modified to remove duplication, as well as dependency on test parameters - without breaking the test.
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            _amount = amount;
        }

        // 1. Change Value Patternt to return 'Money'
        public override Money Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }
    }
}
