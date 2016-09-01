using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orleans;
using Vylon.Achievement.Interfaces;

namespace Vylon.Achievement.Grains
{
    public class AccountGrain : Grain<AccountGrainState>, IAccountGrain
    {
        public async Task New(IAccount account)
        {
            State.Name = account.Name;
            State.Token = this.GetPrimaryKey();
            State.Status = AccountStatus.Setup;
            State.Admin = GrainFactory.GetGrain<IUserGrain>(account.Admin.Email);

            if (!await State.Admin.Exists())
                await State.Admin.New(account.Admin);

            //await WriteStateAsync();
        }

        public async Task AddUser(IUser user)
        {
            if (State.Users == null)
                State.Users = new List<IUserGrain>();

            IUserGrain userGrain = GrainFactory.GetGrain<IUserGrain>(user.Email);

            if (!await userGrain.Exists())
                await userGrain.New(user);

            if(State.Users.IndexOf(userGrain) == -1)
                State.Users.Add(userGrain);

            //await WriteStateAsync();
        }

        public async Task AddAction(IAction action)
        {
            if (State.Actions == null)
                State.Actions = new List<IActionGrain>();

            IActionGrain existingGrain = State.Actions.FirstOrDefault(actionGrain =>
            {
                string name;
                actionGrain.GetPrimaryKey(out name);
                return name == action.Name;
            });


            if (existingGrain == null)
            {
                IActionGrain actionGrain = GrainFactory.GetGrain<IActionGrain>(Guid.NewGuid(), action.Name, null);
                await actionGrain.New(action);
                State.Actions.Add(actionGrain);
                //await WriteStateAsync();
            }
        }
    }

    public class AccountGrainState
    {
        public string Name { get; set; }
        public Guid Token { get; set; }
        public List<IGroupGrain> Groups { get; set; }
        public List<IActionGrain> Actions { get; set; }
        public IUserGrain Admin { get; set; }
        public List<IUserGrain> Users { get; set; }
        public AccountStatus Status { get; set; }
        public DateTime Created { get; set; }
    }
}
