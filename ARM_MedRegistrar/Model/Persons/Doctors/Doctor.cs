using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans;
using ARM_MedRegistrar.Model.WorkSchedules;

namespace ARM_MedRegistrar.Model.Persons.Doctors
{
    public class Doctor : IDoctor
    {
        private IPersonalData _personalData;
        private string _specialization;
        private int _plotNumber;  //номер участка
        private int _cabinet;



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

        public IList<IWorkSchedule> WorkSchedule { get; set; }
        
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

        public TimeOnly DurationOfAppointment { get; set; }

        public Doctor(uint id, IPersonalData personalData, IList<IWorkSchedule> workSchedule , string specialization, int plotNumber, int cabinet , TimeOnly durationOfAppointment)
        {
            Id = id;
            PersonalData = personalData;
            WorkSchedule = workSchedule;
            Specialization = specialization;
            PlotNumber = plotNumber;
            Cabinet = cabinet;

            durationOfAppointment = new TimeOnly(durationOfAppointment.Hour, durationOfAppointment.Minute,0);
            DurationOfAppointment = durationOfAppointment;

        }

        public string Format()
        {
            string _lineSchedule = "";
            foreach (IWorkSchedule workSchedule in WorkSchedule) 
                 _lineSchedule += workSchedule.Format();


            return $"ID: {Id}\n{PersonalData.Format()}Специализация: {Specialization}\nНомер участка: {PlotNumber}\n" +
                $"Номер кабинета: {Cabinet}\n\nГРАФИК РАБОТЫ\n\n{_lineSchedule}\nПродолжит. приёма: {DurationOfAppointment}";
        }
    }
}
