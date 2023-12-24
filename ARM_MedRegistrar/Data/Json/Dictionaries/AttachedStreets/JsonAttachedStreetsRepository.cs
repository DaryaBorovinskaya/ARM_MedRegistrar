
using Newtonsoft.Json;

using ARM_MedRegistrar.Model.AttachedStreets;
using ARM_MedRegistrar.Model.Appointments;
using ARM_MedRegistrar.Model.Persons.Doctors;

namespace ARM_MedRegistrar.Data.Json.Dictionaries.AttachedStreets
{
    public class JsonAttachedStreetsRepository : IBaseWithIdRepository<uint, IAttachedStreets>
    {
        private readonly string _savePath;
        private IDictionary<uint, IAttachedStreets>? _attachedStreets = new SortedDictionary<uint,IAttachedStreets>();
        private JsonSerializerSettings _settings;

        public JsonAttachedStreetsRepository()
        {
            _savePath = "attachedStreets.json";
            _attachedStreets = new SortedDictionary<uint, IAttachedStreets>();
            _settings = new() { TypeNameHandling = TypeNameHandling.Auto };

        }

        public void Create(IAttachedStreets value)
        {
            if (!File.Exists(_savePath))
                _attachedStreets = new SortedDictionary<uint, IAttachedStreets>();
            else
                _attachedStreets = JsonConvert.DeserializeObject<SortedDictionary<uint, IAttachedStreets>>(File.ReadAllText(_savePath), _settings);

            if (value == null)
                throw new ArgumentNullException(nameof(value));


            _attachedStreets?.Add(value.Id,value);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_attachedStreets, Formatting.Indented, _settings));

        }

        public IDictionary<uint, IAttachedStreets>? Read()
        {
            if (!File.Exists(_savePath))
                _attachedStreets = new SortedDictionary<uint, IAttachedStreets>();
            else
                _attachedStreets = JsonConvert.DeserializeObject<SortedDictionary<uint, IAttachedStreets>>(File.ReadAllText(_savePath), _settings);

            return _attachedStreets;
        }

        public bool Update(IAttachedStreets changedValue)
        {
            if (!File.Exists(_savePath))
                _attachedStreets = new SortedDictionary<uint, IAttachedStreets>();

            else
                _attachedStreets = JsonConvert.DeserializeObject<SortedDictionary<uint, IAttachedStreets>>(File.ReadAllText(_savePath), _settings);

            if (_attachedStreets != null && _attachedStreets.Count != 0)
            {
                _attachedStreets[changedValue.Id] = changedValue;
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_attachedStreets, Formatting.Indented, _settings));
                return true;
            }
            return false;
        }


        public void Delete(uint key)
        {
            if (!File.Exists(_savePath))
                _attachedStreets = new SortedDictionary<uint, IAttachedStreets>();
            else
                _attachedStreets = JsonConvert.DeserializeObject<SortedDictionary<uint,IAttachedStreets>>(File.ReadAllText(_savePath), _settings);

            
            if (_attachedStreets == null)
                throw new ArgumentNullException(nameof(_attachedStreets));
            if (!_attachedStreets.ContainsKey(key) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");


            _attachedStreets?.Remove(key);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_attachedStreets, Formatting.Indented, _settings));

        }


        public uint CreateId()
        {
            if (!File.Exists(_savePath))
                _attachedStreets = new SortedDictionary<uint, IAttachedStreets>();

            else
                _attachedStreets = JsonConvert.DeserializeObject<SortedDictionary<uint, IAttachedStreets>>(File.ReadAllText(_savePath), _settings);


            if (_attachedStreets == null)
                throw new ArgumentNullException(nameof(_attachedStreets));
            else if (_attachedStreets?.Count == 0)
                return 1;
            else if (_attachedStreets != null && _attachedStreets?.Count != 0)
                return _attachedStreets[_attachedStreets.Keys.Max()].Id + 1;

            return 0;
        }

    }
}
