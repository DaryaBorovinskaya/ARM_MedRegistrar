using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans
{
    public class PersonalData :IPersonalData
    {
        private IFullName _fullName;
        private string _phoneNumber;

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
            get => _phoneNumber;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Номер телефона не задан");
                if (value[0] == '0')
                    throw new ArgumentException("Номер телефона не может начинаться с нуля");

                _phoneNumber = value;
            }
        }

        public PersonalData(IFullName fullName, string phoneNumber) 
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }


        public string Format()
        {
            return FullName.Format() +  $"Номер телефона: {PhoneNumber}\n";
        }
    }
}
