using CelticEgyptianRatscrewKata.GameSetup;
using CelticEgyptianRatscrewKata.SnapRules;

namespace CelticEgyptianRatscrewKata.Game
{
    public class RatscrewGameFactory : IGameFactory
    {
        public IGameController Create(ILog log)
        {
            var calledOutRank = new CalledOutRank();
            ISnapRule[] rules =
            {
                new DarkQueenSnapRule(),
                new SandwichSnapRule(),
                new StandardSnapRule(),
                new CallingOutRule(calledOutRank), 
            };

            var penalties = new Penalties();
            var loggedPenalties = new LoggedPenalties(penalties, log);
            var gameController = new GameController(new GameState(), new SnapValidator(rules), new Dealer(), new Shuffler(), loggedPenalties, new PlayerSequence(), calledOutRank);
            return new LoggedGameController(gameController, log);
        }
    }
}