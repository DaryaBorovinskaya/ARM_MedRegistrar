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
        public string? Patronymic {  set; }
        public DateOnly DateOfBirth { get; set; }
        public string DocumentSeries {  set; }
        public string DocumentNumber {  set; }
        public int PlotNumber { set; }
        public string NumbOfPatientCard { set; }
        public uint SelectedId { get; }
        public int CountOfLine { set; }

        public string InfoAboutPatient { set; }
    }
}
