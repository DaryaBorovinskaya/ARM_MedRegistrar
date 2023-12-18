using ARM_MedRegistrar.Model.Persons;
using Newtonsoft.Json;

namespace ARM_MedRegistrar.Data.Json.Dictionaries.UserRepository
{
    public class JsonUserRepository : IUserRepository
    {
        private readonly string _savePath;
        private SortedDictionary<string, IUser>? _users;
        private JsonSerializerSettings _settings;

        public JsonUserRepository(string savePath)
        {
            _savePath = savePath;
            _users = new();
            _settings = new() { TypeNameHandling = TypeNameHandling.Auto };
        }

        public void Add(IUser value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (_users != null && _users.ContainsKey(value.Login))
                throw new ArgumentException("Логин занят");


            if (!File.Exists(_savePath))
                _users = new();

            else
                _users = JsonConvert.DeserializeObject<SortedDictionary<string, IUser>>(File.ReadAllText(_savePath), _settings);

            _users?.Add(value.Login, value);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_users, Formatting.Indented, _settings));

            //JsonSerializerSettings settings = new() { TypeNameHandling = TypeNameHandling.Auto };

            //if (!File.Exists(_savePath))
            //{
            //    _users?.Add(key, value);
            //    File.WriteAllText(_savePath, JsonConvert.SerializeObject(_users, Formatting.Indented, settings));
            //}

            //else
            //{
            //    _users = JsonConvert.DeserializeObject<IDictionary<string, IUser>>(File.ReadAllText(_savePath), settings);
            //    _users?.Add(key, value);
            //    File.WriteAllText(_savePath, JsonConvert.SerializeObject(_users, Formatting.Indented, settings));
            //}


        }

        public SortedDictionary<string, IUser>? GetAll()
        {

            if (!File.Exists(_savePath))
                _users = new();

            else
                _users = JsonConvert.DeserializeObject<SortedDictionary<string, IUser>>(File.ReadAllText(_savePath), _settings);
            return _users;
        }

        //if (!File.Exists(_savePath)) return new Dictionary<string, IUser>();

        //JsonSerializerSettings settings = new() { TypeNameHandling = TypeNameHandling.Auto };

        //_users = JsonConvert.DeserializeObject<IDictionary<string, IUser>>(File.ReadAllText(_savePath), settings);

        //return _users;


        public void Remove(string key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));
            if (_users == null)
                throw new ArgumentNullException(nameof(_users));
            if (!_users.ContainsKey(key) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");

            //JsonSerializerSettings settings = new() { TypeNameHandling = TypeNameHandling.Auto };

            //_users = JsonConvert.DeserializeObject<IDictionary<string, IUser>>(File.ReadAllText(_savePath), settings);

            if (!File.Exists(_savePath))
                _users = new();

            else
                _users = JsonConvert.DeserializeObject<SortedDictionary<string, IUser>>(File.ReadAllText(_savePath), _settings);
            _users?.Remove(key);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_users, Formatting.Indented, _settings));

            //File.WriteAllText(_savePath, JsonConvert.SerializeObject(_users, Formatting.Indented, settings));


        }



    }
}
