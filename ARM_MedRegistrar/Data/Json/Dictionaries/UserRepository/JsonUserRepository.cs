using ARM_MedRegistrar.Model.Persons.Users;
using ARM_MedRegistrar.Model.Persons;
using Newtonsoft.Json;
using ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans;
using System.Windows.Forms;

namespace ARM_MedRegistrar.Data.Json.Dictionaries.UserRepository
{
    public class JsonUserRepository :  IBaseRepository<string, IUser> 
    {
        private readonly string _savePath;
        private IDictionary<string, IUser>? _users;
        private JsonSerializerSettings _settings;

        private void Load()
        {
            if (!File.Exists(_savePath))
                _users = new Dictionary<string, IUser>();
            else
                _users = JsonConvert.DeserializeObject<IDictionary<string, IUser>>(File.ReadAllText(_savePath), _settings);

        }
        public JsonUserRepository()
        {
            _savePath = "users.json";
            _users = new Dictionary<string, IUser>() ;
            _settings = new() { TypeNameHandling = TypeNameHandling.Auto };

            if (!File.Exists(_savePath))
            {
                IFullName _fullName = new FullName("Боровинская", "Дарья", "Игоревна");
                IPersonalData _personalData = new PersonalData(_fullName, "123456789");
                byte[] _salt = GeneratingSalt.GenerateSalt();
                string _saltPassword = GeneratingSaltPassword.GenerateSaltPassword("1", _salt);
                IUser _user = new User(_personalData, "1", _salt, _saltPassword, "системный администратор");
                _users?.Add("1", _user);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_users, Formatting.Indented, _settings));
            }
            
                
        }

        public void Create(IUser value)
        {
            Load();
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (_users != null && _users.ContainsKey(value.Login))
                throw new ArgumentException("Логин занят");

            
            _users?.Add(value.Login, value);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_users, Formatting.Indented, _settings));

        }

        public IDictionary<string, IUser>? Read()
        {
            Load();
            return _users;
        }
        

        public bool Update(IUser changedValue)
        {
            Load();
            if (_users != null && _users.Count != 0)
            {
                _users[changedValue.Login] = changedValue;
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_users, Formatting.Indented, _settings));
                return true;
            }
            return false;
        }
        public void Delete(string key)
        {
            Load();
            if (key == null)
                throw new ArgumentNullException(nameof(key));
            if (_users == null)
                throw new ArgumentNullException(nameof(_users));
            if (!_users.ContainsKey(key) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");


            _users?.Remove(key);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_users, Formatting.Indented, _settings));

        }

        
    }
}
