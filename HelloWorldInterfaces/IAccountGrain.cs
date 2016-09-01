using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vylon.Achievement.Interfaces
{
    public interface IAccountGrain : Orleans.IGrainWithGuidKey
    {
        Task New(IAccount account);

        Task AddUser(IUser user);

        Task AddAction(IAction action);
    }

    public interface IAccount
    {
        string Name { get; set; }
        Guid Token { get; set; }
        List<IGroup> Groups { get; set; }
        List<IAction> Actions { get; set; }
        IUser Admin { get; set; }
        List<IUser> Users { get; set; }
        AccountStatus Status { get; set; }
        DateTime Created { get; set; }
    }

    public enum AccountStatus
    {
        Setup,
        Trial,
        Active,
        Disabled,
        Canceled,    
    }

    public struct Account : IAccount
    {
        public string Name { get; set; }
        public Guid Token { get; set; }
        public List<IAction> Actions { get; set; }
        public List<IGroup> Groups { get; set; }
        public IUser Admin { get; set; }
        public List<IUser> Users { get; set; }
        public AccountStatus Status { get; set; }
        public DateTime Created { get; set; }

    }
}
