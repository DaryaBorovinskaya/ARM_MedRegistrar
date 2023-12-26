
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

            Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length);
            Buffer.BlockCopy(salt, 0, saltedPassword, passwordBytes.Length, salt.Length);
            return SHA256.HashData(saltedPassword);
        }
         
        public static string GenerateSaltPassword(string password, byte[] salt)
        {
            return BitConverter.ToString(GenerateSha256Hash(password, salt));
        }
    }
}
