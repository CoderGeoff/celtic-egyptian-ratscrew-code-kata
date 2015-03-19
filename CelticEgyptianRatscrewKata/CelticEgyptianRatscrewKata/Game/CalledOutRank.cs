namespace CelticEgyptianRatscrewKata.Game
{
    public class CalledOutRank : ICalledOutRank
    {
        private Rank m_CurrentRank = Rank.Ace;

        public Rank GetRank()
        {
            return m_CurrentRank;
        }

        public void NextTurn()
        {
            m_CurrentRank = m_CurrentRank.Next();
        }
    }
}
