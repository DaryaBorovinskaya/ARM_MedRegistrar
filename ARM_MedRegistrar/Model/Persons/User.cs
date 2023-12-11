using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Persons
{
    
    public class User : IUser
    {
        private IFullName _fullName;
        
        
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
        public string Post { get; }

        public User(IFullName fullName, string login, string password, string post) 
        {
            if (login == "" || login == " " || login == null)
                throw new ArgumentException("Логин не задан");

            if (password == "" || password == " " || password == null)
                throw new ArgumentException("Пароль не задан");


            if (post == "" || post == " " || post == null)
                throw new ArgumentException("Должность не задана");


            FullName = fullName;
            Login = login;
            Password = password;
            Post = post;
        }
    }
}
