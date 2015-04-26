using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly;
using NUnit.Framework;
using MonopolyTests;
using Moq;
using Monopoly.Players;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Monopoly.Games;
using Moq.Sequences;
using Monopoly.TurnControl;

namespace Monopoly.Tests
{
    [TestFixture()]
    public class GameTests : FixtureTestBase 
    {
        private Mock<PlayerActorFactory> playerActorMoqFactory;
        private Mock<IPlayerOrderer<IPlayerActor>> playerOrderer;
        


        [SetUp]
        public void SetUp()
        {
            playerActorMoqFactory = fixture.Freeze<Mock<PlayerActorFactory>>();
            playerOrderer = new Mock<IPlayerOrderer<IPlayerActor>>();
            fixture.Freeze(playerOrderer);

        }

        [Test()]
        public void WhenRoundsArePlayed_PlayerOrderRemainsConstant()
        {
            TurnArbiter arbiter = new TurnArbiter(playerOrderer.Object);
            

            Mock<IPlayerActor> p1 = new Mock<IPlayerActor>();
            Mock<IPlayerActor> p2 = new Mock<IPlayerActor>();
            List<IPlayerActor> actors = new List<IPlayerActor>()
            {
                p1.Object, p2.Object
            };
            arbiter.SetPlayers(actors);
            Game game = new Game(20, arbiter);
            using (Sequence.Create()) {

                using (Sequence.Loop(Times.Exactly(20)))
                {
                    p1.Setup(_ => _.PlayTurn()).InSequence();
                    p2.Setup(_ => _.PlayTurn()).InSequence();
                }
                game.Play();       
            }  
            
        }
    }
}
