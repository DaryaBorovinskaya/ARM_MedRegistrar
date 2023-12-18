using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_MedRegistrar.Model.Persons;

namespace ARM_MedRegistrar.Model.Doctors
{
    public class Doctor : IDoctor
    {
        private IFullName _fullName;
        private string _phoneNumber;
        private string _specialization;
        private int _plotNumber;  //номер участка
        private int _cabinet;



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

        public string PhoneNumber
        {
            get => _phoneNumber; set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Номер телефона не задана");
                _phoneNumber = value;
            }
        }
        public string Specialization
        {
            get => _specialization; set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Специализация не задана");
                _specialization = value;
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

        public int Cabinet
        {
            get => _cabinet;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Номер кабинета не может быть меньше или равным нулю");
                _cabinet = value;
            }
        }


        public uint Id { get; }
        public Doctor(uint id, IFullName fullName, string phoneNumber, string specialization, int plotNumber, int cabinet)
        {
            Id = id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Specialization = specialization;
            PlotNumber = plotNumber;
            Cabinet = cabinet;
            
        }

       
    }
}
