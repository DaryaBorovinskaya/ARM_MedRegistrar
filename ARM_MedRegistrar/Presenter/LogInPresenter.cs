using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Data.Json.Dictionaries.UserRepository;
using ARM_MedRegistrar.View.LogIn;


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
            _userRepository = new JsonUserRepository();
        }

        public IUser? LogIn()
        {
            string saltedPassword;
            _users = _userRepository.GetAll();
            if (_users == null || _users.Count == 0) 
                return null;
            else
            {
                foreach (string key in _users.Keys)
                
                    if (key == _view.Login)
                    {
                        saltedPassword =  Model.Persons.Users.User.GenerateSaltPassword(_view.Password, _users[key].Salt);
                        if (saltedPassword == _users[key].Password)
                            return _users[key];
                    }
                
                return null;
            }


        }
    }
}
