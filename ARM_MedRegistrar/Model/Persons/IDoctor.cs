using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Persons
{
    public interface IDoctor
    {
        public FullName FullName { get; set; }
        public string Specialization { get; }
        public int PlotNumber { get; set; }
        public int Cabinet {  get; set; }

    }
}
