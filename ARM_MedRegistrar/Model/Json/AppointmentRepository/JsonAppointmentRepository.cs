using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.Appointments;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using System.Text.Json;
using System.Collections.ObjectModel;

namespace ARM_MedRegistrar.Model.Json.AppointmentRepository
{
    public class JsonAppointmentRepository : IAppointmentRepository
    {
        private readonly string _savePath;
        private IDictionary<, IAppointment>? _appointments = new Dictionary<, IAppointment>();

        public JsonAppointmentRepository(string savePath)
        {
            _savePath = savePath;
        }

        public  void Add(DateTime key, IAppointment value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            JsonSerializerSettings settings = new() { TypeNameHandling = TypeNameHandling.Auto };
            //JsonSerializerOptions options = new JsonSerializerOptions {WriteIndented = true};

            if (!File.Exists(_savePath))
            {
                _appointments?.Add(key, value);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, settings));
                //File.WriteAllText(_savePath, JsonSerializer.Serialize(_appointments, options));
            }

            else
            {
                _appointments = JsonConvert.DeserializeObject<IDictionary<DateTime, IAppointment>>(File.ReadAllText(_savePath), settings);
                //_appointments = JsonSerializer.Deserialize<IList<IAppointment>>(File.ReadAllText(_savePath), options);
                _appointments?.Add(key, value);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, settings));
            }


        }

        public  IDictionary<DateTime, IAppointment>? GetAll()
        {
            if (!File.Exists(_savePath)) return null;

            //JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            JsonSerializerSettings settings = new() { TypeNameHandling = TypeNameHandling.Auto };

            _appointments = JsonConvert.DeserializeObject<IDictionary<DateTime, IAppointment>>(File.ReadAllText(_savePath), settings);
            //_appointments = JsonSerializer.Deserialize<IList<IAppointment>>(File.ReadAllText(_savePath), options);
            return _appointments;
        }

        public  void Remove(DateTime key)
        {
            if (_appointments == null)
                throw new ArgumentNullException(nameof(_appointments));
            if (!_appointments.ContainsKey(key) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");

            JsonSerializerSettings settings = new() { TypeNameHandling = TypeNameHandling.Auto };
            //JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

            //_appointments = JsonSerializer.Deserialize<List<IAppointment>>(File.ReadAllText(_savePath), options);
            _appointments = JsonConvert.DeserializeObject<IDictionary<DateTime, IAppointment>>(File.ReadAllText(_savePath), settings);
            _appointments?.Remove(key);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, settings));
            //File.WriteAllText(_savePath, JsonSerializer.Serialize(key));

        }
    }
}
