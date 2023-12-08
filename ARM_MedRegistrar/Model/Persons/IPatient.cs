using ARM_MedRegistrar.Model.Addresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Persons
{
    
    public interface IPatient
    {
        public IFullName FullName { get; set; }
        public DateTime DateOfBirth { get;  }
        public IAddress Address { get; set; }
        public int PlotNumber { get; set; }
        public int NumbOfPatientCard {  get; set; }
        public int PolicySeries {  get; set; }
        public string PolicyNumb { get; set; }
        public string BloodType { get; set; }
        public string RhFactor { get; set; }
        public string? Allergies { get; set; }

    }
}
