using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans;
using ARM_MedRegistrar.Model.WorkSchedules;

namespace ARM_MedRegistrar.Model.Persons.Doctors
{
    public class Doctor : IDoctor
    {
        private IDoctorDataOfAppointment _doctorDataOfAppointment;
        private IList<IWorkSchedule> _workSchedules;
        
        public IDoctorDataOfAppointment DoctorDataOfAppointment 
        {
            get => _doctorDataOfAppointment;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));
                _doctorDataOfAppointment = value;
            }
        }

        public IList<IWorkSchedule> WorkSchedule
        {
            get => _workSchedules;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));
                _workSchedules = value;
            }
        }
        
        

        public Doctor(IDoctorDataOfAppointment doctorDataOfAppointment,  IList<IWorkSchedule> workSchedule )
        {
            DoctorDataOfAppointment = doctorDataOfAppointment;
            WorkSchedule = workSchedule;
        }

        public string Format()
        {
            string _lineSchedule = "";
            foreach (IWorkSchedule workSchedule in WorkSchedule) 
                 _lineSchedule += workSchedule.Format();


            return $"{DoctorDataOfAppointment.Format()}ГРАФИК РАБОТЫ\n\n{_lineSchedule}";
        }
    }
}
