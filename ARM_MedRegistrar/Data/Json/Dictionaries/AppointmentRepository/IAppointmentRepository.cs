using ARM_MedRegistrar.Model.Appointments;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ARM_MedRegistrar.Data.Json.Dictionaries.AppointmentRepository
{
    public interface IAppointmentRepository : IBaseRepository<uint, IAppointment>, ICreateId
    {

    }
}
