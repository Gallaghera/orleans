
using System;
using System.Threading.Tasks;

namespace Vylon.Achievement.Interfaces
{
    public interface IActionGrain : Orleans.IGrainWithGuidCompoundKey
    {
        Task NewAction(IAction action);

        Task<IAction> GetActionData();
    }

    public interface IAction
    {
        string Name { get; set; }
        string Description { get; set; }
    }

    public struct Action : IAction
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
