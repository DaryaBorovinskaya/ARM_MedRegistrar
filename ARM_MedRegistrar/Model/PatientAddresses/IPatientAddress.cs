using ARM_MedRegistrar.Model.Formatter;
using ARM_MedRegistrar.Model.AddressesOfBuilding;

namespace ARM_MedRegistrar.Model.Addresses
{
    public interface IPatientAddress :IFormatter
    {
        public IAddressOfBuilding AddressOfBuilding { get; set; }
        public int NumbOfFlat { get; set; }
    }
}
