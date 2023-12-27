using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.View.ChangeDataOfAppointment
{
    public interface IChangeDataOfAppointmentForm
    {
        public uint AppointmentId { get; }

        public DateOnly DateOfAppointment { get; set; }
        public string FreeTimeOfAppointment { get; set; }
        public IList<string> SetFreeTimeOfAppointments { set; }
        
        public uint DoctorId { get; set; }
        public string DoctorFullName { set; }
        public uint PatientId { set; }
        public string PatientFullName { set; }
        public string TypeOfAppointment { get; set; }
        public string Place { get; set; }
    }
}
