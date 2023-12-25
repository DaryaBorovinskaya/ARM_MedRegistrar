using ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Persons
{
    public interface IUserEmployee 
    { 
        public IPersonalData PersonalData { get; set; }
        public string Post { get; set; }
       
        
    }
}
