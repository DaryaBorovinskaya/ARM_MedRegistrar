using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Data.Json.Dictionaries
{
    public interface IBaseWithIdRepository<T, U> : IBaseRepository<T, U> where U : class
    {
        public uint CreateId();
    }
}
