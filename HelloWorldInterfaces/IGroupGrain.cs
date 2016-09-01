using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Vylon.Achievement.Interfaces
{
    public interface IGroupGrain : Orleans.IGrainWithGuidKey
    {
        Task New(IGroup group);


        //Task AddUser(IUserGrain user);
        //Task RemoveUser(IUserGrain user);
        //Task<List<IUserGrain>> ListUsers();

        //Task AddAction(IActionGrain action);
        //Task RemoveAction(IActionGrain action);
        //Task<List<IActionGrain>> ListActions();

        //Task AddAchievement(IAchievementGrain achievement);
        //Task RemoveAchievement(IAchievementGrain achievement);
        //Task<List<IAchievementGrain>> ListAchievements();
    }

    public interface IGroup
    {
        List<IUser> Users { get; set; }
        List<IAchievement> Achievements { get; set; }
        DateTime Created { get; set; }
    }

    public struct Group
    {
        public List<IUser> Users { get; set; }
        public List<IAchievement> Achievements { get; set; }
        public DateTime Created { get; set; }
    }
}
