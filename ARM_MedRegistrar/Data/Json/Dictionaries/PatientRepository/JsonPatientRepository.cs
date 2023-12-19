﻿using ARM_MedRegistrar.Model.Patients;
using Newtonsoft.Json;


namespace ARM_MedRegistrar.Data.Json.Dictionaries.PatientRepository
{
    public class JsonPatientRepository : IPatientRepository
    {
        private readonly string _savePath;
        private IDictionary<uint, IPatient>? _patients;
        private JsonSerializerSettings _settings;
        public JsonPatientRepository(string savePath)
        {
            _savePath = savePath;
            _patients = new SortedDictionary<uint, IPatient>();
            _settings = new() { TypeNameHandling = TypeNameHandling.Auto };
            
        }

        public void Add(IPatient value)
        {
            if (!File.Exists(_savePath))
                _patients = new SortedDictionary<uint, IPatient>();

            else
                _patients = JsonConvert.DeserializeObject<SortedDictionary<uint, IPatient>>(File.ReadAllText(_savePath), _settings);


            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (_patients != null && _patients.ContainsKey(value.Id))
                throw new ArgumentException("Логин занят");

            
            _patients?.Add(value.Id, value);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_patients, Formatting.Indented, _settings));

        }

        public IDictionary<uint, IPatient>? GetAll()
        {
            if (!File.Exists(_savePath))
                _patients = new SortedDictionary<uint, IPatient>();

            else
                _patients = JsonConvert.DeserializeObject<SortedDictionary<uint, IPatient>>(File.ReadAllText(_savePath), _settings);

            return _patients;
        }


        public void Remove(uint key)
        {
            if (!File.Exists(_savePath))
                _patients = new SortedDictionary<uint, IPatient>();

            else
                _patients = JsonConvert.DeserializeObject<SortedDictionary<uint, IPatient>>(File.ReadAllText(_savePath), _settings);

            if (_patients == null)
                throw new ArgumentNullException(nameof(_patients));
            if (!_patients.ContainsKey(key) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");

            

            _patients?.Remove(key);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_patients, Formatting.Indented, _settings));

        }

        public uint CreateId()
        {
            if (!File.Exists(_savePath))
                _patients = new SortedDictionary<uint, IPatient>();

            else
                _patients = JsonConvert.DeserializeObject<SortedDictionary<uint, IPatient>>(File.ReadAllText(_savePath), _settings);


            if (_patients == null)
                throw new ArgumentNullException(nameof(_patients));
            else if (_patients?.Count == 0) 
                return 1;
            else if (_patients != null && _patients?.Count != 0) 
                return _patients[_patients.Keys.Max()].Id + 1;

            return 0;
        }
    }
}
