using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.View.AddDoctor
{
    public interface IAddDoctorForm
    {
        public string Surname { get; }
        public string Name { get; }
        public string Patronymic { get; }
        public string Specializations { get; }
        public string PhoneNumber { get;  }
        public int PlotNumber { get;  }
        public int Cabinet { get; }
    }
}
