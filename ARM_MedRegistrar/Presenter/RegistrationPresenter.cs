using ARM_MedRegistrar.Model.FullNames;
using ARM_MedRegistrar.Model.Json.UserRepository;
using ARM_MedRegistrar.Model.Users;
using ARM_MedRegistrar.View.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ARM_MedRegistrar.Presenter
{
    public class RegistrationPresenter
    {
        FullName _fullName;
        User _newUser;
        IRegistrationForm _view;
        IUserRepository _jsonUserRepository;
        IDictionary<string, IUser>? _users;
        public RegistrationPresenter(IRegistrationForm view)
        { 
            _view = view;
            _jsonUserRepository = new JsonUserRepository("users.json");
            _users = _jsonUserRepository.GetAll();
        }



        public event EventHandler? NoOneHeadDoctorEvent;
        public event EventHandler? MatchedLogEvent;





        public bool IsSuccessRegistration()
        {
            bool _isSuccess = true;
            foreach (string key in _users.Keys)
            {
                if (_users[key].Post == "главный врач" && _view.Post == "главный врач")
                {
                    
                    NoOneHeadDoctorEvent?.Invoke(this, EventArgs.Empty);
                    _isSuccess = false;
                    
                }

                if (key == _view.Login)
                {
                    
                    MatchedLogEvent?.Invoke(this, EventArgs.Empty);
                    _isSuccess = false;
                }

                
            }

            if (_isSuccess)
            {
                _fullName = new(_view.Surname, _view.Name, _view.Patronymic);
                _newUser = new(_fullName, _view.Login, _view.Password, _view.Post);
                _jsonUserRepository.Add(_view.Login, _newUser);
                return true;
            }
            return false;
        }
    }
}
