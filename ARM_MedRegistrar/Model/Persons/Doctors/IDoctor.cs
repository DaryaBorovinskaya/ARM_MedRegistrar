using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_MedRegistrar.Model.Formatter;
using ARM_MedRegistrar.Model.Identifications;
using ARM_MedRegistrar.Model.Persons;

namespace ARM_MedRegistrar.Model.Persons.Doctors
{
    public interface IDoctor: IIdentification, IFormatter
    {
        public IFullName FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Specialization { get; set; }
        public int PlotNumber { get; set; }
        public int Cabinet { get; set; }
      

    }
}
