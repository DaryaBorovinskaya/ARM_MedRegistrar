using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Model.Persons.Users;
using ARM_MedRegistrar.View.Registration;
using ARM_MedRegistrar.Data.Json.Dictionaries.UserRepository;
using ARM_MedRegistrar.Data.Json.Dictionaries;
using ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans;

namespace ARM_MedRegistrar.Presenter
{
    public class RegistrationPresenter
    {
        IFullName _fullName;
        IPersonalData _personalData;
        IUser _newUser;
        IRegistrationForm _view;
        IBaseRepository<string, IUser> _jsonUserRepository;
        IDictionary<string, IUser>? _users;
        byte[] _salt;
        string _saltPassword;
        public RegistrationPresenter(IRegistrationForm view)
        { 
            _view = view;
            _jsonUserRepository = new JsonUserRepository();
            
        }

        public event EventHandler? NoOneHeadDoctorEvent;
        public event EventHandler? MatchedLogEvent;

        public void SetPost()
        {
           _view.SetPost = new List<string> { "медицинский регистратор", "заведующий регистратурой", "главный врач" };
        }


        public bool IsSuccessRegistration()
        {
            _users = _jsonUserRepository.Read();
            
            bool _isSuccess = true;
            if (_users != null && _users.Count != 0)
            {
                foreach (string key in _users.Keys)
                {
                    if (_users[key].Post == "главный врач" && _view.GetPost == "главный врач")
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
                _personalData = new PersonalData(_fullName, _view.PhoneNumber);
                _salt = GeneratingSalt.GenerateSalt();
                _saltPassword = GeneratingSaltPassword.GenerateSaltPassword(_view.Password, _salt);
                _newUser = new User(_personalData, _view.Login, _salt, _saltPassword, _view.GetPost);
                _jsonUserRepository.Create( _newUser);
                
                return true;
            }
            return false;

        }
    }
}
