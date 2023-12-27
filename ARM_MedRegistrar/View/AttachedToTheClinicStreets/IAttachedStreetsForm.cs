using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.View.AttachedToTheClinicStreets
{
    public interface IAttachedStreetsForm
    {
        public string City { get; }
        public string Region {  get; }
        public string Street {  get; }
        public int NumbOfHouse {  get; }
        public string AllAttStreets { set; }
    }
}
