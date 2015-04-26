using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Game
    {
        int _rounds;
        private TurnArbiter _arbiter;

        public Game(int rounds, TurnArbiter arbiter)
        {
            _arbiter = arbiter;
            _rounds = rounds;

        }

        public void Play()
        {
            for (int i = 0; i < _rounds; i++)
            {
                foreach (IPlayerActor player in _arbiter)
                {
                    player.PlayTurn();
                }
            }
        }

        private void PlayTurn(string player)
        {
            
        }
    }
}
