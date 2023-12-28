using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Presenter.ChangeDataOfUsers
{
    public interface IChangeDataOfUserPresenter
    {
        public string Surname { set; }
        public string Name { set; }
        public string? Patronymic { set; }
        public string PhoneNumber { set; }
        public string Post { set; }
        public string NewLogin { set; }
    }
}
