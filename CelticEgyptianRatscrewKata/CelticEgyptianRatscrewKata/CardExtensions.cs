namespace CelticEgyptianRatscrewKata
{
    static internal class CardExtensions
    {
        public static bool HasSameRank(this Card card1, Card card2)
        {
            return card1.Rank == card2.Rank;
        }
    }
}