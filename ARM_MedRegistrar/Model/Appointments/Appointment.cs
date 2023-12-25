using ARM_MedRegistrar.Model.Persons.Doctors;
using ARM_MedRegistrar.Model.Persons.Patients;
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
        private string _place;
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
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

        public string Place
        {
            get => _place;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Место приёма врача не задано");
            }
        }
        public uint Id { get; }
        public Appointment(uint id, IPatient patient, IDoctor doctor, DateTime date, DateTime time, string place)
        {
            Id = id;
            Date = date;
            Time = time;
            Patient = patient;
            Doctor = doctor;
            Place = place;
        }

        public string Format()
        {
            return $"ID: {Id}\nДата: {Date}\nВремя: {Time}\nМесто приёма: {Place} ";
        //    return "ID: " + Id + "\n" + Date + "\n : " + Time + "\n : " + Patient.FullName.Surname
        }
    }
}
