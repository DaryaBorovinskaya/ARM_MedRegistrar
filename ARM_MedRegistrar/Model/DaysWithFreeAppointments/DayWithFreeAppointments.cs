using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_MedRegistrar.Model.WorksBeginningEnd;

namespace ARM_MedRegistrar.Model.DaysWithFreeAppointments
{
    public class DayWithFreeAppointments : IDayWithFreeAppointments
    {
        private IList<TimeOnly> _timesOfAppointments = new List<TimeOnly>();
        public IList<TimeOnly> TimeOfAppointments 
        {
            get => _timesOfAppointments;
            set => _timesOfAppointments = value;
        }
        
        public IWorkBeginningEnd WorkBeginningEnd { get; set; }
        public DateOnly DateOfAppointment { get; set; }
        public TimeOnly DurationOfAppointment { get; set; }
        public DayWithFreeAppointments(IWorkBeginningEnd workBeginningEnd, TimeOnly durationOfAppointment, DateOnly dateOfAppointment)
        {
            DateOfAppointment = dateOfAppointment;
            WorkBeginningEnd = workBeginningEnd;
            DurationOfAppointment = new TimeOnly(durationOfAppointment.Hour, durationOfAppointment.Minute, 0);

            if (_timesOfAppointments.Count == 0)
                CreateTimeOfAppointments();

        }


        public void CreateTimeOfAppointments()
        {
            _timesOfAppointments.Add(new TimeOnly(WorkBeginningEnd.WorkBeginning.Hour, WorkBeginningEnd.WorkBeginning.Minute));

            TimeSpan _timeOfAppointment = new TimeSpan (WorkBeginningEnd.WorkBeginning.Hour, WorkBeginningEnd.WorkBeginning.Minute, 0);
            TimeSpan _duration = new TimeSpan(DurationOfAppointment.Hour, DurationOfAppointment.Minute, 0);
            TimeSpan _workEnd = new TimeSpan(WorkBeginningEnd.WorkEnd.Hour, WorkBeginningEnd.WorkEnd.Minute,0);

            while (_timeOfAppointment + _duration < _workEnd)    
            {
                _timeOfAppointment += _duration;
                _timesOfAppointments.Add(new TimeOnly(_timeOfAppointment.Hours, _timeOfAppointment.Minutes));
            }

        }
    }
}
