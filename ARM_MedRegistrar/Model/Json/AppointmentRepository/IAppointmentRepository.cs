using ARM_MedRegistrar.Model.Appointments;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ARM_MedRegistrar.Model.Json.AppointmentRepository
{
    public interface IAppointmentRepository
    {
        
        public abstract void Add(IAppointment value);


        public abstract IList<IAppointment>? GetAll();


        public abstract void Remove(IAppointment value);

    }
}
