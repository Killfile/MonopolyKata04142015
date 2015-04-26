using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Extensions;
using Monopoly.Players;
using Monopoly.TurnControl;

namespace Monopoly
{
    public class TurnArbiter : IEnumerable<IPlayerActor>
    {
        private List<IPlayerActor> _players;
        private IPlayerOrderer<IPlayerActor> _orderer;

        public TurnArbiter(IPlayerOrderer<IPlayerActor> orderer)
        {
            _players = new List<IPlayerActor>();
            _orderer = orderer;
        }

        public void SetPlayers(IEnumerable<IPlayerActor> players) {
            if (players.Count<IPlayerActor>() < 2 || players.Count<IPlayerActor>() > 8)
                            throw new WrongNumberOfPlayersException();
            _players.AddRange(players);
            _orderer.Shuffle<IPlayerActor>(_players);
        }


        public IEnumerator<IPlayerActor> GetEnumerator()
        {
            return _players.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _players.GetEnumerator();
        }
    }
}
