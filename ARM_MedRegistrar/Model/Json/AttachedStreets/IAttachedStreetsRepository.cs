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
        
        public abstract void Add(IAttachedStreets element);
        public abstract void Remove(IAttachedStreets element);
        public abstract IDictionary<int, IAttachedStreets>? GetAll();
    }
}
