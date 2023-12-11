using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Persons
{
    //public enum Profession
    //{
    //    MedRegistrar,
    //    HeadOfRegistry,
    //    HeadDoctor       
    //};
    public interface IUser 
    {
        public IFullName FullName { get; set; }
        public string Login { get; }
        public string Password { get;  }
        public string Post { get; }
    }
}
