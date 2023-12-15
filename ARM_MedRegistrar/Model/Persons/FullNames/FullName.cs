using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Persons
{
    
    public class FullName : IFullName
    {
        private string _surname;
        private string _name;
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
        public string? Patronymic { get ; set ; }


        public FullName(string surname, string name, string? patronymic) 
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
        }
    }
}
