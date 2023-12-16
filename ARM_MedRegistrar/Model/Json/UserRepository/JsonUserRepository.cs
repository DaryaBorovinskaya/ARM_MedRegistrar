using ARM_MedRegistrar.Model.Appointments;
using ARM_MedRegistrar.Model.Persons;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM_MedRegistrar.Model.Json.UserRepository
{
    public class JsonUserRepository : IBaseRepository<string,IUser>
    {
        private readonly string _savePath;

        private IDictionary<string, IUser>? _users;

        void IBaseRepository<string, IUser>.LoadFromFile()
        {
            
            if (File.Exists(_savePath))
            {
                JsonSerializerSettings settings = new() { TypeNameHandling = TypeNameHandling.Auto };
                _users = JsonConvert.DeserializeObject<IDictionary<string, IUser>>(File.ReadAllText(_savePath), settings);

            }
        }
        public JsonUserRepository(string savePath)
        {
            _savePath = savePath;
            _users = new Dictionary<string, IUser>();
            LoadFromFile();
        }

        public void Add( IUser value)
        {
            
            if (value == null)
                throw new ArgumentNullException(nameof(value));


            if (_users.ContainsKey(value.Login)) throw new ArgumentException("Логин занят");
                
                    
            _users?.Add(value.Login, value);
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

        public IDictionary<string, IUser>? GetAll() => _users;
        
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
            _users?.Remove(key);
            //File.WriteAllText(_savePath, JsonConvert.SerializeObject(_users, Formatting.Indented, settings));


        }


        public void WriteToFile()
        {
            JsonSerializerSettings settings = new() { TypeNameHandling = TypeNameHandling.Auto };
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_users, Formatting.Indented, settings));
        }
    }
}
