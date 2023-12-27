using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.View.MainWindow
{
    public interface IMainWindowForm
    {
        public uint PatientId { set; }
        public string PatientSurname { get; set; }
        public string PatientName { get; set; }
        public string? PatientPatronymic {  set; }
        public DateOnly PatientDateOfBirth { get; set; }
        public string PatientDocumentSeries {  set; }
        public string PatientDocumentNumber {  set; }
        public int PatientPlotNumber { set; }
        public string PatientNumbOfPatientCard { set; }
        public uint PatientSelectedId { get; }
        public int PatientCountOfLine { set; }

        public string InfoAboutPatient { set; }


        public uint AppointmentId { set; }
        public DateOnly DateOfAppointment { get; set; }
        public TimeOnly TimeOfAppointment { set; }
        public string PlaceOfAppointment {  set; }
        public string AppointmentDoctorSpecialization { set; }
        public string TypeOfAppointment { set; }


        public uint AppointmentDoctorId { set; }
        public string AppointmentDoctorSurname { set; }
        public string AppointmentDoctorName { set; }
        public string? AppointmentDoctorPatronymic { set; }


        public uint AppointmentPatientId { set; }
        public string AppointmentPatientSurname { set; }
        public string AppointmentPatientName { set; }
        public string? AppointmentPatientPatronymic { set; }
        
        public uint AppointmentSelectedId { get; }
        public int AppointmentCountOfLine { set; }

        public string InfoAboutAppointment { set; }

    }
}
