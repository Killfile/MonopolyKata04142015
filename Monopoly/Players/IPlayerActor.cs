using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public interface IPlayerActor
    {
        void PlayTurn();
        
    }

    public class PlayerActor : IPlayerActor
    {
        private string playerName;

        public override string ToString()
        {
            return playerName;
        }

        public PlayerActor(string playerName)
        {
            this.playerName = playerName;
        }

        public void PlayTurn()
        {
            throw new NotImplementedException();
        }
    }
}
