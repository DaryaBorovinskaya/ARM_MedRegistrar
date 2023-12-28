using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Presenter.PaidMedServices
{
    public interface IPaidMedServicesPresenter
    {
        public uint Id { set; }
        public int CountOfLine { set; }
        public string Title { set; }
        public decimal Price { set; }
        public decimal TotalPrice { set; }
    }
}
