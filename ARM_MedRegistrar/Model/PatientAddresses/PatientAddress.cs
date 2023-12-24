using ARM_MedRegistrar.Model.AddressesOfBuilding;
namespace ARM_MedRegistrar.Model.Addresses
{
    public class PatientAddress : IPatientAddress
    {
        
        private int _numbOfFlat;
        
        public IAddressOfBuilding AddressOfBuilding { get; set; }
        public int NumbOfFlat
        {
            get => _numbOfFlat;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Номер квартиры не может быть меньше или равным нулю");
                _numbOfFlat = value;
            }
        }

        public PatientAddress(IAddressOfBuilding addressOfBuilding,  int numbOfFlat )
        {
            AddressOfBuilding = addressOfBuilding;
            NumbOfFlat = numbOfFlat;
        }

        public string Format()
        {
            return AddressOfBuilding.Format() +  $", кв. {NumbOfFlat}";
        }
    }
}
