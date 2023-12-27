using ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans;
using ARM_MedRegistrar.Model.WorkSchedules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Persons.Doctors
{
    public class DoctorDataOfAppointment : IDoctorDataOfAppointment
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

        public DoctorDataOfAppointment(uint id, IPersonalData personalData, string specialization, int plotNumber, int cabinet, TimeOnly durationOfAppointment)
        {
            Id = id;
            PersonalData = personalData;
            Specialization = specialization;
            PlotNumber = plotNumber;
            Cabinet = cabinet;

            durationOfAppointment = new TimeOnly(durationOfAppointment.Hour, durationOfAppointment.Minute, 0);
            DurationOfAppointment = durationOfAppointment;
        }


        public string Format()
        { 
            return $"ID: {Id}\n{PersonalData.Format()}Специализация: {Specialization}\nНомер участка: {PlotNumber}\n" +
                $"Номер кабинета: {Cabinet}\n\nПродолжит. приёма: {DurationOfAppointment}\n";
        }
    }
}
