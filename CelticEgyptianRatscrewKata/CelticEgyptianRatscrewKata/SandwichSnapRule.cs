using System;
using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    public class SandwichSnapRule
    {
        public bool ContainsSnap(Stack stack)
        {
            var cards = stack.ToList();
            var everythingButTheFirstTwoCards = stack.Skip(2).ToList();

            return cards.Zip(everythingButTheFirstTwoCards, (c1, c2) => new Tuple<Card, Card>(c1, c2))
                        .Any(t => t.Item1.HasSameRank(t.Item2));
        }
    }
}