using ARM_MedRegistrar.Model.Appointments;
using ARM_MedRegistrar.Model.Persons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Json.PatientRepository
{
    public interface IPatientRepository
    {
        
        public void Add(IPatient element);


        public IDictionary<int, IPatient>? GetAll();


        public void Remove(IPatient element);
    }
}
