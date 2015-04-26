using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly;
using NUnit.Framework;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Monopoly.Players;
using Moq;
using MonopolyTests;
using Monopoly.TurnControl;
namespace Monopoly.Tests
{
    [TestFixture()]
    public class TurnArbiterTests : FixtureTestBase 
    {

        private List<IPlayerActor> GetPlayerList(List<string> players) {
            return players.Select(p=>new PlayerActor(p)).ToList<IPlayerActor>();
        }

        [Test()]
        [ExpectedException(typeof(WrongNumberOfPlayersException))]
        public void WhenArbiterIsConstructedWithTooFewPlayers_ThrowException()
        {
            
            var arbiter = fixture.Create<TurnArbiter>();
            
            arbiter.SetPlayers(GetPlayerList(new List<string>() {"Horse"}));
            
            
        }

        [Test()]
        [ExpectedException(typeof(WrongNumberOfPlayersException))]
        public void WhenArbiterIsConstructedWithTooManyPlayers_ThrowException()
        {
            var factory = fixture.Freeze<Mock<PlayerActorFactory>>();
            var arbiter = fixture.Create<TurnArbiter>();
            arbiter.SetPlayers(GetPlayerList(new List<string>() { "Horse", "Car", "Battleship", "Thimble", "Horseman", "Iron", "Shoe", "Dog", "Top Hat" }));
        }

        [Test]
        public void WhenArbiterIsConstructedTwoPlayers_DoNotThrowException()
        {
            var factory = fixture.Freeze<Mock<PlayerActorFactory>>();
            var arbiter = fixture.Create<TurnArbiter>();
                arbiter.SetPlayers(GetPlayerList(new List<string>() { "Horse", "Car" }));
        }

        [Test()]
        public void WhenArbiterIsConstructedWithEightPlayers_DoNotThrowException()
        {
            var factory = fixture.Freeze<Mock<PlayerActorFactory>>();
            var arbiter = fixture.Create<TurnArbiter>();
                arbiter.SetPlayers(GetPlayerList(new List<string>() { "Horse", "Car", "Thimble", "Horseman", "Iron", "Shoe", "Dog", "Top Hat" }));
        }

        [Test()]
        
        public void WhenArbiterIsConstructed_PlayerOrderIsRandomized()
        {
            var playerOrderer = fixture.Freeze<Mock<IPlayerOrderer<IPlayerActor>>>();
            

            string horse = "Horse";
            string car = "Car";
            bool first = false;
            var factory = fixture.Freeze<Mock<PlayerActorFactory>>();

            var arbiter = fixture.Create<TurnArbiter>();
            arbiter.SetPlayers(GetPlayerList(new List<string>(){ horse, car }));

            playerOrderer.Verify(m => m.Shuffle<IPlayerActor>(It.IsAny<List<IPlayerActor>>()));
            
        }




        
        
    }
}
