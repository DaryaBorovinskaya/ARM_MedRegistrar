using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.View.AddAppointment
{
    public interface IAddAppointmentForm
    {
        public uint DoctorId {  set; }
        public int DoctorCountOfLine { set; }
        public string DoctorSurname {  set; }
        public string DoctorName {  set; }
        public string? DoctorPatronymic { set; }
        public string DoctorSpecialization {  set; }
        public string DoctorWorkSchedule { set; }
        public int DoctorPlotNumber { set; }
        public int DoctorCabinet { set; }
        public uint DoctorSelectedId { get; }
        public string GetFreeTimeOfAppointment { get;  }
        public IList<string> SetFreeTimeOfAppointment { set; }
        public string InfoAboutDoctor { set; }


        public uint PatientId { set; }
        public string PatientSurname { get; set; }
        public string PatientName { get; set; }
        public string? PatientPatronymic { set; }
        public string PatientDateOfBirth { get; set; }
        
        public uint PatientSelectedId { get; }
        public int PatientCountOfLine { set; }


        public DateTime DayOfAppointment {  get; }

        public string GetTypeOfAppointment { get; }


        public string PlaceOfAppointment { get; set; }

        public string InfoAboutPatient {  set; }


    }
}
