using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.AttachedStreets
{
    public interface IAttachedStreets
    {
        public string City { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public int NumbOfHouse { get; set; }
    }
}
