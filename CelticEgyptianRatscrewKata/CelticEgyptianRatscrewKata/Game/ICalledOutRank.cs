namespace CelticEgyptianRatscrewKata.Game
{
    public interface ICalledOutRank
    {
        Rank GetRank();
        void NextTurn();
    }
}