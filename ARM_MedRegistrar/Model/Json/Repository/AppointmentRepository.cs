using ARM_MedRegistrar.Model.Appointments;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Json.Repository
{
    public abstract class AppointmentRepository : IBaseRepository<IAppointment>
    {
        protected IList<IAppointment>? _appointments;
        public abstract void Add(IAppointment element);


        public abstract IList<IAppointment>? GetAll();


        public abstract void Remove(IAppointment element);

    }
}
