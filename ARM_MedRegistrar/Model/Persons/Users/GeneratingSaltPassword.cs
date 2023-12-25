using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Persons.Users
{
    public class GeneratingSaltPassword
    {
        private static byte[] GenerateSha256Hash(string password, byte[] salt)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] saltedPassword = new byte[salt.Length + passwordBytes.Length];
            return SHA256.HashData(saltedPassword);
        }

        public static string GenerateSaltPassword(string password, byte[] salt)
        {
            return BitConverter.ToString(GenerateSha256Hash(password, salt));
        }
    }
}
