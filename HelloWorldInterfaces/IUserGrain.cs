using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Vylon.Achievement.Interfaces
{
    /// <summary>
    /// Orleans grain communication interface IUserGrain
    /// </summary>
    public interface IUserGrain : Orleans.IGrainWithStringKey
    {
        Task New(IUser user);

        Task<bool> Exists();
        //Task Did(IActionGrain action);
    }

    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        DateTime Created { get; set; }
        Dictionary<IAction, int> Stats { get; set; } 
    }

    public struct User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public Dictionary<IAction, int> Stats { get; set; }
    }
}
