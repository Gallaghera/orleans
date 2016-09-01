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
            Task NewUser(IUser user);

            Task<IUser> GetUserData();

            Task Did(IActionGrain action);

            Task SetGroup(IGroupGrain group);
        }


    public interface IUser
{
    string FirstName { get; set; }
    string LastName { get; set; }
    string Email { get; set; }
    string Password { get; set; }
    Group Group { get; set; }
    Dictionary<string, int> Stats { get; set; }
}

public struct User : IUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Group Group { get; set; }
    public Dictionary<string, int> Stats { get; set; }
}
}
