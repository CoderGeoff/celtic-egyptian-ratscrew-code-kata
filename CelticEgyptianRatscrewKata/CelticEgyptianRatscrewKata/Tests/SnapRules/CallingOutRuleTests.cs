using System.Collections.Generic;
using CelticEgyptianRatscrewKata.Game;
using CelticEgyptianRatscrewKata.SnapRules;
using NSubstitute;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests.SnapRules
{
    [TestFixture]
    public class CallingOutRuleTests
    {
        [Test]
        public void ReturnsFalseOnEmptyStack()
        {
            //ARRANGE
            var fakeCalledOutRank = Substitute.For<ICalledOutRank>();
            fakeCalledOutRank.GetRank().Returns(Rank.Ace);
            var rule = new CallingOutRule(fakeCalledOutRank);

            //ACT
            var result = rule.IsSnapValid(Cards.Empty());

            //ASSERT
            Assert.IsFalse(result);
        }

        [Test]
        public void WheRankOfCardOnTopOfStack_MatchesCalledOutRank_ReturnsTrue()
        {
            //ARRANGE
            var fakeCalledOutRank = Substitute.For<ICalledOutRank>();
            fakeCalledOutRank.GetRank().Returns(Rank.Ace);
            var rule = new CallingOutRule(fakeCalledOutRank);

            var cardStack = new Cards(new List<Card>
            {
                new Card(Suit.Clubs, Rank.Ace),
                new Card(Suit.Clubs, Rank.Two)
            });

            //ACT
            var result = rule.IsSnapValid(cardStack);

            //ASSERT
            Assert.IsTrue(result);
        }
    }
}