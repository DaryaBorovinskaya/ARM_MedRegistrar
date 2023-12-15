
using ARM_MedRegistrar.Model.Doctors;
using ARM_MedRegistrar.Model.Patients;

namespace ARM_MedRegistrar.Model.Appointments
{
    public interface IAppointment
    {
        public DateTime DateAndTime {  get; set; }
        public IPatient Patient { get; set; }
        public IDoctor Doctor { get; set; }

       
    }
}
