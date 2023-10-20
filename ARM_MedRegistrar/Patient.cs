using ARM_MedRegistrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkTest
{
    

    public enum BloodType   //группа крови
    {
        I,
        II,
        III,
        IV
    };

    public enum RhFactor   //резус-фактор
    {
        Positive,   //положительный
        Negative    //отрицательный
    };


    public class Patient
    {
        private string _surname;
        private string _name;
        //private string? _patronymic;
        private string _dateOfBirth;
        //private uint _plotNumber = 1;  //номер участка
        //private uint _numbOfPatientCard; //номер амбулаторной карты
        private BloodType _bloodType;
        private RhFactor _rhFactor;
        //private string _allergies;   //аллергии

        
        public string Surname
        {
            get => _surname; set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Фамилия не задана");
                _surname = value;
            }
        }

        public string Name
        {
            get => _name; set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Имя не задано");
                _name = value;
            }
        }

        public string? Patronymic { get; set; }
        

        public string DateOfBirth
        {
            get => _dateOfBirth; set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Дата рождения не задана");
                _dateOfBirth = value;
            }
        }

        public uint PlotNumber { get; set; } 

        public uint NumbOfPatientCard { get; set; }

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

        public string? Allergies { get; set;}

        public Patient(string surname, string name, string? patronymic, string dateOfBirth, uint plotNumber,
            uint numbOfPatientCard, BloodType bloodType, RhFactor rhFactor, string allergies) 
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
            PlotNumber = plotNumber;
            NumbOfPatientCard = numbOfPatientCard;
            BloodType = bloodType;
            RhFactor = rhFactor;
            Allergies = allergies;
        }




        public class Address
        {
            string _city;
            string _region; //район
            string _street;
            //uint _numbOfHouse;
            //uint _numbOfFlat;

            public string City
            {
                get => _city; set
                {
                    if (value == "" || value == " " || value == null)
                        throw new ArgumentException("Город не задан");
                    _city = value;
                }
            }

            public string Region
            {
                get => _region; set
                {
                    if (value == "" || value == " " || value == null)
                        throw new ArgumentException("Район не задан");
                    _region = value;
                }
            }

            public string Street
            {
                get => _street; set
                {
                    if (value == "" || value == " " || value == null)
                        throw new ArgumentException("Улица не задана");
                    _street = value;
                }
            }

            public uint NumbOfHouse { get; set; }
            public uint NumbOfFlat { get; set; }


            public Address(string city, string region, string street, uint numbOfHouse, uint numbOfFlat)
            {
                City = city;
                Region = region;
                Street = street;
                NumbOfHouse = numbOfHouse;
                NumbOfFlat = numbOfFlat;
            }

        }

    }
}
