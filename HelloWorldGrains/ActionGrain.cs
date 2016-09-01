using System;
using System.Threading.Tasks;
using Orleans;
using Vylon.Achievement.Interfaces;

namespace Vylon.Achievement.Grains
{
    public class ActionGrain : Grain<ActionGrainState>, IActionGrain
    {
        public async Task New(IAction action)
        {
            string name;
            State.Id = this.GetPrimaryKey(out name);
            State.Name = name;
            State.Created = DateTime.Now;
            //await WriteStateAsync();
        }
    }

    public class ActionGrainState
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
    }
}
