using ARM_MedRegistrar.Model.Formatter;
using ARM_MedRegistrar.Model.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.AddressesOfBuilding
{
    public interface IAddressOfBuilding : IFormatter, IFormatterOneLine
    {
        public string City { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public int NumbOfHouse { get; set; }
    }
}
