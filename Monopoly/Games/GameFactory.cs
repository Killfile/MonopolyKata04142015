using Monopoly.Players;
using Monopoly.TurnControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Games
{
    public class GameFactory
    {
        private PlayerActorFactory _playerActorFactory;
        private IPlayerOrderer<IPlayerActor> _playerOrderer;

        public GameFactory(PlayerActorFactory playerActorFactory, IPlayerOrderer<IPlayerActor> orderer)
        {
            _playerActorFactory = playerActorFactory;
        }

        public Game BuildGame(int rounds, List<String> players)
        {
            List<IPlayerActor> actors = players.Select(p => _playerActorFactory.CreateActor(p)).ToList();
            var arbiter = new TurnArbiter(_playerOrderer);
            arbiter.SetPlayers(actors);
            return new Game(rounds, arbiter);
        }
    }
}
