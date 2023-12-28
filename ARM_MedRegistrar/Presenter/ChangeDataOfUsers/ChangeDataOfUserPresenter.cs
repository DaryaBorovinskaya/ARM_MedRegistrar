using ARM_MedRegistrar.View.ChangeDataOfUser;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Data.Json.Dictionaries;
using ARM_MedRegistrar.Data.Json.Dictionaries.UserRepository;
using ARM_MedRegistrar.Model.Persons.Users;

namespace ARM_MedRegistrar.Presenter.ChangeDataOfUsers
{
    public class ChangeDataOfUserPresenter : IChangeDataOfUserPresenter
    {
        IChangeDataOfUserForm _view;
        IDictionary<string, IUser> _users;
        IBaseRepository<string, IUser> _jsonUserRepository;
        IUser _user;
        byte[] _salt;
        string _saltPassword, result;

        string IChangeDataOfUserPresenter.Surname
        {
            set
            {
                _view.Surname = value;
            }
        }
        string IChangeDataOfUserPresenter.Name
        {
            set
            {
                _view.Name = value;
            }
        }
        string? IChangeDataOfUserPresenter.Patronymic
        {
            set
            {
                _view.Patronymic = value;
            }
        }

        string IChangeDataOfUserPresenter.PhoneNumber
        {
            set
            {
                _view.PhoneNumber = value;
            }
        }
        string IChangeDataOfUserPresenter.Post
        {
            set
            {
                _view.Post = value;
            }
        }

        string IChangeDataOfUserPresenter.NewLogin
        {
            set
            {
                _view.NewLogin = value;
            }
        }


        public ChangeDataOfUserPresenter(IChangeDataOfUserForm view)
        {
            _view = view;
            _jsonUserRepository = new JsonUserRepository();
            _user = new User(this);
        }

        public IList<string> SetPost()
        {
            return User.SetPost();
        }

        public string IsSuccessSearch()
        {
            try
            {
                result = User.IsSuccessSearch(_view.OldLogin);
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
        }


        public string SaveChanges()
        {
            try
            {
                result = User.IsSuccessChangeData(_view.Surname, _view.Name, _view.Patronymic, _view.OldLogin, _view.NewPassword, _view.PhoneNumber, _view.Post);
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return string.Empty;

        }

        public string Success()
        {
            return User.SuccessChangeData();
        }

        public string Failure()
        {
            return User.Failure();
        }

        public string FailureSearch()
        {
            return User.FailureSearch();
        }
        public string IsRemoveUser()
        {
            try
            {
                result = User.IsRemoveUser(_view.OldLogin);
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return string.Empty;

        }

        public string SuccessRemove()
        {
            return User.SuccessRemove();
        }

        public string FailureRemove()
        {
            return User.FailureRemove();
        }
    }
}
