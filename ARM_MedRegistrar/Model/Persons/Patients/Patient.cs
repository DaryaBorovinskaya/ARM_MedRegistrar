using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json.Linq;


namespace ARM_MedRegistrar.Model.Persons.Patients
{



    public class Patient : IPatient 
    {
        private IPersonalData _personalData;
        private IPatientAddress _address;
        private int _plotNumber;  //номер участка
        private string _numbOfPatientCard; //номер амбулаторной карты
        private int _policySeries;
        private string _policyNumb;
        private string _documentSeries;
        private string _documentNumber;
        private string _bloodType;
        private string _rhFactor;


        public IPersonalData PersonalData
        {
            get => _personalData;
            set
            {
                if (value == null)
                    throw new ArgumentException("Попытка присвоить значение null полю Персональные данные");
                _personalData = value;
            }
        }
        public DateOnly DateOfBirth { get; }
        public IPatientAddress Address
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
                    throw new ArgumentException("Номер участка не может быть меньше нуля или начинаться с него");
                _plotNumber = value;
            }
        }
        public string NumbOfPatientCard
        {
            get => _numbOfPatientCard;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Номер амбулаторной карты не задан");
                if (value[0] == '0')
                    throw new ArgumentException("Номер амбулаторной карты не может начинаться с нуля");

                _numbOfPatientCard = value;
            }
        }

        public int PolicySeries
        {
            get => _policySeries;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Серия мед. полиса не может быть меньше нуля или начинаться с него");
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
                if (value[0] == '0')
                    throw new ArgumentException("Номер мед. полиса не может начинаться с нуля");


                _policyNumb = value;
            }
        }
        public string DocumentSeries
        {
            get => _documentSeries;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Серия документа не задана");
                if (value[0] == '0')
                    throw new ArgumentException("Серия документа не может начинаться с нуля");


                _documentSeries = value;
            }
        }
        public string DocumentNumber
        {
            get => _documentNumber;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Номер документа не задан");
                if (value[0] == '0')
                    throw new ArgumentException("Номер документа не может начинаться с нуля");


                _documentNumber = value;
            }
        }
        public string BloodType
        {
            get => _bloodType;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Группа крови не задана");

                _bloodType = value;

            }
        }

        public string RhFactor
        {
            get => _rhFactor;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Резус-фактор не задан");

                _rhFactor = value;

            }
        }

        public string? Allergies { get; set; }
        public uint Id { get; }
        public Patient(uint id, IPersonalData personalData , DateOnly dateOfBirth, IPatientAddress address, int plotNumber, 
            string numbOfPatientCard, int policySeries, string policyNumb, 
            string documentSeries, string documentNumber, string bloodType, string rhFactor, string? allergies )
        {
            Id = id;
            PersonalData = personalData;
            DateOfBirth = dateOfBirth;
            Address = address;
            PlotNumber = plotNumber;
            NumbOfPatientCard = numbOfPatientCard;
            PolicySeries = policySeries;
            PolicyNumb = policyNumb;
            DocumentSeries = documentSeries;
            DocumentNumber = documentNumber;
            BloodType = bloodType;
            RhFactor = rhFactor;
            Allergies = allergies;
        }

        public string Format()
        {
            return $"ID: {Id}\n{PersonalData.Format()}Дата рождения: {DateOfBirth}\nСерия документа: {DocumentSeries}\nНомер документа: " +
                $"{DocumentNumber}\nНомер участка: {PlotNumber}\nНомер амбул. карты: { NumbOfPatientCard}\n{Address.Format()}" +
                $"Серия мед. полиса: {PolicySeries}\nНомер мед. полиса: {PolicyNumb}\nГруппа крови: { BloodType}\nРезус-фактор: { RhFactor}\nАллергии: { Allergies}";

        }
    }
}
