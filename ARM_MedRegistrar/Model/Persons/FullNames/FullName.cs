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
                for (int i = 0; i < value.Length; i++)
                    if (value[i] == (int)Keys.Space)
                        throw new ArgumentException("Фамилия не должна содержать пробелы");
                _surname = value;
            }
        }


        public string Name 
        {
            get => _name; 
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Имя не задано");
                for (int i = 0; i < value.Length; i++)
                    if (value[i] == (int)Keys.Space)
                        throw new ArgumentException("Имя не должно содержать пробелы");
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

        public string Format()
        {
            return $"Фамилия: {Surname}\nИмя: {Name}\nОтчество: {Patronymic}\n";
        }
        public string FormatOneLine()
        {
            return $"{Surname} {Name} {Patronymic}";
        }
    }
}
