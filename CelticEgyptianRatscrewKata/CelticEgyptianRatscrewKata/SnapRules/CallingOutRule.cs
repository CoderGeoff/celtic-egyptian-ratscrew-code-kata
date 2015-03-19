using CelticEgyptianRatscrewKata.Game;

namespace CelticEgyptianRatscrewKata.SnapRules
{
    public class CallingOutRule : ISnapRule
    {
        private readonly ICalledOutRank m_CalledOutRank;

        public CallingOutRule(ICalledOutRank calledOutRank)
        {
            m_CalledOutRank = calledOutRank;
        }

        public bool IsSnapValid(Cards cardStack)
        {
            if (cardStack.HasCards)
            {
                return cardStack.CardAt(0).Rank == m_CalledOutRank.GetRank();
            }

            return false;
        }
    }
}