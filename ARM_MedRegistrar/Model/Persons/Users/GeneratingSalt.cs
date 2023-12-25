using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Persons.Users
{
    public class GeneratingSalt
    {
        public static byte[] GenerateSalt()
        {
            int saltLength = 64;
            byte[] salt = new byte[saltLength];
            var rngRand = new RNGCryptoServiceProvider();
            rngRand.GetBytes(salt);
            return salt;
        }
    }
}
