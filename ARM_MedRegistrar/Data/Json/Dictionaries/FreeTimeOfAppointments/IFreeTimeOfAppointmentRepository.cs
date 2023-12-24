using ARM_MedRegistrar.Model.FreeTimeOfAppointments;
using ARM_MedRegistrar.Model.WorkSchedules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Data.Json.Dictionaries.FreeTimeOfAppointments
{
    public interface IFreeTimeOfAppointmentRepository 
    {
        public void Add(uint key, IList<IFreeTimeOfAppointment> value);
        public IDictionary<uint, IList<IFreeTimeOfAppointment>>? GetAll();
        public bool SaveChangedData(uint key, IList<IFreeTimeOfAppointment> changedValue);
        public void Remove(uint key);
        
    }
}
