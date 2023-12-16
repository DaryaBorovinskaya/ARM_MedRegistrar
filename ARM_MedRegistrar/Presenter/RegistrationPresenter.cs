using ARM_MedRegistrar.Model.Persons;
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
        IFullName _fullName;
        IUser _newUser;
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
            if (_users != null)
            {
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
                
            }
            if (_isSuccess)
            {
                _fullName = new FullName(_view.Surname, _view.Name, _view.Patronymic);
                _newUser = new User(_fullName, _view.Login, _view.Password, _view.Post, _view.PhoneNumber);
                _jsonUserRepository.Add( _newUser);
                _jsonUserRepository.WriteToFile();
                return true;
            }
            return false;

        }
    }
}
