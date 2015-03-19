namespace CelticEgyptianRatscrewKata
{
    public enum Rank
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public static class RankExtensions
    {
        public static Rank Next(this Rank rank)
        {
            var newRank = rank + 1;
            return newRank > Rank.King ? Rank.Ace : newRank;
        }
    }
}