using ARM_MedRegistrar.Model.Persons;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Persons.Users
{

    public class User : IUser
    {
        private IFullName _fullName;
        private string _phoneNumber;
        private string _post;
        

        public IFullName FullName
        {
            get => _fullName;
            set
            {
                if (value == null)
                    throw new ArgumentException("Попытка присвоить значение null полю ФИО");
                _fullName = value;
            }
        }

        public string Login { get; set; }
        public string Password { get; set; }
        public string Post
        {
            get => _post;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Должность не задана");

                _post = value;
            }
        }

        public byte[] Salt { get; set; }
        
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Логин не задан");

                _phoneNumber = value;
            }
        }

        public User()
        {

        }
        public User(IFullName fullName, string login, string password, string post, string phoneNumber)
        {
            if (login == "" || login == " " || login == null)
                throw new ArgumentException("Логин не задан");

            if (password == "" || password == " " || password == null)
                throw new ArgumentException("Пароль не задан");


            FullName = fullName;
            Login = login;
            Post = post;
            PhoneNumber = phoneNumber;
            Salt = GenerateSalt();
            Password = GenerateSaltPassword(password, Salt); 
        }

        public static byte[] GenerateSalt()
        {
            int saltLength = 64;
            byte[] salt = new byte[saltLength];
            var rngRand = new RNGCryptoServiceProvider();
            rngRand.GetBytes(salt);
            return salt;
        }

        public static byte[]  GenerateSha256Hash(string password, byte[] salt)
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
