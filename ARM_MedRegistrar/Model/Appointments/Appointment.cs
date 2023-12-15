using ARM_MedRegistrar.Model.Doctors;
using ARM_MedRegistrar.Model.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Appointments
{
    public class Appointment : IAppointment
    {
        private IPatient _patient;
        private IDoctor _doctor;
        public DateTime DateAndTime { get; set; }
        public IPatient Patient
        {
            get => _patient;
            set
            {
                if (value == null)
                    throw new ArgumentException("Попытка присвоить значение null полю Пациент");
                _patient = value;
            }
        }

        public IDoctor Doctor
        {
            get => _doctor;
            set
            {
                if (value == null)
                    throw new ArgumentException("Попытка присвоить значение null полю Доктор");
                _doctor = value;
            }
        }


        public Appointment(IPatient patient, IDoctor doctor, DateTime dateAndTime)
        {
            Patient = patient;
            Doctor = doctor;
            DateAndTime = dateAndTime;
        }

    }
}
