using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.Formatter;
using ARM_MedRegistrar.Model.Identifications;
using ARM_MedRegistrar.Model.Persons;

namespace ARM_MedRegistrar.Model.Persons.Patients
{

    public interface IPatient : IIdentification, IFormatter
    {
        public IFullName FullName { get; set; }
        public string DateOfBirth { get; }
        public string PhoneNumber {  get; set; }
        public IAddress Address { get; set; }
        public int PlotNumber { get; set; }
        public string NumbOfPatientCard { get; set; }
        public int PolicySeries { get; set; }
        public string PolicyNumb { get; set; }
        public string DocumentSeries {  get; set; }    //серия паспорта или др. документа, подтвержающего личность
        public string DocumentNumber { get; set; }    //номер паспорта или др. документа, подтвержающего личность
        public string BloodType { get; set; }
        public string RhFactor { get; set; }
        public string? Allergies { get; set; }

        public string Format();

    }
}
