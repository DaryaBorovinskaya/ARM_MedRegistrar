
using ARM_MedRegistrar.Model.Doctors;
using ARM_MedRegistrar.Model.Patients;
using Newtonsoft.Json;

namespace ARM_MedRegistrar.Model.Json.DoctorRepository
{
    public class JsonDoctorRepository : IDoctorRepository
    {
        private readonly string _savePath;
        private IList<IDoctor>? _doctors = new List< IDoctor>();
        public JsonDoctorRepository(string savePath)
        {
            _savePath = savePath;
        }

        public  void Add(IDoctor value)
        {
           

            if (value == null)
                throw new ArgumentNullException(nameof(value));



            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            if (!File.Exists(_savePath))
            {
                _doctors?.Add(value);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_doctors, Formatting.Indented, settings));
            }

            else
            {
                _doctors = JsonConvert.DeserializeObject<IList<IDoctor>>(File.ReadAllText(_savePath), settings);
                _doctors?.Add(value);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_doctors, Formatting.Indented, settings));
            }

        }

        public  IList<IDoctor>? GetAll()
        {
            if (!File.Exists(_savePath)) return new List<IDoctor>();

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            _doctors = JsonConvert.DeserializeObject<IList<IDoctor>>(File.ReadAllText(_savePath), settings);
            return _doctors;
        }

        public  void Remove(IDoctor value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (_doctors == null)
                throw new ArgumentNullException(nameof(_doctors));
            if (!_doctors.Contains(value) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");


            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            _doctors = JsonConvert.DeserializeObject<IList<IDoctor>>(File.ReadAllText(_savePath), settings);
            _doctors?.Remove(value);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_doctors, Formatting.Indented, settings));


        }
    }
}
