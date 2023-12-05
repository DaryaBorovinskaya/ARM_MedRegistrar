using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_MedRegistrar.Model.Addresses;
using Microsoft.VisualBasic.Logging;


namespace ARM_MedRegistrar.Model.Persons
{
    


    public class Patient : IPatient
    {
        private FullName _fullName;
        private Address _address;
        private int _plotNumber;  //номер участка
        private int _numbOfPatientCard; //номер амбулаторной карты
        private int _policySeries;
        private string _policyNumb;
        private BloodType _bloodType;
        private RhFactor _rhFactor;
        

        public FullName FullName
        {
            get => _fullName;
            set
            {
                if (value == null)
                    throw new ArgumentException("Попытка присвоить значение null полю ФИО");
                _fullName = value;
            }
        }
        public DateTime DateOfBirth { get; }
        public Address Address
        {
            get => _address;
            set
            {
                if (value == null)
                    throw new ArgumentException("Попытка присвоить значение null полю Адрес");
                _address = value;
            }
        }
        public int PlotNumber
        {
            get => _plotNumber;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Номер участка не может быть меньше или равным нулю");
                _plotNumber = value;
            }
        }
        public int NumbOfPatientCard
        {
            get => _numbOfPatientCard;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Номер амбулаторной карты не может быть меньше или равным нулю");
                _numbOfPatientCard = value;
            }
        }

        public int PolicySeries
        {
            get => _policySeries;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Серия мед. полиса не может быть меньше или равной нулю");
                _policySeries = value;
            }
        }

        public string PolicyNumb
        {
            get => _policyNumb;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Номер мед. полиса не задан");
                if (value[0] == '-' || value[0] == '0')
                    throw new ArgumentException("Номер мед. полиса не может быть меньше или равным нулю");
                
                foreach (var item in value)
                    if (value[item] < 48 || value[item] > 57)
                        throw new ArgumentException("Номер мед. полиса должен состоять только из цифр");

                _policyNumb = value;
            }
        }
        public BloodType BloodType
        {
            get => _bloodType;
            set
            {
                if (!Enum.IsDefined(typeof(BloodType), value))
                    throw new ArgumentOutOfRangeException(nameof(BloodType));

                _bloodType = value;

            }
        }

        public RhFactor RhFactor
        {
            get => _rhFactor;
            set
            {
                if (!Enum.IsDefined(typeof(RhFactor), value))
                    throw new ArgumentOutOfRangeException(nameof(RhFactor));

                _rhFactor = value;

            }
        }

        public string? Allergies { get; set; }
        public Patient(FullName fullName, DateTime dateOfBirth, Address address, int plotNumber, int numbOfPatientCard, int policySeries, string policyNumb, BloodType bloodType, RhFactor rhFactor, string? allergies) 
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Address = address;
            PlotNumber = plotNumber;
            NumbOfPatientCard = numbOfPatientCard;
            PolicySeries = policySeries;
            PolicyNumb = policyNumb;
            BloodType = bloodType;
            RhFactor = rhFactor;
            Allergies = allergies;
        }
    }
}
