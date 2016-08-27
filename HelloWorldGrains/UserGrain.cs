using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vylon.Achievement.Interfaces;
using Orleans;
using System.Linq;

namespace Vylon.Achievement.Grains
{
    public class UserGrain : Grain<UserGrainState>, IUserGrain
    {

        public async Task Did(IActionGrain action)
        {
            if (State.Actions.ContainsKey(action))
                State.Actions[action] += State.Actions[action];
            else
                State.Actions.Add(action, 1);

            await WriteStateAsync();
        }
    }

    public class UserGrainState
    {
        public Dictionary<IActionGrain, int> Actions { get; private set; } = new Dictionary<IActionGrain, int>();
    }
}
