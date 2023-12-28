using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Presenter.AddPatient
{
    public interface IAddPatientPresenter
    {
        public string? City {  set; }
        public string? Region {  set; }
        public int PlotNumber {  set; }
    }
}
