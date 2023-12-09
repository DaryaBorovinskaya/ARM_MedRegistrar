using ARM_MedRegistrar.Model.Appointments;
using ARM_MedRegistrar.Model.Persons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Json.Repository
{
    public abstract class PatientRepository : IBaseRepository<IPatient>
    {
        protected IList<IPatient>? _patients = new List<IPatient>();
        public abstract void Add(IPatient element);


        public abstract IList<IPatient>? GetAll();


        public abstract void Remove(IPatient element);
    }
}
