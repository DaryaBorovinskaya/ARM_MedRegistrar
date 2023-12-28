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
        private IDoctorDataOfAppointment _doctorDataOfAppointment;
        private string _typeOfAppointment;
        private string _place;
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

        public IDoctorDataOfAppointment DoctorDataOfAppointment
        {
            get => _doctorDataOfAppointment;
            set
            {
                if (value == null)
                    throw new ArgumentException("Попытка присвоить значение null полю Доктор");
                _doctorDataOfAppointment = value;
            }
        }

        public string TypeOfAppointment
        {
            get => _typeOfAppointment;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentNullException(nameof(value));
                _typeOfAppointment = value;
            }
        }


        public string Place
        {
            get => _place;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Место приёма врача не задано");
                _place = value;
            }
        }
        public uint Id { get; }
        public Appointment(uint id, IPatient patient, IDoctorDataOfAppointment doctorDataOfAppointment, string typeOfAppointment, DateTime dateAndTime, string place)
        {
            Id = id;
            DateAndTime = dateAndTime.Date + new TimeSpan(dateAndTime.Hour,dateAndTime.Minute,0);
            Patient = patient;
            DoctorDataOfAppointment = doctorDataOfAppointment;
            TypeOfAppointment = typeOfAppointment;
            Place = place;
        }

        public string Format()
        {
            //return $"ID: {Id}\nДата и время: {DateAndTime}\nМесто приёма: {Place}\nТип записи: {TypeOfAppointment}" +
            //    $"\nID врача: {DoctorDataOfAppointment.Id}\nФамилия врача: {DoctorDataOfAppointment.PersonalData.FullName.Surname}\n" +
            //    $"Имя врача: {DoctorDataOfAppointment.PersonalData.FullName.Name}\nОтчество врача: {DoctorDataOfAppointment.PersonalData.FullName.Patronymic}\n" +
            //    $"\nID пациента: {Patient.Id}\nФамилия пациента: {Patient.PersonalData.FullName.Surname}\nИмя пациента: {Patient.PersonalData.FullName.Surname}\nОтчество пациента: {Patient.PersonalData.FullName.Surname}\n";

            return $"ID: {Id}\nДата и время: {DateAndTime}\nМесто приёма: {Place}\nТип записи: {TypeOfAppointment}" +
                $"\n\nДанные о враче\n\n{DoctorDataOfAppointment.Format()}\nДанные о пациенте\n\n{Patient.Format()}";
        }


        public static IList<string> SetTypeOfAppointment()
        {
            return new List<string> { "Первичный приём у врача", "Вторичный приём у врача", "Вызов на дом" };
        }
    }
}
