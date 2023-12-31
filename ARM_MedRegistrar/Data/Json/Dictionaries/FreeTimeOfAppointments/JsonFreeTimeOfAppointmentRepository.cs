﻿using ARM_MedRegistrar.Model.Persons.Doctors;
using ARM_MedRegistrar.Model.WorkSchedules;
using Newtonsoft.Json;
using ARM_MedRegistrar.Model.FreeTimeOfAppointments;

namespace ARM_MedRegistrar.Data.Json.Dictionaries.FreeTimeOfAppointments
{
    public class JsonFreeTimeOfAppointmentRepository : IBaseRepository<uint, IFreeTimeOfAppointment>
    {
        private readonly string _savePath;
        private IDictionary<uint, IFreeTimeOfAppointment>? _freeTimeOfAppointments;
        private JsonSerializerSettings _settings;

        private void Load()
        {
            if (!File.Exists(_savePath))
                _freeTimeOfAppointments = new Dictionary<uint, IFreeTimeOfAppointment>();
            else
                _freeTimeOfAppointments = JsonConvert.DeserializeObject<IDictionary<uint, IFreeTimeOfAppointment>>(File.ReadAllText(_savePath), _settings);

        }
        public JsonFreeTimeOfAppointmentRepository()
        {
            _savePath = "freeTimeOfAppointment.json";
            _freeTimeOfAppointments = new Dictionary<uint, IFreeTimeOfAppointment>();
            _settings = new() { TypeNameHandling = TypeNameHandling.Auto };

            
        }

        public void Create( IFreeTimeOfAppointment value)
        {
            Load();
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (_freeTimeOfAppointments != null && _freeTimeOfAppointments.ContainsKey(value.Id))
                throw new ArgumentException("ID занят");


            _freeTimeOfAppointments?.Add(value.Id, value);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_freeTimeOfAppointments, Formatting.Indented, _settings));

        }

        public IDictionary<uint, IFreeTimeOfAppointment>? Read()
        {
            Load();
            return _freeTimeOfAppointments; 
        }
        

        public bool Update( IFreeTimeOfAppointment changedValue)
        {
            Load();
            if (_freeTimeOfAppointments != null && _freeTimeOfAppointments.Count != 0)
            {
                _freeTimeOfAppointments[changedValue.Id] = changedValue;
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_freeTimeOfAppointments, Formatting.Indented, _settings));
                return true;
            }
            return false;
        }
        public void Delete(uint key)
        {
            Load();
            if (_freeTimeOfAppointments == null)
                throw new ArgumentNullException(nameof(_freeTimeOfAppointments));
            if (!_freeTimeOfAppointments.ContainsKey(key) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");


            _freeTimeOfAppointments?.Remove(key);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_freeTimeOfAppointments, Formatting.Indented, _settings));

        }

        
    }
}
