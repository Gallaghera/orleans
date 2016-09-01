using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Orleans;
using Vylon.Achievement.Interfaces;

namespace Vylon.Achievement.Grains
{
    public class GroupGrain : Grain<GroupGrainState>, IGroupGrain
    {
        public Task New(IGroup group)
        {
            throw new NotImplementedException();
        }
    }

    public class GroupGrainState
    {
        public List<IUserGrain> Users { get; private set; } = new List<IUserGrain>();
        public List<IActionGrain> Actions { get; private set; } = new List<IActionGrain>();
        public List<IAchievementGrain> Achievements { get; private set; } = new List<IAchievementGrain>();
    }
}
