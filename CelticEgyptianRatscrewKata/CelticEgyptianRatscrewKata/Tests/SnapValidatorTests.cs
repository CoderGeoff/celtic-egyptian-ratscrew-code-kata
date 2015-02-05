using System.Linq;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class SnapValidatorTests
    {
        [Test]
        public void SnapValidator__GivenAnEmptyStack_ShouldReturnFalse()
        {
            // GIVEN
            var rules = new IRule[] { new SnapIsNeverValidRule() };
            var validator = new SnapValidator(rules);

            // WHEN
            var stack = new Stack(Enumerable.Empty<Card>());
            bool canSnap = validator.CanSnap(stack);

            // THEN
            Assert.False(canSnap);
        }

        [Test]
        public void SnapValidator__GivenANonEmptyStackAndAPassingRule_ShouldReturnTrue()
        {
            // GIVEN
            var rules = new IRule[] { new SnapIsNeverValidRule(), new SnapIsAlwaysValidRule() };
            var validator = new SnapValidator(rules);

            // WHEN
            var stack = new Stack(new []{new Card(Suit.Clubs, Rank.Ace) });
            var canSnap = validator.CanSnap(stack);

            // THEN
            Assert.True(canSnap);
        }

    }

    public class SnapIsNeverValidRule : IRule
    {
        public bool ContainsSnap(Stack stack)
        {
            return false;
        }
    }

    class SnapIsAlwaysValidRule : IRule
    {
        public bool ContainsSnap(Stack stack)
        {
            return true;
        }
    }
}