using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Persons
{
    public class Doctor : IDoctor
    {
        private IFullName _fullName;
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
        public string Specialization { get; }
        
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



        public Doctor(IFullName fullName, string specialization, int plotNumber, int cabinet) 
        {
            if (specialization == "" || specialization == " " || specialization == null)
                throw new ArgumentException("Специализация не задана");
            
            FullName = fullName;
            Specialization = specialization;
            PlotNumber = plotNumber;
            Cabinet = cabinet;
        }
    }
}
