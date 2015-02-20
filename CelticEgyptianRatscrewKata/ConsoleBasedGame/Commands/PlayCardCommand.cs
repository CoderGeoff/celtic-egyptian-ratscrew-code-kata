using CelticEgyptianRatscrewKata.Game;

namespace ConsoleBasedGame.Commands
{
    internal class PlayCardCommand : ICommand
    {
        private readonly Player m_Player;
        private readonly GameController m_Game;

        public PlayCardCommand(Player player, GameController game)
        {
            m_Player = player;
            m_Game = game;
        }

        public void Execute()
        {
            m_Game.PlayCard(m_Player);
        }
    }
}