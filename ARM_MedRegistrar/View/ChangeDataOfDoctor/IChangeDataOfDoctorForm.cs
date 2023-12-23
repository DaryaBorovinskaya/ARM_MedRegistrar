using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.View.ChangeDataOfDoctor
{
    public interface IChangeDataOfDoctorForm
    {
        public uint Id { get; }
        public string Surname { get;  set; }
        public string Name { get; set; }
        public string? Patronymic { get; set; }
        public string Specialization { get; set; }
        public string PhoneNumber { get; set; }
        public int PlotNumber { get; set; }
        public int Cabinet { get; set; }
        public IList<DateTime> TimesOfWork { get; set; }
        public DateTime DurationOfAppointment { get; set; }
    }
}
