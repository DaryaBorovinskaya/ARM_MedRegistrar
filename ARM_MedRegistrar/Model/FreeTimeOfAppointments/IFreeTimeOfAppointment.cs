using ARM_MedRegistrar.Model.DaysWithFreeAppointments;
using ARM_MedRegistrar.Model.Identifications;
using ARM_MedRegistrar.Model.WorkSchedules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.FreeTimeOfAppointments
{
    public interface IFreeTimeOfAppointment : IIdentification
    {
        public IList<IDayWithFreeAppointments> FreeTimeOfAppointments { get; set; }
    }
}
