using CelticEgyptianRatscrewKata.Game;

namespace ConsoleBasedGame.Commands
{
    internal class AttemptSnapCommand : ICommand
    {
        private readonly Player m_Player;
        private readonly GameController m_GameController;

        public AttemptSnapCommand(Player player, GameController gameController)
        {
            m_Player = player;
            m_GameController = gameController;
        }

        public void Execute()
        {
            m_GameController.AttemptSnap(m_Player);
        }
    }
}