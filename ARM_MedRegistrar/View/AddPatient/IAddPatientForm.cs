
namespace ARM_MedRegistrar.View.AddPatient
{
    public interface IAddPatientForm
    { 
        public string Surname { get; }
        public string Name { get; }
        public string? Patronymic { get; }
        public DateOnly DateOfBirth { get; }
        public string PhoneNumber {  get; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string Street { get; }
        public int NumbOfHouse { get; }
        public int NumbOfFlat { get; }
        public int PlotNumber { get; set; }
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
