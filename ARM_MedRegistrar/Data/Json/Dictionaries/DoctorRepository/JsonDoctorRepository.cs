using ARM_MedRegistrar.Model.Doctors;
using ARM_MedRegistrar.Model.Patients;
using Newtonsoft.Json;

namespace ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository
{
    public class JsonDoctorRepository : IDoctorRepository
    {
        private readonly string _savePath;
        private SortedDictionary<uint, IDoctor>? _doctors; 
        private JsonSerializerSettings _settings;


        private void LoadFromFile()
        {
            if (!File.Exists(_savePath))
                _doctors = new();
            else
                _doctors = JsonConvert.DeserializeObject<SortedDictionary<uint, IDoctor>>(File.ReadAllText(_savePath), _settings);
        }

        private void WriteToFile()
        {
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_doctors, Formatting.Indented, _settings));
        }


        public JsonDoctorRepository(string savePath)
        {
            _savePath = savePath;
            _doctors = new();
            _settings = new() { TypeNameHandling = TypeNameHandling.Auto };
            LoadFromFile();
        }

        public void Add(IDoctor value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (_doctors != null && _doctors.ContainsKey(value.Id))
                throw new ArgumentException("Логин занят");
            _doctors?.Add(value.Id, value);
            WriteToFile();
        }

        public SortedDictionary<uint,IDoctor>? GetAll() => _doctors;
        

        public void Remove(uint key)
        {
            if (_doctors == null)
                throw new ArgumentNullException(nameof(_doctors));
            if (!_doctors.ContainsKey(key) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");

            _doctors?.Remove(key);
            WriteToFile() ;
        }

        public uint CreateId()
        {
            if (_doctors == null) return 1;
            else return _doctors[_doctors.Keys.Max()].Id + 1;
        }
    }
}
