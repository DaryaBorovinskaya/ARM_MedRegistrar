using ARM_MedRegistrar.Model.Json.Repository;
using ARM_MedRegistrar.Model.Persons;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Json.JsonRepository
{
    public class JsonUserRepository : UserRepository
    {
        private readonly string _savePath;

        public JsonUserRepository(string savePath)
        {
            _savePath = savePath;
        }

        public override void Add(IUser element)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

            if (!File.Exists(_savePath))
            {
                _users?.Add(element);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_users, Formatting.Indented, settings));
            }

            else
            {
                _users = JsonConvert.DeserializeObject<IList<IUser>>(File.ReadAllText(_savePath), settings);
                _users?.Add(element);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_users, Formatting.Indented, settings));
            }

            
        }

        public override IList<IUser>? GetAll()
        {
            if (!File.Exists(_savePath)) return null;

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

            _users = JsonConvert.DeserializeObject<IList<IUser>>(File.ReadAllText(_savePath), settings);
            return _users;
        }

        public override void Remove(IUser element)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));
            if (_users == null)
                throw new ArgumentNullException(nameof(_users));
            if (!_users.Contains(element) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

            _users = JsonConvert.DeserializeObject<IList<IUser>>(File.ReadAllText(_savePath), settings);
            _users.Remove(element);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_users, Formatting.Indented, settings));

            
        }
    }
}
