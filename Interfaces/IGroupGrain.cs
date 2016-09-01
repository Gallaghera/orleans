using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Vylon.Achievement.Interfaces
{
    public interface IGroupGrain : Orleans.IGrainWithGuidKey
    {
        Task AddUser(IUserGrain user);
        //Task RemoveUser(IUserGrain user);
        //Task<List<IUserGrain>> ListUsers();

        //Task NewAction(Action action);

        Task NewGroup(IGroup group, IUser admin);
        Task<Guid> NewToken();

    }

    public interface IGroup
    {
        Guid Id { get; set; }
        string Name { get; set; }
        Guid Token { get; set; }
        IUser Admin { get; set; }
        List<IUser> Users { get; set; }
        List<IAction> Actions { get; set; }
        //achievements
    }

    public struct Group : IGroup
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid Token { get; set; }
        public IUser Admin { get; set; }
        public List<IUser> Users { get; set; }
        public List<IAction> Actions { get; set; }
    }
}
