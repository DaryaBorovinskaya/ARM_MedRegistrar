using ARM_MedRegistrar.Model.Addresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Persons
{
    public enum BloodType   //группа крови
    {
        Unknown,
        I,
        II,
        III,
        IV
    };

    public enum RhFactor   //резус-фактор
    {
        Unknown,    //неизвестно
        Positive,   //положительный
        Negative    //отрицательный
    };
    public interface IPatient
    {
        public FullName FullName { get; set; }
        public DateTime DateOfBirth { get;  }
        public Address Address { get; set; }
        public int PlotNumber { get; set; }
        public int NumbOfPatientCard {  get; set; }
        public int PolicySeries {  get; set; }
        public string PolicyNumb { get; set; }
        public BloodType BloodType { get; set; }
        public RhFactor RhFactor { get; set; }
        public string? Allergies { get; set; }

    }
}
