using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.View.PaidMedServices
{
    public interface IPaidMedServicesForm
    {
        public uint Id {  set; }
        public int CountOfLine { set; }
        public string SearchingTitle { get;  }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { set; }
        public uint SelectedId { get; }
        
    }
}
