using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model
{
    public interface IWorkBeginningEnd
    {
        public DateTime WorkBeginning { get; set; }
        public DateTime WorkEnd { get; set; }
    }
}
