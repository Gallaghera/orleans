using System;
using System.Threading.Tasks;
using Orleans;
using Vylon.Achievement.Interfaces;

namespace Vylon.Achievement.Grains
{
    public class ActionGrain : Grain<ActionGrainState>, IActionGrain
    {
        public Task<IAction> GetActionData()
        {
            IAction action = new Interfaces.Action
            {
                Name = State.Name,
                Description = State.Description,
            };

            //if this returns the string key then we don't need the dictionary in group to handle searching for these
            //otherwise we will use the dictionary for easy string search.
            string t = "";
            var s = this.GetPrimaryKey(out t);
            return Task.FromResult(action);
        }

        public async Task NewAction(IAction action)
        {
            State.Name = action.Name;
            State.Description = action.Description;
            //await WriteStateAsync();
        }
    }

    public class ActionGrainState
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
