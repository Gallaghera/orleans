
using System;
using System.Threading.Tasks;

namespace Vylon.Achievement.Interfaces
{
    public interface IActionGrain : Orleans.IGrainWithGuidCompoundKey
    {
        Task New(IAction action);
    }

    public interface IAction
    {
        Guid Id { get; set; }
        string Name { get; set; }
        DateTime Created { get; set; }
    }

    public struct Action
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
    }
}
