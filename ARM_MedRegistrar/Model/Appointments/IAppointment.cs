
using ARM_MedRegistrar.Model.Persons;

namespace ARM_MedRegistrar.Model.Appointments
{
    public interface IAppointment
    {
        public DateTime DateAndTime {  get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }

       
    }
}
