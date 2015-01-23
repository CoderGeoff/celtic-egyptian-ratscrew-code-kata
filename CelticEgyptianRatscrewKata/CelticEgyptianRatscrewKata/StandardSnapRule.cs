using System;
using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    public sealed class StandardSnapRule
    {
        public bool ContainsSnap(Stack stack)
        {
            var cards = stack.ToList();
            var everythingButTheFirstCard = stack.Skip(1).ToList();

            return cards.Zip(everythingButTheFirstCard, (c1, c2) => new Tuple<Card, Card>(c1, c2)).Any(t => t.Item1.HasSameRank(t.Item2));
        }
    }
}