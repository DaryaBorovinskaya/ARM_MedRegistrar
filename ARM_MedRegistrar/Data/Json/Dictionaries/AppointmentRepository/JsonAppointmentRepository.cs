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
        private SortedDictionary<uint, IAppointment>? _appointments;
        private JsonSerializerSettings _settings;

        private void LoadFromFile()
        {
            if (!File.Exists(_savePath))
            {
                File.Create(_savePath);
                _appointments = new SortedDictionary<uint, IAppointment>();
            }
            else
                _appointments = JsonConvert.DeserializeObject<SortedDictionary<uint, IAppointment>>(File.ReadAllText(_savePath), _settings);

        }

        private void WriteToFile()
        {
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, _settings));
        }
        public JsonAppointmentRepository(string savePath)
        {
            _savePath = savePath;
            _appointments = new SortedDictionary<uint, IAppointment>();
            _settings = new() { TypeNameHandling = TypeNameHandling.Auto };
            LoadFromFile();
        }

        public void Add(IAppointment value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (_appointments != null && _appointments.ContainsKey(value.Id))
                throw new ArgumentException("Логин занят");
            //JsonSerializerOptions options = new JsonSerializerOptions {WriteIndented = true};


            _appointments?.Add(value.Id, value);
            WriteToFile();
            //File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, settings));
            //File.WriteAllText(_savePath, JsonSerializer.Serialize(_appointments, options));



            //_appointments = JsonConvert.DeserializeObject<IList<IAppointment>>(File.ReadAllText(_savePath), settings);
            //_appointments = JsonSerializer.Deserialize<IList<IAppointment>>(File.ReadAllText(_savePath), options);

            //File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, settings));

        }

        public SortedDictionary<uint, IAppointment>? GetAll() => _appointments;

        public void Remove(uint key)
        {
            if (_appointments == null)
                throw new ArgumentNullException(nameof(_appointments));
            if (!_appointments.ContainsKey(key) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");

            //JsonSerializerSettings settings = new() { TypeNameHandling = TypeNameHandling.Auto };
            //JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

            //_appointments = JsonSerializer.Deserialize<List<IAppointment>>(File.ReadAllText(_savePath), options);
            //_appointments = JsonConvert.DeserializeObject<IDictionary<uint, IAppointment>>(File.ReadAllText(_savePath), settings);
            _appointments?.Remove(key);
            WriteToFile();
            //File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, settings));
            //File.WriteAllText(_savePath, JsonSerializer.Serialize(key));

        }

        public uint CreateId()
        {
            if (_appointments == null) return 1;
            else return _appointments[_appointments.Keys.Max()].Id + 1;
        }
    }
}
