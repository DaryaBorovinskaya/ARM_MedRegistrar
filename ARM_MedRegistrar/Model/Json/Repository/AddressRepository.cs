using ARM_MedRegistrar.Model.Addresses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Json.Repository
{
    public abstract class AddressRepository : IBaseRepository<IAddress>
    {
        protected IList<IAddress>? _addresses;
        public abstract void Add(IAddress element);
        public abstract void Remove(IAddress element);
        public abstract IList<IAddress>? GetAll();
    }
}
