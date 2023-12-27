using ARM_MedRegistrar.Model.Formatter;
using ARM_MedRegistrar.Model.Identifications;
using ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Persons.Doctors
{
    public interface IDoctorDataOfAppointment : IFormatter, IIdentification
    {
        public IPersonalData PersonalData { get; set; }
        public string Specialization { get; set; }
        public int PlotNumber { get; set; }
        public int Cabinet { get; set; }

        public TimeOnly DurationOfAppointment { get; set; }
    }
}
