using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_MedRegistrar.Model.Formatter;
using ARM_MedRegistrar.Model.Identifications;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans;
using ARM_MedRegistrar.Model.WorkSchedules;

namespace ARM_MedRegistrar.Model.Persons.Doctors
{
    public interface IDoctor: IFormatter
    {
        public IDoctorDataOfAppointment DoctorDataOfAppointment { get; set; }
        public IList<IWorkSchedule> WorkSchedule { get; set; }
       
    }
}
