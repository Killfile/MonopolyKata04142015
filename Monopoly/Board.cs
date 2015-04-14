using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Board
    {
        private List<Space> _spaces;

        public Board(List<Space> spaces)
        {
            _spaces = spaces;
        }

        public Space Advance(Space startingPosition, int spacesMoved)
        {
            var startingIndex = _spaces.IndexOf(startingPosition);
            return _spaces[(startingIndex + spacesMoved % _spaces.Count)];
        }
    }
}
