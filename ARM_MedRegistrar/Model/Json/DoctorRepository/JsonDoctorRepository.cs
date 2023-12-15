
using ARM_MedRegistrar.Model.Doctors;
using Newtonsoft.Json;

namespace ARM_MedRegistrar.Model.Json.DoctorRepository
{
    public class JsonDoctorRepository : IDoctorRepository
    {
        private readonly string _savePath;
        private IDictionary<int, IDoctor>? _doctors = new Dictionary<int, IDoctor>();
        public JsonDoctorRepository(string savePath)
        {
            _savePath = savePath;
        }

        public  void Add(IDoctor element)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));

            if (value == null)
                throw new ArgumentNullException(nameof(value));



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

        public  IList<IDoctor>? GetAll()
        {
            if (!File.Exists(_savePath)) return null;

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            _doctors = JsonConvert.DeserializeObject<IList<IDoctor>>(File.ReadAllText(_savePath), settings);
            return _doctors;
        }

        public  void Remove(IDoctor element)
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
