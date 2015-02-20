using System.Collections.Generic;
using CelticEgyptianRatscrewKata.Game;
using ConsoleBasedGame.Commands;

namespace ConsoleBasedGame
{
    public class ConsoleInputToCommandMap
    {
        private static Dictionary<char, ICommand> _consoleInputToCommandMap;

        public ConsoleInputToCommandMap()
        {
            _consoleInputToCommandMap = new Dictionary<char, ICommand>();
        }

        public ICommand GetCommand(char userInput)
        {
            ICommand command;
            _consoleInputToCommandMap.TryGetValue(userInput, out command);
            return command ?? new NullCommand();
        }

        public static void CreateCommands(GameController gameController, Player player, PlayerInfo playerInfo)
        {
            var attemptSnapCommand = new AttemptSnapCommand(player, gameController);
            var playCardCommand = new PlayCardCommand(player, gameController);

            _consoleInputToCommandMap.Add(playerInfo.SnapKey, attemptSnapCommand);
            _consoleInputToCommandMap.Add(playerInfo.PlayCardKey, playCardCommand);
        }
    }
}