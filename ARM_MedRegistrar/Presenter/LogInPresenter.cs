using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Data.Json.Dictionaries.UserRepository;
using ARM_MedRegistrar.View.LogIn;
using ARM_MedRegistrar.Data.Json.Dictionaries;
using ARM_MedRegistrar.Model.Persons.Users;

namespace ARM_MedRegistrar.Presenter
{
    public class LogInPresenter
    {
        ILogInForm _view;
        IBaseRepository<string, IUser> _jsonUserRepository;
        IDictionary<string, IUser>? _users;
        public LogInPresenter(ILogInForm view)
        {
            _view = view;
            _jsonUserRepository = new JsonUserRepository();
        }

        public IUser? LogIn()
        {
            string saltedPassword;
            _users = _jsonUserRepository.Read();
            if (_users == null || _users.Count == 0)
                return null;
            else
            {
                //foreach (string key in _users.Keys)

                //    if (key == _view.Login)
                //    {
                //        saltedPassword =  Model.Persons.Users.User.GenerateSaltPassword(_view.Password, _users[key].Salt);
                //        if (saltedPassword == _users[key].Password)
                //            return _users[key];
                //    }
                foreach (IUser user in _users.Values)

                    if ( Equals(user.Login.Length ,_view.Login.Length) && Equals(user.Login, _view.Login))
                    {
                        saltedPassword = GeneratingSaltPassword.GenerateSaltPassword(_view.Password, user.Salt);
                        if (saltedPassword == user.SaltPassword)
                            return user;
                    }
                return null;
            }


        }
    }
}
