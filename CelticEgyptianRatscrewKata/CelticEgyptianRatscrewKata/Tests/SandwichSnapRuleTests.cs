using System.Linq;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class SandwichSnapRuleTests
    {
        [Test]
        public void ContainsSnap_IfGivenAnEmptyStack_ReturnsFalse()
        {
            // GIVEN
            var rule = new SandwichSnapRule();

            // WHEN
            var emptyStack = new Stack(Enumerable.Empty<Card>());
            var containsSnap = rule.ContainsSnap(emptyStack);

            // THEN
            Assert.False(containsSnap);
        }
    }
}