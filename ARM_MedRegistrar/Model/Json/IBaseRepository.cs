using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.Appointments;
using ARM_MedRegistrar.Model.Persons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Json
{
    public interface IBaseRepository<T,U> where U : class 
    {
        public void Add(T key, U value);
        public void Remove(T key);
        public IDictionary<T, U>? GetAll();
    }
}
