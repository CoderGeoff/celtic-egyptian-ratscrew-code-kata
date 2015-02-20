using System.Collections.Generic;
using CelticEgyptianRatscrewKata.Game;

namespace ConsoleBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController game = new GameFactory().Create();

            var userInterface = new UserInterface();
            IEnumerable<PlayerInfo> playerInfos = userInterface.GetPlayerInfoFromUserLazily();

            IDictionary<char, IPerformAction> consoleInputToGameActionMap = new Dictionary<char, IPerformAction>();

            foreach (PlayerInfo playerInfo in playerInfos)
            {
                var player = new Player(playerInfo.PlayerName);
                
                game.AddPlayer(player);

                var performSnap = new PerformSnap(player, game);
                var playCard = new PlayCard(player, game);

                consoleInputToGameActionMap.Add(playerInfo.SnapKey, performSnap);
                consoleInputToGameActionMap.Add(playerInfo.PlayCardKey, playCard);
            }


            char userInput;
            while (userInterface.TryReadUserInput(out userInput))
            {
                IPerformAction action;
                consoleInputToGameActionMap.TryGetValue(userInput, out action);

                if (action != null)
                {
                    action.ExecuteAction();
                }
            }
        }
    }

    internal class PlayCard : IPerformAction
    {
        public PlayCard(Player player, GameController game)
        {
        }

        public void ExecuteAction()
        {
        }
    }

    internal class PerformSnap : IPerformAction
    {
        public PerformSnap(Player player, GameController game)
        {
        }

        public void ExecuteAction()
        {
        }
    }

    public interface IPerformAction
    {
        void ExecuteAction();
    }
}
