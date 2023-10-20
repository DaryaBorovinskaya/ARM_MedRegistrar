using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkTest
{
    public class GroupOfPatients 
    {
        private List<Patient> _patients;


        public GroupOfPatients()
        {
            _patients = new List<Patient>();
        }


        public bool AddPatientInRegistry(Patient patient)
        {
            if (patient == null) throw new ArgumentNullException(nameof(patient));

            if (_patients.Contains(patient)) 
                return false;

            _patients.Add(patient);
            return true;
        }

       

        public bool DelPatientInRegistry(Patient patient)
        {
            if (!_patients.Contains(patient)) 
                return false;

            _patients.Remove(patient);

            return true;
        }

        
    }
}
