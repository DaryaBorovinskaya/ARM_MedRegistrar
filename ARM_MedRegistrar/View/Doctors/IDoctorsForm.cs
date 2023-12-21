using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.View.Doctors
{
    public interface IDoctorsForm
    {
        public uint Id { set; }
        public int CountOfLine { set; }

        public string Surname { get; set; }
        public string Name { get; set; }
        public string? Patronymic {  set; }
        public string Specialization { get; set; }
        public int PlotNumber {  set; }
        public int Cabinet {  set; }
        public uint SelectedId { get; }
        
        public string InfoAboutPatient { set; }
    }
}
