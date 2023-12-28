using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Presenter.InfoAboutUserPresenter
{
    public interface IInfoAboutUserPresenter
    {
        public string InfoSurname { set; }
        public string InfoName { set; }
        public string? InfoPatronymic { set; }
        public string InfoPhoneNumber { set; }
        public string InfoPost { set; }
    }
}
