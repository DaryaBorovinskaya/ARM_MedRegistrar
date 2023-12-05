using ARM_MedRegistrar.Model.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Appointments
{
    public class Appointment : IAppointment
    {
        private Patient _patient;
        private Doctor _doctor;
        public DateTime DateAndTime { get; set; }
        public Patient Patient
        {
            get => _patient;
            set
            {
                if (value == null)
                    throw new ArgumentException("Попытка присвоить значение null полю Пациент");
                _patient = value;
            }
        }

        public Doctor Doctor
        {
            get => _doctor;
            set
            {
                if (value == null)
                    throw new ArgumentException("Попытка присвоить значение null полю Доктор");
                _doctor = value;
            }
        }


        public Appointment(Patient patient, Doctor doctor, DateTime dateAndTime)
        {
            Patient = patient;
            Doctor = doctor;
            DateAndTime = dateAndTime;
        }

    }
}
