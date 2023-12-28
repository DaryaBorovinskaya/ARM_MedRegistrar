using ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans;
using ARM_MedRegistrar.Model.Persons.Users;
using ARM_MedRegistrar.Model.Persons;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Data.Json.Dictionaries.UserRepository
{
    public class JsonCurrentUserRepository 
    {
        private readonly string _savePath;
        private User? _user;
        private JsonSerializerSettings _settings;

        private void Load()
        {
            if (!File.Exists(_savePath))
                _user = null;
            else
                _user = JsonConvert.DeserializeObject<User>(File.ReadAllText(_savePath), _settings);

        }
        public JsonCurrentUserRepository()
        {
            _savePath = "currentUser.json";
            _settings = new() { TypeNameHandling = TypeNameHandling.Auto };
        }

        public void Create(User value)
        {
            Load();
            if (value == null)
                throw new ArgumentException("Нулевое значение");

            _user = value;
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_user, Formatting.Indented, _settings));

        }

        public User? Read()
        {
            Load();
            return _user;
        }


        public void Delete(User user)
        {
            Load();
            
            if (_user == null)
                throw new ArgumentException("Нулевое значение");
            if (!File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");

            _user = null;
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_user, Formatting.Indented, _settings));
        }
    }
    
}
