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
        public async Task NewUser(IUser user)
        {
            State.FirstName = user.FirstName;
            State.LastName = user.LastName;
            State.Password = user.Password;
            State.Email = this.GetPrimaryKeyString();

            //await WriteStateAsync();
        }

        public async Task<IUser> GetUserData()
        {
            Dictionary<Task<string>, int> statsQuery = State.Stats.ToDictionary(async item => (await item.Key.GetActionData()).Name, item => item.Value);
            await Task.WhenAll(statsQuery.Keys);
            Dictionary<string, int> stats = statsQuery.ToDictionary(item => item.Key.Result, item => item.Value);

            IUser user = new User()
            {
                FirstName = State.FirstName,
                LastName = State.LastName,
                Email = State.Email,
                Stats = stats
            };

            return user;
        }

        public async Task Did(IActionGrain action)
        {
            if (State.Stats.ContainsKey(action))
                State.Stats[action] += State.Stats[action];
            else
                State.Stats.Add(action, 1);

            //await WriteStateAsync();
        }

        public async Task SetGroup(IGroupGrain group)
        {
            State.Group = group;
            //await WriteStateAsync();
        }
    }

    public class UserGrainState
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IGroupGrain Group { get; set; }
        public Dictionary<IActionGrain, int> Stats { get; private set; } = new Dictionary<IActionGrain, int>();
    }
}
