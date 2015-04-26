using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Extensions;

namespace Monopoly.TurnControl
{
    class PlayerOrderer : IPlayerOrderer<IPlayerActor>
    {
        public void Shuffle<T>(List<IPlayerActor> players)
        {
             players.Shuffle<IPlayerActor>();
        }
    }
}
