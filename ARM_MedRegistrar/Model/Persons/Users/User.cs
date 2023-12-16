using ARM_MedRegistrar.Model.Persons;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Users
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

        public string Login { get; }
        public string Password { get; }
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

        
        public User(IFullName fullName, string login, string password, string post, string phoneNumber)
        {
            if (login == "" || login == " " || login == null)
                throw new ArgumentException("Логин не задан");

            if (password == "" || password == " " || password == null)
                throw new ArgumentException("Пароль не задан");


            


            FullName = fullName;
            Login = login;
            Password = password;
            Post = post;
            PhoneNumber = phoneNumber;
            
        }
    }
}
