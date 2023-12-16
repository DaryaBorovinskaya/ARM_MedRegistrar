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
        
        public  void Add(uint key, IAppointment value);


        public  IDictionary<uint, IAppointment>? GetAll();


        public void Remove(uint key);

    }
}
