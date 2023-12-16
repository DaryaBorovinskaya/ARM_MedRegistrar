using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.Appointments;
using ARM_MedRegistrar.Model.Patients;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using System.Text.Json;
using System.Collections.ObjectModel;

namespace ARM_MedRegistrar.Model.Json.AppointmentRepository
{
    public class JsonAppointmentRepository : IAppointmentRepository
    {
        private readonly string _savePath;
        private IDictionary<uint,IAppointment>? _appointments;

        private void LoadFromFile()
        {
            if (!File.Exists(_savePath))
            {
                File.Create(_savePath);
                _appointments = new Dictionary<uint, IAppointment>();
            }
            else
            {
                JsonSerializerSettings settings = new() { TypeNameHandling = TypeNameHandling.Auto };
                _appointments = JsonConvert.DeserializeObject<IDictionary<uint, IAppointment>>(File.ReadAllText(_savePath), settings);

            }
        }
        public JsonAppointmentRepository(string savePath)
        {
            _savePath = savePath;
            _appointments = new Dictionary<uint, IAppointment>();
            LoadFromFile();
        }

        public  void Add(uint key, IAppointment value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            //JsonSerializerOptions options = new JsonSerializerOptions {WriteIndented = true};

           
            _appointments?.Add(key,value);
                //File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, settings));
                //File.WriteAllText(_savePath, JsonSerializer.Serialize(_appointments, options));
            

            
                //_appointments = JsonConvert.DeserializeObject<IList<IAppointment>>(File.ReadAllText(_savePath), settings);
                //_appointments = JsonSerializer.Deserialize<IList<IAppointment>>(File.ReadAllText(_savePath), options);
                
                //File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, settings));
            


        }

        public  IDictionary<uint, IAppointment>? GetAll() => _appointments;
        
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
            //File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, settings));
            //File.WriteAllText(_savePath, JsonSerializer.Serialize(key));

        }

        public void WriteToFile()
        {
            JsonSerializerSettings settings = new() { TypeNameHandling = TypeNameHandling.Auto };
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, settings));
        }
    }
}
