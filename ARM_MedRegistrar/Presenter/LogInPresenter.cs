using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_MedRegistrar.Model.Json.UserRepository;
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
            _users = _userRepository.GetAll();
        }

        public IUser? LogIn()
        {
            if (_users == null) return null;
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
