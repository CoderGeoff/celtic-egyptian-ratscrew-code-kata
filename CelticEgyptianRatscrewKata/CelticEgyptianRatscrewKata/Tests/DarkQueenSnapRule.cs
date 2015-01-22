using System.Linq;

namespace CelticEgyptianRatscrewKata.Tests
{
    public sealed class DarkQueenSnapRule
    {
        public bool ContainsSnap(Stack stack)
        {
            if (!stack.Any())
            {
                return false;
            }

            return stack.First().Equals(new Card(Suit.Spades, Rank.Queen));
        }
    }
}