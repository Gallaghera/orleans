using System;
using System.Threading.Tasks;

namespace Vylon.Achievement.Interfaces
{
    public interface IAchievementGrain: Orleans.IGrainWithGuidKey
    {
        Task New(IAchievement achievement);
    }

    public interface IAchievement
    {
        string Name { get; set; }
        string Description { get; set; }
        int Count { get; set; }
        DateTime Created { get; set; }
    }

    public struct Achievement
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public DateTime Created { get; set; }
    }
}
