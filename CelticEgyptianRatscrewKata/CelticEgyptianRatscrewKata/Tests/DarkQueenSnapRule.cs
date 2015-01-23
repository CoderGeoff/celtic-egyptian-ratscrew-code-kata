using System.Linq;

namespace CelticEgyptianRatscrewKata.Tests
{
    public sealed class DarkQueenSnapRule : IRule
    {
        public bool ContainsSnap(Stack stack)
        {
            return new Card(Suit.Spades, Rank.Queen).Equals(stack.FirstOrDefault());
        }
    }
}