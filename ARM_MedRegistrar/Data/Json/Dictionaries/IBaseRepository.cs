using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.Appointments;
using ARM_MedRegistrar.Model.Persons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Data.Json.Dictionaries
{
    public interface IBaseRepository<T, U> where U : class
    {

        public void Add(U value);
        public SortedDictionary<T, U>? GetAll();
        public void Remove(T key);



    }
}
