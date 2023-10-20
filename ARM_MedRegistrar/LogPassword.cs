using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar
{
    public class LogPassword   //логин и пароль
    {
     
        private string _login;
        private string _password;

        public string Login
        {
            get => _login; set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Логин не задан");
                _login = value;
            }
        }

        public string Password
        {
            get => _password; set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Пароль не задан");
                _password = value;
            }
        }

        public LogPassword(string login, string password) 
        {
            Login = login;
            Password = password;

        }



    }
}
