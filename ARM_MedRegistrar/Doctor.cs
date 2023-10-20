using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkTest
{
    //public enum Specialization
    //{
    //    Therapist,   //терапевт
    //    Surgeon,     //хирург
    //    Neurologist,  //невролог
    //    Otorhinolaryngologist,  //оториноларинголог
    //    Ophthalmologist,    //офтальмолог
    //    Traumatologist,    //травматолог
    //    ObstetricianGynecologist,  //акушер-гинеколог
    //    Urologist,      //уролог
    //    Infectiologist,   //инфекционист
    //    Oncologist,   //онколог
    //    Gastroenterologist,  //гастроэнтеролог
    //    Cardiologist,    //кардиолог
    //    Endocrinologist   //эндокринолог
    //};

    


    public class Doctor 
    {
        private string _surname;
        private string _name;
        //private string _patronymic;
        private string _specialization;  //специализация
        //private uint _plotNumber;  //номер участка 
        //private byte _cabinet; //номер кабинета 
        

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
        public string Specialization
        {
            get => _specialization;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Специализация не задана");

                _specialization = value;

            }
        }

        public uint PlotNumber { get; set; }

        public byte Cabinet { get; set; }

        public Doctor(string surname, string name, string patronymic, string specialization,
            uint plotNumber , byte cabinet)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Specialization = specialization;
            PlotNumber = plotNumber;
            Cabinet = cabinet;
        }

    }
}
