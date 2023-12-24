using ARM_MedRegistrar.Model.Persons.Users;
using ARM_MedRegistrar.Model.Persons;
using Newtonsoft.Json;

namespace ARM_MedRegistrar.Data.Json.Dictionaries.UserRepository
{
    public class JsonUserRepository :  IBaseRepository<string, IUser> 
    {
        private readonly string _savePath;
        private IDictionary<string, IUser>? _users;
        private JsonSerializerSettings _settings;

        public JsonUserRepository()
        {
            _savePath = "users.json";
            _users = new Dictionary<string, IUser>() ;
            _settings = new() { TypeNameHandling = TypeNameHandling.Auto };
        }

        public void Create(IUser value)
        {
            if (!File.Exists(_savePath))
                _users = new Dictionary<string, IUser>();

            else
                _users = JsonConvert.DeserializeObject<IDictionary<string, IUser>>(File.ReadAllText(_savePath), _settings);

            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (_users != null && _users.ContainsKey(value.Login))
                throw new ArgumentException("Логин занят");

            
            _users?.Add(value.Login, value);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_users, Formatting.Indented, _settings));

        }

        public IDictionary<string, IUser>? Read()
        {

            if (!File.Exists(_savePath))
                _users = new Dictionary<string, IUser>();

            else
                _users = JsonConvert.DeserializeObject<IDictionary<string, IUser>>(File.ReadAllText(_savePath), _settings);
            return _users;
        }

        public bool Update(IUser changedValue)
        {

            if (!File.Exists(_savePath))
                _users = new Dictionary<string, IUser>();

            else
                _users = JsonConvert.DeserializeObject<IDictionary<string, IUser>>(File.ReadAllText(_savePath), _settings);

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
            if (!File.Exists(_savePath))
                _users = new Dictionary<string, IUser>();

            else
                _users = JsonConvert.DeserializeObject<IDictionary<string, IUser>>(File.ReadAllText(_savePath), _settings);

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
