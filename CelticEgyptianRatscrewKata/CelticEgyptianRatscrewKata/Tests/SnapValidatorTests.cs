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
            var rules = new IRule[] {new StandardSnapRule(), new SandwichSnapRule(), new DarkQueenSnapRule()};
            var validator = new SnapValidator(rules);

            // WHEN
            var stack = new Stack(Enumerable.Empty<Card>());
            bool canSnap = validator.CanSnap(stack);

            // THEN
            Assert.False(canSnap);
        }
    }
}