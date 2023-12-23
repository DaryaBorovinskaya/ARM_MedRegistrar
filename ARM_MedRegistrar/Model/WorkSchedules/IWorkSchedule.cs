using ARM_MedRegistrar.Model.Formatter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.WorkSchedules
{
    public interface IWorkSchedule : IFormatter
    {
        
        public string DayOfWeek { get; set; }
        public DateTime WorkBeginning { get; set; }
        public DateTime WorkEnd { get; set; }
       
    }
}
