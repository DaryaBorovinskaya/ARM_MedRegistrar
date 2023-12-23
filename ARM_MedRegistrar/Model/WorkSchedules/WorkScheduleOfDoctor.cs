using ARM_MedRegistrar.Model.Formatter;
using ARM_MedRegistrar.Model.WorkSchedules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.WorkSchedules
{
    public class WorkScheduleOfDoctor : IWorkSchedule
    {
        private string _dayOfWeek;
        private string _workBeginning;
        private string _workEnd;

       
        public string DayOfWeek
        {
            get => _dayOfWeek;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("День недели не задан");
                _dayOfWeek = value;
                OnPropertyChanged();
            }
        }

        
        public string WorkBeginning
        {
            get => _workBeginning;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Начало рабоч. дня не задано");
                _workBeginning = value;
                OnPropertyChanged();
            }
        }

        public string WorkEnd
        {
            get => _workEnd;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Конец рабоч. дня не задан");
                _workEnd = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Format()
        {
            return "День недели: " + DayOfWeek + "\n : " + WorkBeginning + "\n : " + WorkEnd + "\n";
        }

    }
}
