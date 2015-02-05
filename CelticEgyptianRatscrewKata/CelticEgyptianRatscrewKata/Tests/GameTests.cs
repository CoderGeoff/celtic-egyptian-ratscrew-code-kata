using System.Linq;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class GameTests
    {
        [Test]
        public void Constructor_GivenNoPlayers_ShouldThrow()
        {
            Assert.Throws<NoPlayerException>(() => new Game(Enumerable.Empty<Player>()));
        }
    }
}