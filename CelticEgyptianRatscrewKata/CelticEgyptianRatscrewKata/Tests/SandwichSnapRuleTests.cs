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

        [Test]
        public void ContainsSnap_IfGivenASandwichSnapStack_ReturnsTrue()
        {
            // GIVEN
            var rule = new SandwichSnapRule();

            // WHEN
            var stack = new Stack(new []
                                        {
                                            new Card(Suit.Clubs, Rank.Ace), 
                                            new Card(Suit.Clubs, Rank.Two), 
                                            new Card(Suit.Diamonds, Rank.Ace)
                                        });
            var containsSnap = rule.ContainsSnap(stack);

            // THEN
            Assert.True(containsSnap);
        }
    }
}