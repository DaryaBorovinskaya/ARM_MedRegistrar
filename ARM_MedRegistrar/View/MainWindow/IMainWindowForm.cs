using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.View.MainWindow
{
    public interface IMainWindowForm
    {
        public uint Id { set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string? Patronymic { get; set; }
        public string DateOfBirth { get; set; }
        public string DocumentSeries { get; set; }
        public string DocumentNumber { get; set; }
        public int PlotNumber { set; }
        public string NumbOfPatientCard { set; }
        public uint SelectedId { get; }
        public int CountOfLine { set; }

        public string InfoAboutPatient { set; }
    }
}
