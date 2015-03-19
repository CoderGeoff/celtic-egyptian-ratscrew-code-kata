using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    class RankTests
    {
        [TestCase(Rank.Ace, Rank.Two)]
        [TestCase(Rank.King, Rank.Ace)]
        public void NextOnARank_ReturnsTheCorrectRank(Rank before, Rank after)
        {
            Assert.That(before.Next(), Is.EqualTo(after));
        }
    }
}
