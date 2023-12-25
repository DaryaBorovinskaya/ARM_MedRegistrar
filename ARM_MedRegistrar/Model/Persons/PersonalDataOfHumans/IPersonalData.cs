using ARM_MedRegistrar.Model.Formatter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans
{
    public interface IPersonalData : IFormatter
    {
        public IFullName FullName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
