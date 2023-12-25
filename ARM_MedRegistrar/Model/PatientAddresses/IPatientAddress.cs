using ARM_MedRegistrar.Model.Formatter;
using ARM_MedRegistrar.Model.AddressesOfBuilding;
using ARM_MedRegistrar.Model.Formatters;

namespace ARM_MedRegistrar.Model.Addresses
{
    public interface IPatientAddress :IFormatter, IFormatterOneLine
    {
        public IAddressOfBuilding AddressOfBuilding { get; set; }
        public int NumbOfFlat { get; set; }
    }
}
