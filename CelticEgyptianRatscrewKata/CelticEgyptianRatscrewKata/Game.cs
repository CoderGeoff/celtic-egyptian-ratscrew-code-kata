using System.Collections.Generic;

namespace CelticEgyptianRatscrewKata
{
    public class Game
    {
        public Game(IEnumerable<Player> players)
        {
            throw new NoPlayerException();
        }
    }
}