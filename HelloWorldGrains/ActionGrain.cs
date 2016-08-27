using System.Collections.Generic;
using System.Threading.Tasks;
using Orleans;
using Vylon.Achievement.Interfaces;

namespace HelloWorld.Grains
{
    public class ActionGrain : Grain<ActionGrainState>, IActionGrain
    {

    }

    public class ActionGrainState
    {

    }
}
