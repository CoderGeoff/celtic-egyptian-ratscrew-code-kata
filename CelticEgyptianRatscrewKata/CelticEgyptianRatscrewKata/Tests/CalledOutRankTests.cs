﻿using CelticEgyptianRatscrewKata.Game;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    class CalledOutRankTests
    {
        [Test]
        public void GetRank_ReturnsAce_WhenCalledForTheFirstTime()
        {
            // GIVEN 
            var calledOutRank = new CalledOutRank();

            // WHEN
            var actualRank = calledOutRank.GetRank();

            // THEN
            Assert.That(actualRank, Is.EqualTo(Rank.Ace));
        }

        [Test]
        public void GetRankReturnsTwo_WhenNextTurnCalledOnce()
        {
            // GIVEN 
            var calledOutRank = new CalledOutRank();

            // WHEN
            calledOutRank.NextTurn();

            // THEN
            Assert.That(calledOutRank.GetRank(), Is.EqualTo(Rank.Two));
            
        }
    }
}
