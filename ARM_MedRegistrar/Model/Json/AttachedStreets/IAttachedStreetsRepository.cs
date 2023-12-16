using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.AttachedStreets;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Json.AttachedStreets
{
    public interface IAttachedStreetsRepository 
    {
        
        public abstract void Add(IAttachedStreets value);
        public abstract IList<IAttachedStreets>? GetAll();
        public abstract void Remove(IAttachedStreets value);
        
    }
}
