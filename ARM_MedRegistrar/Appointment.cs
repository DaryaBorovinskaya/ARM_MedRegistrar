using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkTest
{
    public class Appointment   //запись на приём
    {
        private string _dateAndTime; //дата и время приёма
        //private Patient _patient;
        //private Doctor _doctor;
        //private byte _cabinetAppointment;      //номер кабинета, в котором проводится приём


        public string DateAndTime 
        { 
            get => _dateAndTime; set
                {
                    if (value == "" || value == " " || value == null)
                        throw new ArgumentException("Дата и время не заданы");
                _dateAndTime = value;
            }
        }

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public byte CabinetAppointment { get; set; }


        public Appointment(string dateAndTime, Patient patient, Doctor doctor, byte cabinetAppointment)
        {
            DateAndTime = dateAndTime;
            Patient = patient;
            Doctor = doctor;
            CabinetAppointment = cabinetAppointment;
            
        }
    }
}
