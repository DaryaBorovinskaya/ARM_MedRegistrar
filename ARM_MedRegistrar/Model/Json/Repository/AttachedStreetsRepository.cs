using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.AttachedStreets;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Json.Repository
{
    public abstract class AttachedStreetsRepository : IBaseRepository<IAttachedStreets>
    {
        protected IList<IAttachedStreets>? _attachedStreets = new List<IAttachedStreets>();
        public abstract void Add(IAttachedStreets element);
        public abstract void Remove(IAttachedStreets element);
        public abstract IList<IAttachedStreets>? GetAll();
    }
}
