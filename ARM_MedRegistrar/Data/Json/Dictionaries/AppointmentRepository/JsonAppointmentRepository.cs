
using ARM_MedRegistrar.Model.Appointments;
using Newtonsoft.Json;

namespace ARM_MedRegistrar.Data.Json.Dictionaries.AppointmentRepository
{
    public class JsonAppointmentRepository : IBaseRepositoryWithCreatedID<uint, IAppointment> 
    {
        private readonly string _savePath;
        private IDictionary<uint, IAppointment>? _appointments;
        private JsonSerializerSettings _settings;

        private void Load()
        {
            if (!File.Exists(_savePath))
                _appointments = new Dictionary<uint, IAppointment>();
            else
                _appointments = JsonConvert.DeserializeObject<IDictionary<uint, IAppointment>>(File.ReadAllText(_savePath), _settings);

        }
        public JsonAppointmentRepository()
        {
            _savePath = "appointments.json";
            _appointments = new Dictionary<uint, IAppointment>();
            _settings = new() { TypeNameHandling = TypeNameHandling.Auto };
        }

        public void Create(IAppointment value)
        {
            Load();
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (_appointments != null && _appointments.ContainsKey(value.Id))
                throw new ArgumentException("ID занят");
            
            
            _appointments?.Add(value.Id, value);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, _settings));

        }

        public IDictionary<uint, IAppointment>? Read() 
        {
            Load();
            return _appointments; 
        }
        


        public bool Update(IAppointment changedValue)
        {
            Load();
            if (_appointments != null && _appointments.Count != 0)
            {
                _appointments[changedValue.Id] = changedValue;
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, _settings));
                return true;
            }
            return false;
        }

        public void Delete(uint key)
        {
            Load();

            if (_appointments == null)
                throw new ArgumentNullException(nameof(_appointments));
            if (!_appointments.ContainsKey(key) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");
            
            
            _appointments?.Remove(key);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, _settings));

        }

        public uint CreateID()
        {
            Load();

            if (_appointments == null)
                throw new ArgumentNullException(nameof(_appointments));
            else if (_appointments?.Count == 0)
                return 1;
            else if (_appointments != null && _appointments?.Count != 0)
                return _appointments[_appointments.Keys.Max()].Id + 1;

            return 0;
        }
    }
}
