using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Model.Persons.Users;
using ARM_MedRegistrar.View.InfoAboutUser;

namespace ARM_MedRegistrar.Presenter.InfoAboutUserPresenter
{
    public class InfoAboutUserPresenter : IInfoAboutUserPresenter
    {
        IInfoAboutUserForm _view;
        string result;
        IUser _user;
        string IInfoAboutUserPresenter.InfoSurname { set => _view.Surname = value; }
        string IInfoAboutUserPresenter.InfoName { set => _view.Name = value; }
        string? IInfoAboutUserPresenter.InfoPatronymic { set => _view.Patronymic = value; }
        string IInfoAboutUserPresenter.InfoPhoneNumber { set => _view.PhoneNumber = value; }
        string IInfoAboutUserPresenter.InfoPost { set => _view.Post = value; }


        public InfoAboutUserPresenter(IInfoAboutUserForm view)
        {
            _view = view;
            _user = new User(this);
        }

        
        public string ShowData()
        {
            try
            {
                result = User.ShowInfoAboutUser();
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
        }

        public string CheckAccessLevel()
        {
            try
            {
                result = User.CheckAccessLevel();
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
        }
    }
}
