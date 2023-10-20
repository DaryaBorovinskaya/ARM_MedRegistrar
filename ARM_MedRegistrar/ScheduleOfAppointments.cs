using CourseworkTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar
{
    public class ScheduleOfAppointments         //расписание приёмов
    {
        private List<Appointment> _appointments;
        

        public ScheduleOfAppointments()
        {
            _appointments = new List<Appointment>();
        
        }


        public bool AddAppointment(Appointment appointment)
        {
            if (appointment == null) throw new ArgumentNullException(nameof(appointment));

            if (_appointments.Contains(appointment))
                return false;

            _appointments.Add(appointment);
            return true;
        }

        public bool DelAppointment(Appointment appointment)
        {
            if (!_appointments.Contains(appointment))
                return false;

            _appointments.Remove(appointment);

            return true;
        }
    }
}
