﻿using System;
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
    public interface IUser : IUserEmployee
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public byte[] Salt { get; set; }
    }
}
