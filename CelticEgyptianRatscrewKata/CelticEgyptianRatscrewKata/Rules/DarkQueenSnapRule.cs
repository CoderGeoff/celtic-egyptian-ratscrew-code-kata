using System.Linq;

namespace CelticEgyptianRatscrewKata.Rules
{
    public sealed class DarkQueenSnapRule : IRule
    {
        public bool ContainsSnap(Stack stack)
        {
            return new Card(Suit.Spades, Rank.Queen).Equals(stack.FirstOrDefault());
        }
    }
}