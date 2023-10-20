using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar
{
    public class DataOfUsers    //данные о пользователях (логин и пароль)
    {
        private List<LogPassword> _dataOfUsers;

        public DataOfUsers()
        {
            _dataOfUsers = new List<LogPassword>();
        }



        public bool AddLogPassword(LogPassword logPassword)
        {
            if (logPassword == null) throw new ArgumentNullException(nameof(logPassword));

            if (_dataOfUsers.Contains(logPassword))
                return false;

            _dataOfUsers.Add(logPassword);
            return true;
        }

         

        public bool DelLogPassword(LogPassword logPassword)
        {
            if (!_dataOfUsers.Contains(logPassword))
                return false;

            _dataOfUsers.Remove(logPassword);
            return true;
        }
    }
}
