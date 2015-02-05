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

        [Test]
        public void Constructor_GivenNullPlayers_ShouldThrow()
        {
            Assert.Throws<NoPlayerException>(() => new Game(null));
        }

        [Test]
        public void Constructor_GivenPlayers_ShouldNotThrow()
        {
            Assert.DoesNotThrow(() => new Game(new []{ new Player()}));
        }

    }
}