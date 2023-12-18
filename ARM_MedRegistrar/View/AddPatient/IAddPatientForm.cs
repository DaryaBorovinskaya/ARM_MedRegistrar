
namespace ARM_MedRegistrar.View.AddPatient
{
    public interface IAddPatientForm
    {
        public string Surname { get; }
        public string Name { get; }
        public string? Patronymic { get; }
        public string DateOfBirth { get; }
        public string? City { get;  }
        public string? Region { get;  }
        public string Street { get; }
        public int NumbOfHouse { get; }
        public int NumbOfFlat { get; }
        public int PlotNumber { get; }
        public string NumbOfPatientCard { get; }
        public int PolicySeries { get; }
        public string PolicyNumb { get; }
        public string DocumentSeries { get; }    
        public string DocumentNumber { get; }
        public string BloodType { get; }
        public string RhFactor { get; }
        public string? Allergies { get; }

    }
}
