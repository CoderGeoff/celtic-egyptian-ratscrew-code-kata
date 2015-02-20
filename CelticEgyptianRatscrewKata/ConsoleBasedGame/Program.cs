using System.Collections.Generic;
using CelticEgyptianRatscrewKata.Game;
using ConsoleBasedGame.Commands;

namespace ConsoleBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameController = new GameFactory().Create();

            var userInterface = new UserInterface();
            IEnumerable<PlayerInfo> playerInfos = userInterface.GetPlayerInfoFromUserLazily();

            var consoleInputToCommandMap = new Dictionary<char, ICommand>();

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
}
