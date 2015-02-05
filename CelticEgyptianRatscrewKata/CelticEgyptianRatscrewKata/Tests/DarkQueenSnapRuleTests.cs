using System.Linq;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class DarkQueenSnapRuleTests
    {
        [Test]
        public void ContainsSnap_IfGivenAnEmptyStack_ReturnsFalse()
        {
            // GIVEN
            var rule = new DarkQueenSnapRule();

            // WHEN
            var emptyStack = new Stack(Enumerable.Empty<Card>());
            var containsSnap = rule.ContainsSnap(emptyStack);

            // THEN
            Assert.False(containsSnap);
        }

        [Test]
        public void ContainsSnap_IfGivenAStackWithQueenOfSpadesOnTop_ReturnsTrue()
        {
            // GIVEN
            var rule = new DarkQueenSnapRule();

            // WHEN
            var queenOfSpadesOnTopStack = new Stack(new[]{new Card(Suit.Spades, Rank.Queen), });
            var containsSnap = rule.ContainsSnap(queenOfSpadesOnTopStack);

            // THEN
            Assert.True(containsSnap);
        }

        [Test]
        public void ContainsSnap_IfGivenAStackWithQueenOfSpadesInMiddle_ReturnsFalse()
        {
            // GIVEN
            var rule = new DarkQueenSnapRule();

            // WHEN
            var stack = new Stack(new[]
            {
                new Card(Suit.Spades, Rank.Ace), 
                new Card(Suit.Spades, Rank.Queen), 
                new Card(Suit.Spades, Rank.Two)
            });
            var containsSnap = rule.ContainsSnap(stack);

            // THEN
            Assert.False(containsSnap);
        }
    }
}