using ARM_MedRegistrar.Model.Persons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Json.Repository
{
    public abstract class UserRepository : IBaseRepository<IUser>
    {
        protected IList<IUser>? _users = new List<IUser>();
        public abstract void Add(IUser element);


        public abstract IList<IUser>? GetAll();


        public abstract void Remove(IUser element);
    }
}
