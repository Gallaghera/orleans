using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Orleans;
using Vylon.Achievement.Interfaces;

namespace Vylon.Achievement.Grains
{
    public class GroupGrain : Grain<GroupGrainState>, IGroupGrain
    {
        public async Task NewGroup(IGroup group, IUser admin)
        {
            State.Id = this.GetPrimaryKey();
            State.Name = group.Name;
            State.Admin = GrainFactory.GetGrain<UserGrain>(admin.Email.ToLower());

            //This writes state so we don't need to here as long as this is the last action;
            await NewToken();
        }

        public async Task<Guid> NewToken()
        {
            State.Token = Guid.NewGuid();
            await WriteStateAsync();
            return State.Token;
        }

        public async Task AddUser(IUserGrain user)
        {
            await user.SetGroup(this);
            State.Users.Add(user);
            //await WriteStateAsync();
        }

        //public async Task RemoveUser(IUserGrain user)
        //{
        //    State.Users.Remove(user);
        //    await WriteStateAsync();
        //}

        //public Task<List<IUserGrain>> ListUsers()
        //    => Task.FromResult(State.Users);

        //public async Task NewAction(Action action)
        //{
        //    IActionGrain grain = GrainFactory.GetGrain<IActionGrain>(this.GetPrimaryKey(), action.Name, null);
        //    await grain.NewAction(action);
        //    State.Actions.Add(grain);
        //    await WriteStateAsync();
        //}
    }

    public class GroupGrainState
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid Token { get; set; }
        public IUserGrain Admin { get; set; }
        public List<IUserGrain> Users { get; private set; } = new List<IUserGrain>();
        public Dictionary<string, IActionGrain> Actions { get; private set; } = new Dictionary<string, IActionGrain>();
        public List<IAchievementGrain> Achievements { get; private set; } = new List<IAchievementGrain>();
    }
}
