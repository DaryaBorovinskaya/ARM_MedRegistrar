using ARM_MedRegistrar.Model.Persons.Doctors;
using ARM_MedRegistrar.Model.Formatter;
using ARM_MedRegistrar.Model.Identifications;
using ARM_MedRegistrar.Model.Persons.Patients;

namespace ARM_MedRegistrar.Model.Appointments
{
    public interface IAppointment : IIdentification, IFormatter
    {
        public DateTime DateAndTime {  get; set; }
        public IPatient Patient { get; set; }
        public IDoctor Doctor { get; set; }

        public string Place {  get; set; }   //место, где будет приём врача - дома или в кабинете
    }
}
