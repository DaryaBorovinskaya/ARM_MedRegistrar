using ARM_MedRegistrar.Model.Persons.Doctors;
using Newtonsoft.Json;

namespace ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository
{
    public class JsonDoctorRepository :  IBaseRepositoryWithCreatedID<uint, IDoctor>
    {
        private readonly string _savePath;
        private IDictionary<uint, IDoctor>? _doctors; 
        private JsonSerializerSettings _settings;

        private void Load()
        {
            if (!File.Exists(_savePath))
                _doctors = new SortedDictionary<uint, IDoctor>();
            else
                _doctors = JsonConvert.DeserializeObject<SortedDictionary<uint, IDoctor>>(File.ReadAllText(_savePath), _settings);

        }
        public JsonDoctorRepository()
        {
            _savePath = "doctors.json";
            _doctors = new SortedDictionary<uint, IDoctor>();
            _settings = new() { TypeNameHandling = TypeNameHandling.Auto };

            
        }

        public void Create(IDoctor value)
        {
            Load();
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (_doctors != null && _doctors.ContainsKey(value.DoctorDataOfAppointment.Id))
                throw new ArgumentException("ID занят");

            
            _doctors?.Add(value.DoctorDataOfAppointment.Id, value);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_doctors, Formatting.Indented, _settings));

        }

        public IDictionary<uint, IDoctor>? Read() 
        {
            Load();
            return _doctors; 
        }
        

        public bool Update(IDoctor changedValue)
        {
            Load();
            if (_doctors != null && _doctors.Count != 0)
            {
                _doctors[changedValue.DoctorDataOfAppointment.Id] = changedValue;
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_doctors, Formatting.Indented, _settings));
                return true;
            }
            return false;
        }
        public void Delete(uint key)
        {
            Load();
            if (_doctors == null)
                throw new ArgumentNullException(nameof(_doctors));
            if (!_doctors.ContainsKey(key) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");

            
            _doctors?.Remove(key);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_doctors, Formatting.Indented, _settings));

        }

        public uint CreateID()
        {
            Load();
            if (_doctors == null)
                throw new ArgumentNullException(nameof(_doctors));
            else if (_doctors?.Count == 0)
                return 1;
            else if (_doctors != null && _doctors?.Count != 0)
                return _doctors[_doctors.Keys.Max()].DoctorDataOfAppointment.Id + 1;

            return 0;
        }
    }
}
