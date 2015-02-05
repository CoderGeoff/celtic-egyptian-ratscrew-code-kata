using System.Collections.Generic;
using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    public class Game
    {
        public Game(IEnumerable<Player> players)
        {
            if (players == null || !players.Any())
            {
                throw new NoPlayerException();
            }
        }
    }
}