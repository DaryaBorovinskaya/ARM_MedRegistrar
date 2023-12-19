using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_MedRegistrar.Data.Json.Dictionaries.UserRepository;
using ARM_MedRegistrar.View.LogIn;
using ARM_MedRegistrar.Model.Persons;

namespace ARM_MedRegistrar.Presenter
{
    public class LogInPresenter
    {
        ILogInForm _view;
        IUserRepository _userRepository;
        IDictionary<string, IUser>? _users;
        public LogInPresenter(ILogInForm view)
        {
            _view = view;
            _userRepository = new JsonUserRepository("users.json");
        }

        public IUser? LogIn()
        {
            _users = _userRepository.GetAll();
            if (_users == null || _users.Count == 0) return null;
            else
            {
                foreach (string key in _users.Keys)
                {
                    if (key == _view.Login && _users[key].Password == _view.Password)
                        return _users[key];
                }
                return null;
            }


        }
    }
}
