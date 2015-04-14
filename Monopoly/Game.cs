using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Extensions;

namespace Monopoly
{
    public class Game
    {
        private List<String> _players;

        public Game(List<String> players)
        {
            if (players.Count < 2 || players.Count > 8)
                throw new WrongNumberOfPlayersException();
            _players = players;
            _players.Shuffle<string>();
        }

        public string CurrentPlayer { get { return _players[0]; } }
    }
}
