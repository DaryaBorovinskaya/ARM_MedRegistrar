using ARM_MedRegistrar.Model.WorkSchedules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.FreeTimeOfAppointments
{
    public interface IFreeTimeOfAppointment : IWorkBeginningEnd
    {
        public DateTime DateOfAppointment { get; set; }
        public IList<DateTime> TimeOfAppointments { get; set; }
        
        public DateTime DurationOfAppointment { get; set; }
    }
}
