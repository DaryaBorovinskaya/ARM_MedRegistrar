using ARM_MedRegistrar.Model.Formatter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Addresses
{
    public interface IAddress :IFormatter
    {
        public string City { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public int NumbOfHouse { get; set; }
        public int NumbOfFlat { get; set; }
    }
}
