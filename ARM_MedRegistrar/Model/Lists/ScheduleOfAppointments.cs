using ARM_MedRegistrar.Model.Appointments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Lists
{
    public class ScheduleOfAppointments
    {
        private List<Appointment> _doctors;

        public ScheduleOfAppointments() 
        { 
            _doctors = new List<Appointment>();
        }
    }
}
