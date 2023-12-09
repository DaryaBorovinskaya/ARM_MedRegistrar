
using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.Appointments;
using ARM_MedRegistrar.Model.Json.Repository;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace ARM_MedRegistrar.Model.Json.JsonRepository
{
    public class JsonAppointmentRepository : AppointmentRepository
    {
        private readonly string _savePath;

        public JsonAppointmentRepository(string savePath)
        {
            _savePath = savePath;
        }

        public override void Add(IAppointment element)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

            if (!File.Exists(_savePath))
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, settings));
            else
            {
                _appointments = JsonConvert.DeserializeObject<IList<IAppointment>>(File.ReadAllText(_savePath), settings);
                _appointments?.Add(element);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, settings));
            }

            
        }

        public override IList<IAppointment>? GetAll()
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

            _appointments = JsonConvert.DeserializeObject<IList<IAppointment>>(File.ReadAllText(_savePath), settings);
            return _appointments;
        }

        public override void Remove(IAppointment element)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));
            if (_appointments == null)
                throw new ArgumentNullException(nameof(_appointments));
            if (!_appointments.Contains(element) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

            _appointments = JsonConvert.DeserializeObject<List<IAppointment>>(File.ReadAllText(_savePath), settings);
            _appointments.Remove(element);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_appointments, Formatting.Indented, settings));

            
        }
    }
}
