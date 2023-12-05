using ARM_MedRegistrar.Model.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Lists
{
    public class GroupOfDoctors
    {
        public List<Doctor> _doctors;

        public GroupOfDoctors() 
        {
            _doctors = new List<Doctor>();
        }
    }
}
