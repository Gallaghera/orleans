using System;
using System.Threading.Tasks;
using Orleans;
using Vylon.Achievement.Interfaces;

namespace Vylon.Achievement.Grains
{
    public class AchievementGrain : Grain<AchievementGrainState>, IAchievementGrain
    {
        public async Task NewAchievement(IAchievement achievement)
        {
            State.Id = this.GetPrimaryKey();
            State.Name = achievement.Name;
            State.Description = achievement.Description;
            State.Type = AchievementType.Incremental;
            State.Count = achievement.Count;
            //State.Action = GrainFactory.GetGrain<IActionGrain>()


        }
    }

    public class AchievementGrainState
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //Will need a badge image location. Blob storage, ImageGrain
        public AchievementType Type { get; set; }
        public IActionGrain Action { get; set; }
        public int Count { get; set; }
    }
}
