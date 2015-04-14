using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
        }
    }
}
