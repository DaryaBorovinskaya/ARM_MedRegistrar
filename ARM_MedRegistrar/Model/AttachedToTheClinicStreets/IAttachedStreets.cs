using ARM_MedRegistrar.Model.Formatter;

namespace ARM_MedRegistrar.Model.AttachedStreets
{
    public interface IAttachedStreets: IFormatter
    {
        public string City { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public int NumbOfHouse { get; set; }
    }
}
