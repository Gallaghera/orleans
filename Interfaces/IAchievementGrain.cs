using System;
using System.Threading.Tasks;

namespace Vylon.Achievement.Interfaces
{
    public interface IAchievementGrain : Orleans.IGrainWithGuidKey
    {
        Task NewAchievement(IAchievement achievement);
    }

    public interface IAchievement
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        //badge or image location
        AchievementType Type { get; set; }
        string Action { get; set; }
        int Count { get; set; }
    }

    public struct Achievement
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //badge or image location
        public AchievementType Type { get; set; }
        public string Action { get; set; }
        public int Count { get; set; }
    }

    public enum AchievementType
    {
        Incremental,
        Collection,
        Timed
    }
}
