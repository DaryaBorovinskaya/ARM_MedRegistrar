using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Persons
{
    public interface IUserEmployee
    {
        public IFullName FullName { get; set; }
        public string Post { get; set; }
        public string PhoneNumber { get; set; }
        
    }
}
