using ARM_MedRegistrar.Model.Formatter;
using ARM_MedRegistrar.Model.WorkSchedules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ARM_MedRegistrar.Model.WorkSchedules
{
    public class WorkScheduleOfDoctor : IWorkSchedule
    {
        private string _dayOfWeek;
        private static readonly string[] _dayOfWeeks = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

        public static string[] GetDaysOfWeek => _dayOfWeeks;
        
        public string DayOfWeek
        {
            get => _dayOfWeek;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("День недели не задан");
                _dayOfWeek = value;
            }
        }

        
        public DateTime WorkBeginning { get; set; }
        
        

        public DateTime WorkEnd { get; set; }
        

        
          
        public WorkScheduleOfDoctor(string dayOfWeek, DateTime workBeginning, DateTime workEnd )
        {
            DayOfWeek = dayOfWeek;
            workBeginning = workBeginning.Date +  new TimeSpan(workBeginning.TimeOfDay.Hours, workBeginning.TimeOfDay.Minutes, 0);
            WorkBeginning = workBeginning;
            workEnd = workEnd.Date +  new TimeSpan(workEnd.TimeOfDay.Hours, workEnd.TimeOfDay.Minutes, 0);
            WorkEnd = workEnd;
            
        }

        public string Format()
        {
            return "День недели: " + DayOfWeek + "\nНачало рабоч. дня: " + WorkBeginning.TimeOfDay.ToString() + "\nКонец рабоч. дня : " + WorkEnd.TimeOfDay.ToString()   + "\n\n";
        }

    }
}
