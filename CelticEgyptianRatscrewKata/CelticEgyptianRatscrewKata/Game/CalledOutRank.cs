namespace CelticEgyptianRatscrewKata.Game
{
    class CalledOutRank
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
