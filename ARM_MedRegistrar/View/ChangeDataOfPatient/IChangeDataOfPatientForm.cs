using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.View.ChangeDataOfPatient
{
    public interface IChangeDataOfPatientForm
    {
        public uint Id { get; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string? Patronymic { get; set; }
        public DateOnly DateOfBirth {  set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public int NumbOfHouse { get; set; }
        public int NumbOfFlat { get; set; }
        public int PlotNumber { get; set; }
        public string NumbOfPatientCard { get; set; }
        public int PolicySeries { get; set; }
        public string PolicyNumb { get; set; }
        public string DocumentSeries { get; set; }
        public string DocumentNumber { get; set; }
        public string BloodType { get; set; }
        public string RhFactor { get; set; }
        public string? Allergies { get; set; }
    }
}
