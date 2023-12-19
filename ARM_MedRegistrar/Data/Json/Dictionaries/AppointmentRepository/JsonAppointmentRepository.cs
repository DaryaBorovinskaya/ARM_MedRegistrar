using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.Appointments;
using ARM_MedRegistrar.Model.Patients;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using System.Text.Json;
using System.Collections.ObjectModel;

namespace ARM_MedRegistrar.Data.Json.Dictionaries.AppointmentRepository
{
    public class JsonAppointmentRepository : IAppointmentRepository
    {
        private readonly string _savePath;
        private IDictionary<uint, IAppointment>? _appointments;
        private JsonSerializerSettings _settings;
        public JsonAppointmentRepository(string savePath)
        {
            _savePath = savePath;
            _appointments = new SortedDictionary<uint, IAppointment>();
            _settings = new() { TypeNameHandling = TypeNameHandling.Auto };
          
        }

        public void Add(IAppointment value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (_appointments != null && _appointments.ContainsKey(value.Id))
                throw new ArgumentException("Логин занят");
            //JsonSerializerOptions options = new JsonSerializerOptions {WriteIndented = true};

            if (!File.Exists(_savePath))
            {
                File.Create(_savePath);
                _appointments = new SortedDictionary<uint, IAppointment>();
            }
            else
                _appointments = JsonConvert.DeserializeObject<SortedDictionary<uint, IAppointment>>(File.ReadAllText(_savePath), _settings);

            _appointments?.Add(value.Id, value);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, _settings));

            //File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, settings));
            //File.WriteAllText(_savePath, JsonSerializer.Serialize(_appointments, options));



            //_appointments = JsonConvert.DeserializeObject<IList<IAppointment>>(File.ReadAllText(_savePath), settings);
            //_appointments = JsonSerializer.Deserialize<IList<IAppointment>>(File.ReadAllText(_savePath), options);

            //File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, settings));

        }

        public IDictionary<uint, IAppointment>? GetAll()
        {
            if (!File.Exists(_savePath))
            {
                File.Create(_savePath);
                _appointments = new SortedDictionary<uint, IAppointment>();
            }
            else
                _appointments = JsonConvert.DeserializeObject<SortedDictionary<uint, IAppointment>>(File.ReadAllText(_savePath), _settings);
            return _appointments;
        }

        public void Remove(uint key)
        {
            if (_appointments == null)
                throw new ArgumentNullException(nameof(_appointments));
            if (!_appointments.ContainsKey(key) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");


            if (!File.Exists(_savePath))
            {
                File.Create(_savePath);
                _appointments = new SortedDictionary<uint, IAppointment>();
            }
            else
                _appointments = JsonConvert.DeserializeObject<SortedDictionary<uint, IAppointment>>(File.ReadAllText(_savePath), _settings);


            _appointments?.Remove(key);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, _settings));


        }

        public uint CreateId()
        {
            if (!File.Exists(_savePath))
                _appointments = new SortedDictionary<uint,IAppointment>();

            else
                _appointments = JsonConvert.DeserializeObject<SortedDictionary<uint, IAppointment>>(File.ReadAllText(_savePath), _settings);


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
