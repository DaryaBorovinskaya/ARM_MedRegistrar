using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Presenter.Doctors
{
    public interface IDoctorPresenter
    {
        public uint Id { set; }
        public int CountOfLine { set; }
        public string Surname {  set; }
        public string Name {  set; }
        public string? Patronymic { set; }
        public string Specialization {  set; }
        public int PlotNumber { set; }
        public int Cabinet { set; }

        public string InfoAboutDoctor { set; }
    }
}
