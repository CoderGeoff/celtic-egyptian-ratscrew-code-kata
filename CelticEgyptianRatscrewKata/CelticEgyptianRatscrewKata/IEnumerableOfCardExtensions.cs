using System;
using System.Collections.Generic;
using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    static internal class IEnumerableOfCardExtensions
    {
        public static bool AnyCorrespondingCardsInTwoStacksWhere(this IEnumerable<Card> stack1, IEnumerable<Card> stack2,
            Func<Tuple<Card, Card>, bool> predicate)
        {
            return stack1.Zip(stack2, (c1, c2) => new Tuple<Card, Card>(c1, c2)).Any(predicate);
        }
    }
}