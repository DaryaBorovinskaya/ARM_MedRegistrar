using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.View.Registration
{
    public interface IRegistrationForm
    {
        public string Surname { get; }
        public string Name { get; }
        public string Patronymic {  get; }
        public string Login { get; }
        public string Password { get; }
        public string Post { get; }
    }
}
