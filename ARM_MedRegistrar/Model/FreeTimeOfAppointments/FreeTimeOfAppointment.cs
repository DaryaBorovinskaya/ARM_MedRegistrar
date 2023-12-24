

using ARM_MedRegistrar.Model.WorkSchedules;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ARM_MedRegistrar.Model.FreeTimeOfAppointments
{
    public class FreeTimeOfAppointment : IFreeTimeOfAppointment
    {
        private IList<DateTime> _timesOfAppointments = new List<DateTime>();
        public IList<DateTime> TimeOfAppointments 
        { 
            get => _timesOfAppointments;
            set => _timesOfAppointments = value;
        }
        public DateTime WorkBeginning { get;  set; }
        public DateTime WorkEnd {  get; set; }
        public DateTime DateOfAppointment { get; set; }
        public DateTime DurationOfAppointment { get; set; }
        public FreeTimeOfAppointment(DateTime workBeginning, DateTime workEnd, DateTime durationOfAppointment, DateTime dateOfAppointment)
        {
            workBeginning = workBeginning.Date + new TimeSpan(workBeginning.TimeOfDay.Hours, workBeginning.TimeOfDay.Minutes, 0);
            WorkBeginning = workBeginning;

            workEnd = workEnd.Date + new TimeSpan(workEnd.TimeOfDay.Hours, workEnd.TimeOfDay.Minutes, 0);
            WorkEnd = workEnd;

            durationOfAppointment = durationOfAppointment.Date + new TimeSpan(durationOfAppointment.TimeOfDay.Hours, durationOfAppointment.TimeOfDay.Minutes, 0);
            DurationOfAppointment = durationOfAppointment;

            
            CreateTimeOfAppointments();
            
            DateOfAppointment = dateOfAppointment.Date;
        }


        public void CreateTimeOfAppointments()
        {
            DateTime _timeOfAppointment = WorkBeginning;

            _timesOfAppointments.Add(_timeOfAppointment);

            while(_timeOfAppointment.TimeOfDay + DurationOfAppointment.TimeOfDay < WorkEnd.TimeOfDay)
            {
                _timeOfAppointment += DurationOfAppointment.TimeOfDay;
                _timesOfAppointments.Add(_timeOfAppointment);
                
            }

        }


    }
}
