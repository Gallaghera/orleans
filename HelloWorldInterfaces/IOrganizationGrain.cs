
using System.Collections.Generic;
using System.Threading.Tasks;
using Vylon.Achievement.Interfaces;

namespace HelloWorld.Interfaces
{
    public interface IOrganizationGrain : Orleans.IGrainWithGuidKey
    {
        Task AddUser(IUserGrain user);
        Task RemoveUser(IUserGrain user);
        Task<List<IUserGrain>> ListUsers();

        Task AddAction(IActionGrain action);
        Task RemoveAction(IActionGrain action);
        Task<List<IActionGrain>> ListActions();

        Task AddAchievement(IAchievementGrain achievement);
        Task RemoveAchievement(IAchievementGrain achievement);
        Task<List<IAchievementGrain>> ListAchievements();
    }
}
