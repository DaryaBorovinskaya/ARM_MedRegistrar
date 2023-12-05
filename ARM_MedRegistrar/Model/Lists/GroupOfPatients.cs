using ARM_MedRegistrar.Model.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Lists
{
    public class GroupOfPatients
    {
        public List<Patient> _patients;

        public GroupOfPatients() 
        {
            _patients = new List<Patient>();
        }
    }
}
