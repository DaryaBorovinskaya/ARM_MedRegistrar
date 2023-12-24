
using ARM_MedRegistrar.Model.AddressesOfBuilding;

namespace ARM_MedRegistrar.Model.AttachedStreets
{
    public class AttachedStreets : IAttachedStreets
    {

        public IAddressOfBuilding AddressOfBuilding { get; set; }
        public uint Id { get; }
        public AttachedStreets(IAddressOfBuilding addressOfBuilding, uint id) 
        {
            AddressOfBuilding = addressOfBuilding;
            Id = id;
        }

        public string Format()
        {
            return AddressOfBuilding.Format();
        }
    }
}
