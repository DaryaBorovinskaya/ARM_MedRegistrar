using ARM_MedRegistrar.Data.Json.Dictionaries;
using ARM_MedRegistrar.Data.Json.Dictionaries.UserRepository;
using ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans;
using ARM_MedRegistrar.Presenter.ChangeDataOfUsers;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ARM_MedRegistrar.Model.Persons.Users
{

    public class User : IUser
    {
        static IChangeDataOfUserPresenter _presenter;
        private IPersonalData _personalData;
        private string _post;
        private string _login;

        public IPersonalData PersonalData 
        {
            get => _personalData;
            set
            {
                if (value == null)
                    throw new ArgumentException("Попытка присвоить значение null полю Персональные данные");
                _personalData = value;
            }
        }
        public string Login
        {
            get => _login;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Логин не задан");
                for (int i = 0; i < value.Length; i++)
                    if (value[i] == (int)Keys.Space)
                        throw new ArgumentException("Логин не должен содержать пробелы");

                _login = value;
            }
        }
        public string SaltPassword { get; set; }
        public string Post 
        {
            get => _post;
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Должность не задана");
                
                _post = value;
            }
}

        public byte[] Salt { get; set; }


        public User()
        {

        }

        public User(IChangeDataOfUserPresenter presenter)
        {
            _presenter = presenter;
        }


        [JsonConstructor]
        public User(IPersonalData personalData, string login, byte[] salt, string saltPassword, string post)
        {
            PersonalData = personalData;
            Login = login;
            Post = post;
            Salt = salt;
            SaltPassword = saltPassword;
        }




        public static string IsSuccessRegistration(string surname, string name, string? patronymic, string login, string password, string phoneNumber , string post)
        {
            IBaseRepository<string, IUser> _jsonUserRepository = new JsonUserRepository();
            IDictionary<string, IUser>? _users;
            IUser _newUser;
            byte[] _salt;
            string _saltPassword;

            _users = _jsonUserRepository.Read();
            for (int i = 0; i < password.Length; i++)
                if (password[i] == (int)Keys.Space)
                    throw new ArgumentException("Пароль не должен содержать пробелы");

            if (_users != null && _users.Count != 0)
            {
                foreach (string key in _users.Keys)
                {
                    if (key == login)
                        throw new ArgumentException("Такой логин уже используется");
                    
                    if (post == SetPost()[1] && _users[key].Post == SetPost()[1])
                        throw new ArgumentException("Пользователь с должностью \"заведующий регистратурой\" уже существует");
                }

            }

            _salt = GeneratingSalt.GenerateSalt();
            _saltPassword = GeneratingSaltPassword.GenerateSaltPassword(password, _salt);

            try
            {
                _newUser = new User(new PersonalData(new FullName(surname, name, patronymic), phoneNumber), login, _salt, _saltPassword, post);
                _jsonUserRepository.Create(_newUser);
            }
            catch (ArgumentException e) 
            {
                return e.Message;
            }
            
            return string.Empty;
            
        }

       



        public static string SuccessRegistration(string post)
        {
            return $"Вы успешно зарегистрированы (должность {post})";
        }


        public static string FailureSearch()
        {
            return "Не удалось найти пользователя";
        }

        public static string IsSuccessSearch(string login)
        {
            IBaseRepository<string, IUser> _jsonUserRepository = new JsonUserRepository(); ;
            IDictionary<string, IUser>? _users;
            _users = _jsonUserRepository.Read();
            if (_users == null || _users.Count == 0)
                throw new ArgumentException("Список пользователей пуст");

            if (_users != null && _users.Count != 0)
            {
                foreach (string key in _users.Keys)
                    if (Equals(key.Length, login.Length) && Equals(key, login))
                    {
                        _presenter.Surname = _users[key].PersonalData.FullName.Surname;
                        _presenter.Name = _users[key].PersonalData.FullName.Name;
                        _presenter.Patronymic = _users[key].PersonalData.FullName.Patronymic;
                        _presenter.NewLogin = _users[key].Login;
                        _presenter.Post = _users[key].Post;
                        _presenter.PhoneNumber = _users[key].PersonalData.PhoneNumber;
                        return string.Empty;
                    }
            }
            throw new ArgumentException("Список пользователей пуст");
        }

        public static string IsSuccessChangeData(string surname, string name, string? patronymic, string login, string password, string phoneNumber, string post)
        {
            string _saltPassword;
            IBaseRepository<string, IUser> _jsonUserRepository = new JsonUserRepository();
            IDictionary<string, IUser>? _users;
            _users = _jsonUserRepository.Read();

            for (int i = 0; i < password.Length; i++)
                if (password[i] == (int)Keys.Space)
                    throw new ArgumentException("Пароль не должен содержать пробелы");

            if (_users != null && _users.Count != 0)
            {
                foreach (string key in _users.Keys)
                {
                    if (post == SetPost()[1])
                        throw new ArgumentException("Пользователь с должностью \"заведующий регистратурой\" уже существует");
                    if (Equals(key.Length, login.Length) && Equals(key, login))
                    {
                        _saltPassword = GeneratingSaltPassword.GenerateSaltPassword(password, _users[key].Salt);
                        try
                        {
                            _users[key].PersonalData.FullName.Surname = surname;
                            _users[key].PersonalData.FullName.Name = name;
                            _users[key].PersonalData.FullName.Patronymic = patronymic;
                            _users[key].PersonalData.PhoneNumber = phoneNumber;
                            _users[key].SaltPassword = _saltPassword;
                            _users[key].Post = post;
                        }
                        catch (ArgumentException e)
                        {
                            return e.Message;
                        }
                        _jsonUserRepository.Update(_users[key]);
                        return string.Empty;
                    }
                }
            }
            throw new ArgumentException("Список пользователей пуст");
            
        }


        public static string SuccessChangeData()
        {
            return "Данные успешно обновлены";
        }

        public static string Failure()
        {
            return "Не удалось внести изменения";
        }



        public static string IsRemoveUser(string login)
        {
            IBaseRepository<string, IUser> _jsonUserRepository = new JsonUserRepository();
            IDictionary<string, IUser>? _users;

            _users = _jsonUserRepository.Read();
            if (_users != null && _users.Count != 0)
            {
                foreach (string key in _users.Keys)
                {
                    if (Equals(key.Length, login.Length) && Equals(key, login))
                    {
                        _jsonUserRepository.Delete(key);   
                        return string.Empty;
                    }
                }
            }
            throw new ArgumentException("Список пользователей пуст");

        }

        public static string SuccessRemove()
        {
            return "Удаление выполнено успешно";
        }

        public static string FailureRemove()
        {
            return "Не удалось удалить";
        }


        public static string IsSuccessLogIn(string login, string password)
        {
            IBaseRepository<string, IUser> _jsonUserRepository = new JsonUserRepository();
            IDictionary<string, IUser>? _users;


            for (int i = 0; i < login.Length; i++)
                if (login[i] == (int)Keys.Space)
                    throw new ArgumentException("Логин не должен содержать пробелы");
            for (int i = 0; i < password.Length; i++)
                if (password[i] == (int)Keys.Space)
                    throw new ArgumentException("Пароль не должен содержать пробелы");
            string saltedPassword;
            _users = _jsonUserRepository.Read();
            if (_users == null || _users.Count == 0)
                throw new ArgumentException("Список пользователей пуст");
            else
            {
                foreach (string key in _users.Keys)
                    if (Equals(key.Length, login.Length) && Equals(key, login))
                    {
                        saltedPassword = GeneratingSaltPassword.GenerateSaltPassword(password, _users[key].Salt);
                        if (saltedPassword == _users[key].SaltPassword)
                            return string.Empty;
                    }
            }
            throw new ArgumentException("Список пользователей пуст");

        }


        public static IList<string> SetPost()
        {
            return new List<string> { "медицинский регистратор", "заведующий регистратурой" };
        }

    }
}
