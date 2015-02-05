using System.Linq;

namespace CelticEgyptianRatscrewKata.Rules
{
    public sealed class StandardSnapRule : IRule
    {
        public bool ContainsSnap(Stack stack)
        {
            var cards = stack.ToList();
            return cards.AnyCorrespondingCardsInTwoStacksWhere(cards.Skip(1), t => t.Item1.HasSameRank(t.Item2));
        }
    }
}