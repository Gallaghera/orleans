using HelloWorld.Interfaces;
using Orleans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vylon.Achievement.Interfaces;

namespace HelloWorld.Grains
{
    public class OrganizationGrain : Grain<OrganizationGrainState>, IOrganizationGrain
    {
        public async Task AddAchievement(IAchievementGrain achievement)
        {
            State.Achievements.Add(achievement);
            await WriteStateAsync();
        }

        public async Task AddAction(IActionGrain action)
        {
            State.Actions.Add(action);
            await WriteStateAsync();
        }

        public async Task AddUser(IUserGrain user)
        {
            State.Users.Add(user);
            await WriteStateAsync();
        }

        public Task<List<IAchievementGrain>> ListAchievements()
            => Task.FromResult(State.Achievements);

        public Task<List<IActionGrain>> ListActions()
            => Task.FromResult(State.Actions);

        public Task<List<IUserGrain>> ListUsers()
            => Task.FromResult(State.Users);

        public async Task RemoveAchievement(IAchievementGrain achievement)
        {
            State.Achievements.Remove(achievement);
            await WriteStateAsync();
        }

        public async Task RemoveAction(IActionGrain action)
        {
            State.Actions.Remove(action);
            await WriteStateAsync();
        }

        public async Task RemoveUser(IUserGrain user)
        {
            State.Users.Remove(user);
            await WriteStateAsync();
        }
    }

    public class OrganizationGrainState
    {
        public List<IUserGrain> Users { get; private set; } = new List<IUserGrain>();
        public List<IActionGrain> Actions { get; private set; } = new List<IActionGrain>();
        public List<IAchievementGrain> Achievements { get; private set; } = new List<IAchievementGrain>();
    }
}
