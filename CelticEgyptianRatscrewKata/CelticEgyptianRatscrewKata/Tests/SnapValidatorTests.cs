using System;
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
            var validator = new SnapValidator();

            // WHEN
            var stack = new Stack(Enumerable.Empty<Card>());
            bool canSnap = validator.CanSnap(stack);

            // THEN
            Assert.False(canSnap);

        }
    }
}