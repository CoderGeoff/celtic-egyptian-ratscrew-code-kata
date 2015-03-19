using CelticEgyptianRatscrewKata.SnapRules;
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
            var rule = new CallingOutRule();

            //ACT
            var result = rule.IsSnapValid(Cards.Empty());

            //ASSERT
            Assert.IsFalse(result);
        }
    }
}