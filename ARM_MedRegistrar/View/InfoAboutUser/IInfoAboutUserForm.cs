using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.View.InfoAboutUser
{
    public interface IInfoAboutUserForm
    {
        public string Surname { set; }
        public string Name {  set; }
        public string Patronymic {  set; }
        public string PhoneNumber {  set; }
        public string Post {  set; }
    }
}
