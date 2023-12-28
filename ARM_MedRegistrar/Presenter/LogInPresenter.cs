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
        
        public LogInPresenter(ILogInForm view)
        {
            _view = view;
        }

        public string IsSuccessLogIn()
        {
            string result;
            try
            {
                result = User.IsSuccessLogIn( _view.Login, _view.Password);
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
        }
    }
}
