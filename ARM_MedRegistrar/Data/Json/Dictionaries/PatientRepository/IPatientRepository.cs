using ARM_MedRegistrar.Model.Appointments;
using ARM_MedRegistrar.Model.Patients;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Data.Json.Dictionaries.PatientRepository
{
    public interface IPatientRepository : IBaseRepository<uint, IPatient>, ICreateId
    {
               
    }
}
