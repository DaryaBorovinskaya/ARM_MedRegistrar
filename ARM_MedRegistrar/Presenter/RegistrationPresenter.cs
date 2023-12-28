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
        IRegistrationForm _view;
        
        public RegistrationPresenter(IRegistrationForm view)
        { 
            _view = view;
            
        }

        public IList<string> SetPost() 
        {
            return User.SetPost();   
        }

        public string IsSuccessRegistration()
        {
            string result;
            try 
            {
                result = User.IsSuccessRegistration(_view.Surname, _view.Name, _view.Patronymic, _view.Login, _view.Password, _view.PhoneNumber, _view.GetPost);
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
            
        }


        public string SuccessRegistration()
        {
            return User.SuccessRegistration(_view.GetPost);
        }
    }
}
