using ARM_MedRegistrar.Model.Persons.Doctors;
using ARM_MedRegistrar.Model.WorkSchedules;
using Newtonsoft.Json;
using ARM_MedRegistrar.Model.FreeTimeOfAppointments;

namespace ARM_MedRegistrar.Data.Json.Dictionaries.FreeTimeOfAppointments
{
    public class JsonFreeTimeOfAppointmentRepository : IFreeTimeOfAppointmentRepository
    {
        private readonly string _savePath;
        private IDictionary<uint, IList<IFreeTimeOfAppointment>>? _freeTimeOfAppointments;
        private JsonSerializerSettings _settings;

        public JsonFreeTimeOfAppointmentRepository()
        {
            _savePath = "freeTimeOfAppointment.json";
            _freeTimeOfAppointments = new SortedDictionary<uint, IList<IFreeTimeOfAppointment>>();
            _settings = new() { TypeNameHandling = TypeNameHandling.Auto };

        }

        public void Add(uint key, IList<IFreeTimeOfAppointment> value)
        {
            if (!File.Exists(_savePath))
                _freeTimeOfAppointments = new SortedDictionary<uint, IList<IFreeTimeOfAppointment>>();
            else
                _freeTimeOfAppointments = JsonConvert.DeserializeObject<SortedDictionary<uint, IList<IFreeTimeOfAppointment>>>(File.ReadAllText(_savePath), _settings);

            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (_freeTimeOfAppointments != null && _freeTimeOfAppointments.ContainsKey(key))
                throw new ArgumentException("ID занят");


            _freeTimeOfAppointments?.Add(key, value);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_freeTimeOfAppointments, Formatting.Indented, _settings));

        }

        public IDictionary<uint, IList<IFreeTimeOfAppointment>>? GetAll()
        {
            if (!File.Exists(_savePath))
                _freeTimeOfAppointments = new SortedDictionary<uint, IList<IFreeTimeOfAppointment>>();
            else
                _freeTimeOfAppointments = JsonConvert.DeserializeObject<SortedDictionary<uint, IList<IFreeTimeOfAppointment>>>(File.ReadAllText(_savePath), _settings);
            return _freeTimeOfAppointments;
        }

        public bool SaveChangedData(uint key, IList<IFreeTimeOfAppointment> changedValue)
        {

            if (!File.Exists(_savePath))
                _freeTimeOfAppointments = new SortedDictionary<uint, IList<IFreeTimeOfAppointment>>();

            else
                _freeTimeOfAppointments = JsonConvert.DeserializeObject<SortedDictionary<uint, IList<IFreeTimeOfAppointment>>>(File.ReadAllText(_savePath), _settings);

            if (_freeTimeOfAppointments != null && _freeTimeOfAppointments.Count != 0)
            {
                _freeTimeOfAppointments[key] = changedValue;
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_freeTimeOfAppointments, Formatting.Indented, _settings));
                return true;
            }
            return false;
        }
        public void Remove(uint key)
        {
            if (!File.Exists(_savePath))
                _freeTimeOfAppointments = new SortedDictionary<uint, IList<IFreeTimeOfAppointment>>();
            else
                _freeTimeOfAppointments = JsonConvert.DeserializeObject<SortedDictionary<uint, IList<IFreeTimeOfAppointment>>>(File.ReadAllText(_savePath), _settings);


            if (_freeTimeOfAppointments == null)
                throw new ArgumentNullException(nameof(_freeTimeOfAppointments));
            if (!_freeTimeOfAppointments.ContainsKey(key) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");


            _freeTimeOfAppointments?.Remove(key);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_freeTimeOfAppointments, Formatting.Indented, _settings));

        }

        
    }
}
