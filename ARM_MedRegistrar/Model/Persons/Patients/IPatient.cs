using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.Formatter;
using ARM_MedRegistrar.Model.Identifications;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans;

namespace ARM_MedRegistrar.Model.Persons.Patients
{

    public interface IPatient : IIdentification, IFormatter
    {
        public IPersonalData PersonalData {  get; set; }
        public string DateOfBirth { get; }
        public IPatientAddress Address { get; set; }
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
