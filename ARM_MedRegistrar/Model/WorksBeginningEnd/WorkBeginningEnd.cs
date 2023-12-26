using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.WorksBeginningEnd
{
    public class WorkBeginningEnd : IWorkBeginningEnd
    {
        public TimeOnly WorkBeginning { get; set; }
        public TimeOnly WorkEnd { get; set; }
        public WorkBeginningEnd(TimeOnly workBeginning, TimeOnly workEnd)
        {
            WorkBeginning = new TimeOnly(workBeginning.Hour, workBeginning.Minute,0);
            WorkEnd = new TimeOnly(workEnd.Hour, workEnd.Minute,0);
            //workEnd = workEnd.Date +  new TimeSpan(workEnd.TimeOfDay.Hours, workEnd.TimeOfDay.Minutes, 0);

        }

        public string Format()
        {
            return $"Начало рабоч.дня: {WorkBeginning}\nКонец рабоч. дня: {WorkEnd}\n";
        }

    }
}
