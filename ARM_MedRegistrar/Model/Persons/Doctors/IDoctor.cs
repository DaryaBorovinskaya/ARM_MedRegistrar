using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_MedRegistrar.Model.Identifications;
using ARM_MedRegistrar.Model.Persons;

namespace ARM_MedRegistrar.Model.Doctors
{
    public interface IDoctor: IIdentification
    {
        public IFullName FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Specialization { get; set; }
        public int PlotNumber { get; set; }
        public int Cabinet { get; set; }
      

    }
}
