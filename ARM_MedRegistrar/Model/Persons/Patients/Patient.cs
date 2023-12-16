﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.Persons;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json.Linq;


namespace ARM_MedRegistrar.Model.Patients
{



    public class Patient : IPatient
    {
        private IFullName _fullName;
        private IAddress _address;
        private int _plotNumber;  //номер участка
        private string _numbOfPatientCard; //номер амбулаторной карты
        private int _policySeries;
        private string _policyNumb;
        private string _documentSeries;
        private string _documentNumber;
        private string _bloodType;
        private string _rhFactor;


        public IFullName FullName
        {
            get => _fullName;
            set
            {
                if (value == null)
                    throw new ArgumentException("Попытка присвоить значение null полю ФИО");
                _fullName = value;
            }
        }
        public string DateOfBirth { get; }
        public IAddress Address
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
        public Patient(IFullName fullName, string dateOfBirth, IAddress address, int plotNumber, string numbOfPatientCard, int policySeries, string policyNumb, 
            string documentSeries, string documentNumber, string bloodType, string rhFactor, string? allergies)
        {
            if (dateOfBirth == "" || dateOfBirth == " " || dateOfBirth == null)
                throw new ArgumentException("Дата рождения не задана");

            FullName = fullName;
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


    }
}