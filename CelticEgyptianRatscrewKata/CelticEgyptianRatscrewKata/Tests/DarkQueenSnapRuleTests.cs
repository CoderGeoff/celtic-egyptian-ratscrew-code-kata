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
            var containsSnap = rule.ContainsSnap(emptyStack);

            // THEN
            Assert.True(containsSnap);
        }
    }
}