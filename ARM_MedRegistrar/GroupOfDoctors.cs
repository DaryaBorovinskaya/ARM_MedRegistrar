using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkTest
{
    public class GroupOfDoctors 
    {
        private List<Doctor> _doctors;


        public GroupOfDoctors()
        {
            _doctors = new List<Doctor>();
        }



        public bool AddDoctorInRegistry(Doctor doctor)
        {
            if (doctor == null) throw new ArgumentNullException(nameof(doctor));

            if (_doctors.Contains(doctor)) 
                return false;

            _doctors.Add(doctor);
            return true;
        }

        public bool DelDoctorInRegistry(Doctor doctor)
        {
            if (!_doctors.Contains(doctor))
                return false;

            _doctors.Remove(doctor);

            return true;
        }

        

        
    }
}
