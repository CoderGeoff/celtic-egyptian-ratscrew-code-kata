using System.Collections.Generic;
using CelticEgyptianRatscrewKata.Game;
using ConsoleBasedGame.Commands;

namespace ConsoleBasedGame
{
    class Program
    {
        static void Main()
        {
            var gameController = new GameFactory().Create();
            var userInterface = new UserInterface();
            var consoleInputToCommandMap = new ConsoleInputToCommandMap();

            IEnumerable<PlayerInfo> playerInfos = userInterface.GetPlayerInfoFromUserLazily();
            SetUpPlayers(playerInfos, gameController);

            PlayGame(gameController, userInterface, consoleInputToCommandMap);
        }

        private static void PlayGame(GameController gameController, UserInterface userInterface, ConsoleInputToCommandMap consoleInputToCommandMap)
        {
            gameController.StartGame(GameFactory.CreateFullDeckOfCards());

            char userInput;
            while (userInterface.TryReadUserInput(out userInput))
            {
                ICommand command = consoleInputToCommandMap.GetCommand(userInput);
                command.Execute();
            }
        }

        private static void SetUpPlayers(IEnumerable<PlayerInfo> playerInfos, GameController gameController)
        {
            foreach (var playerInfo in playerInfos)
            {
                var player = new Player(playerInfo.PlayerName);

                gameController.AddPlayer(player);

                ConsoleInputToCommandMap.CreateCommands(gameController, player, playerInfo);
            }
        }
    }
}
