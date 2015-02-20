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
            var consoleInputToCommandMap = new Dictionary<char, ICommand>();

            IEnumerable<PlayerInfo> playerInfos = userInterface.GetPlayerInfoFromUserLazily();
            SetUpPlayers(playerInfos, gameController, consoleInputToCommandMap);

            PlayGame(gameController, userInterface, consoleInputToCommandMap);
        }

        private static void PlayGame(GameController gameController, UserInterface userInterface,
            Dictionary<char, ICommand> consoleInputToCommandMap)
        {
            gameController.StartGame(GameFactory.CreateFullDeckOfCards());

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

        private static void SetUpPlayers(IEnumerable<PlayerInfo> playerInfos, GameController gameController,
            Dictionary<char, ICommand> consoleInputToCommandMap)
        {
            foreach (var playerInfo in playerInfos)
            {
                var player = new Player(playerInfo.PlayerName);

                gameController.AddPlayer(player);

                var attemptSnapCommand = new AttemptSnapCommand(player, gameController);
                var playCardCommand = new PlayCardCommand(player, gameController);

                consoleInputToCommandMap.Add(playerInfo.SnapKey, attemptSnapCommand);
                consoleInputToCommandMap.Add(playerInfo.PlayCardKey, playCardCommand);
            }
        }
    }
}
