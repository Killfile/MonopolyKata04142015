using System.Collections.Generic;
namespace Monopoly.TurnControl
{
    public interface IPlayerOrderer<T>
    {
        void Shuffle<T>(List<IPlayerActor> players);
    }
}