using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_MedRegistrar.Model.WorksBeginningEnd;

namespace ARM_MedRegistrar.Model.DaysWithFreeAppointments
{
    public interface IDayWithFreeAppointments 
    {
        public IWorkBeginningEnd WorkBeginningEnd { get; set; }
        public DateOnly DateOfAppointment { get; set; }
        public IList<TimeOnly> TimeOfAppointments { get; set; }
        public TimeOnly DurationOfAppointment { get; set; }
    }
}
