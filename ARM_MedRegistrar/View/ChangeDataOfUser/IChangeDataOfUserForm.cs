using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.View.ChangeDataOfUser
{
    public interface IChangeDataOfUserForm
    {
        public string OldLogin { get; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Patronymic { get; set; }
        public string Post {  get; set; }
        public string NewPassword { get;  }
    
        public string NewLogin { set; }
       
    }
}
