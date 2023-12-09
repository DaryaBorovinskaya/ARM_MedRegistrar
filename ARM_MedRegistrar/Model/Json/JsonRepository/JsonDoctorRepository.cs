
using ARM_MedRegistrar.Model.Appointments;
using ARM_MedRegistrar.Model.Json.Repository;
using ARM_MedRegistrar.Model.Persons;
using Newtonsoft.Json;

namespace ARM_MedRegistrar.Model.Json.JsonRepository
{
    public class JsonDoctorRepository : DoctorRepository
    {
        private readonly string _savePath;

        public JsonDoctorRepository(string savePath)
        {
            _savePath = savePath;
        }

        public override void Add(IDoctor element)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));



            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            if (!File.Exists(_savePath))
            {
                _doctors?.Add(element);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_doctors, Formatting.Indented, settings));
            }

            else
            {
                _doctors = JsonConvert.DeserializeObject<IList<IDoctor>>(File.ReadAllText(_savePath), settings);
                _doctors?.Add(element);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_doctors, Formatting.Indented, settings));
            }

        }

        public override IList<IDoctor>? GetAll()
        {
            if (!File.Exists(_savePath)) return null;

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            _doctors = JsonConvert.DeserializeObject<IList<IDoctor>>(File.ReadAllText(_savePath), settings);
            return _doctors;
        }

        public override void Remove(IDoctor element)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));
            if (_doctors == null)
                throw new ArgumentNullException(nameof(_doctors));
            if (!_doctors.Contains(element) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");


            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            _doctors = JsonConvert.DeserializeObject<IList<IDoctor>>(File.ReadAllText(_savePath), settings);
            _doctors.Remove(element);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_doctors, Formatting.Indented, settings));

           
        }
    }
}
