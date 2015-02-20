using System.Collections.Generic;
using CelticEgyptianRatscrewKata.Game;

namespace ConsoleBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController gameController = new GameFactory().Create();

            var userInterface = new UserInterface();
            IEnumerable<PlayerInfo> playerInfos = userInterface.GetPlayerInfoFromUserLazily();

            IDictionary<char, ICommand> consoleInputToCommandMap = new Dictionary<char, ICommand>();

            foreach (PlayerInfo playerInfo in playerInfos)
            {
                var player = new Player(playerInfo.PlayerName);
                
                gameController.AddPlayer(player);

                var attemptSnapCommand = new AttemptSnapCommand(player, gameController);
                var playCardCommand = new PlayCardCommand(player, gameController);

                consoleInputToCommandMap.Add(playerInfo.SnapKey, attemptSnapCommand);
                consoleInputToCommandMap.Add(playerInfo.PlayCardKey, playCardCommand);
            }


            char userInput;
            while (userInterface.TryReadUserInput(out userInput))
            {
                ICommand command;
                consoleInputToCommandMap.TryGetValue(userInput, out command);

                if (command != null)
                {
                    command.Execute();
                }
            }
        }
    }

    internal class PlayCardCommand : ICommand
    {
        public PlayCardCommand(Player player, GameController game)
        {
        }

        public void Execute()
        {
        }
    }

    internal class AttemptSnapCommand : ICommand
    {
        public AttemptSnapCommand(Player player, GameController game)
        {
        }

        public void Execute()
        {
        }
    }

    public interface ICommand
    {
        void Execute();
    }
}
