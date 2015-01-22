using System.Linq;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class StandardSnapRuleTests
    {
        [Test]
        public void ContainsSnap_IfGivenAnEmptyStack_ReturnsFalse()
        {
            // GIVEN
            var rule = new StandardSnapRule();

            // WHEN
            var emptyStack = new Stack(Enumerable.Empty<Card>());
            var containsSnap = rule.ContainsSnap(emptyStack);

            // THEN
            Assert.False(containsSnap);
        }
    }

    public sealed class StandardSnapRule
    {
        public bool ContainsSnap(Stack stack)
        {
            return true;
        }
    }
}