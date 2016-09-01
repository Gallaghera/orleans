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
        public async Task New(IUser user)
        {
            State.FirstName = user.FirstName;
            State.LastName = user.LastName;
            State.Email = this.GetPrimaryKeyString();
            State.Stats = new Dictionary<IActionGrain, int>();
            State.Created = DateTime.Now;
            //await WriteStateAsync();
        }

        public Task<bool> Exists()
            => Task.FromResult(State.Email != null);
        


        //
        //        public async Task Did(IActionGrain action)
        //        {
        //            if (State.Actions.ContainsKey(action))
        //                State.Actions[action] += State.Actions[action];
        //            else
        //                State.Actions.Add(action, 1);
        //
        //            await WriteStateAsync();
        //        }
    }

    public class UserGrainState
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public Dictionary<IActionGrain, int> Stats { get; set; }
    }
}
