using CourseworkTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar
{
    public class CallingAtHome    //приём на дому
    {
        private string _dateAndTime; //дата и время приёма на дому
          
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
        public Address Address { get; set; }     


        public CallingAtHome(string dateAndTime, Patient patient, Doctor doctor, Address аddress)
        {
            DateAndTime = dateAndTime;
            Patient = patient;
            Doctor = doctor;
            Address = аddress;

        }
    }
}
