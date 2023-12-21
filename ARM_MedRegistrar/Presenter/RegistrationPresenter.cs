using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Model.Persons.Users;
using ARM_MedRegistrar.View.Registration;
using ARM_MedRegistrar.Data.Json.Dictionaries.UserRepository;

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
            _jsonUserRepository = new JsonUserRepository();
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
                
                return true;
            }
            return false;

        }
    }
}
