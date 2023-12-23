using ARM_MedRegistrar.Model.Formatter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.WorkSchedules
{
    public interface IWorkSchedule : INotifyPropertyChanged, IFormatter
    {
        public string DayOfWeek { get; set; }
        public string WorkBeginning { get; set; }
        public string WorkEnd { get; set; }
    }
}
