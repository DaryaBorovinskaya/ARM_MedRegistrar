using ARM_MedRegistrar.Data.Json.Dictionaries.PatientRepository;
using ARM_MedRegistrar.View.ChangeDataOfUser;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Data.Json.Dictionaries;
using ARM_MedRegistrar.Data.Json.Dictionaries.UserRepository;
using ARM_MedRegistrar.Model.Persons.Users;

namespace ARM_MedRegistrar.Presenter
{
    public class ChangeDataOfUserPresenter
    {
        IChangeDataOfUserForm _view;
        IDictionary<string, IUser> _users;
        IBaseRepository<string, IUser> _jsonUserRepository;
        IUser _user;
        byte[] _salt;
        string _saltPassword;
        public ChangeDataOfUserPresenter(IChangeDataOfUserForm view)
        {
            _view = view;
            _jsonUserRepository = new JsonUserRepository();
        }

        public bool ShowDataAboutPatient()
        {
            _users = _jsonUserRepository.Read();
            if (_users == null || _users.Count == 0)
                return false;

            if (_users != null && _users.Count != 0)
            {
                foreach (string key in _users.Keys)
                    if (Equals(key.Length, _view.OldLogin.Length) && Equals(key, _view.OldLogin))
                    {

                        _user = _users[key];

                        _view.Surname = _user.PersonalData.FullName.Surname;
                        _view.Name = _user.PersonalData.FullName.Name;
                        _view.Patronymic = _user.PersonalData.FullName.Patronymic;
                        _view.NewLogin = _user.Login;
                        _view.Post = _user.Post;
                        _view.PhoneNumber = _user.PersonalData.PhoneNumber;
                        return true;
                    }

            }
            return false;
        }

        public bool SaveChanges()
        {
            _users = _jsonUserRepository.Read();
            if (_users == null || _users.Count == 0)
                return false;

            if (_users != null && _users.Count != 0)
            {
                foreach (string key in _users.Keys)
                    if (Equals(key.Length, _view.OldLogin.Length) && Equals(key, _view.OldLogin))
                    {
                        _user = _users[key];
                        _user.PersonalData.FullName.Surname = _view.Surname;
                        _user.PersonalData.FullName.Name = _view.Name;
                        _user.PersonalData.FullName.Patronymic = _view.Patronymic;
                        _user.Post = _view.Post;
                        _user.PersonalData.PhoneNumber = _view.PhoneNumber;
                        _saltPassword = GeneratingSaltPassword.GenerateSaltPassword(_view.NewPassword, _user.Salt);
                        _user.SaltPassword = _saltPassword;
                        if (_jsonUserRepository.Update(_user))
                            return true;
                    }

            }
            return false;
        }


        public bool RemoveUser()
        {
            _users = _jsonUserRepository.Read();
            if (_users == null || _users.Count == 0)
                return false;

            if (_users != null && _users.Count != 0)
            {
                foreach (string key in _users.Keys)
                    if (Equals(key.Length, _view.OldLogin.Length) && Equals(key, _view.OldLogin) && !Equals(key,"1"))
                    {
                        _jsonUserRepository.Delete(key);
                        return true;
                    }
            }
            return false;
        }
    }
}
