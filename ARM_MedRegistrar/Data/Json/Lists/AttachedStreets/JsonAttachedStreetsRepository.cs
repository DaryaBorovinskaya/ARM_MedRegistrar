﻿
using Newtonsoft.Json;

using ARM_MedRegistrar.Model.AttachedStreets;

namespace ARM_MedRegistrar.Data.Json.Lists.AttachedStreets
{
    public class JsonAttachedStreetsRepository : IAttachedStreetsRepository
    {
        private readonly string _savePath;
        private IList<IAttachedStreets>? _attachedStreets = new List<IAttachedStreets>();
        private JsonSerializerSettings _settings;

        public JsonAttachedStreetsRepository()
        {
            _savePath = "attachedStreets.json";
            _attachedStreets = new List<IAttachedStreets>();
            _settings = new() { TypeNameHandling = TypeNameHandling.Auto };
            
        }

        public void Add(IAttachedStreets value)
        {
            if (!File.Exists(_savePath))
                _attachedStreets = new List<IAttachedStreets>();
            else
                _attachedStreets = JsonConvert.DeserializeObject<IList<IAttachedStreets>>(File.ReadAllText(_savePath), _settings);

            if (value == null)
                throw new ArgumentNullException(nameof(value));

            
            _attachedStreets?.Add(value);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_attachedStreets, Formatting.Indented, _settings));

        }

        public IList<IAttachedStreets>? GetAll()
        {
            if (!File.Exists(_savePath))
                _attachedStreets = new List<IAttachedStreets>();
            else
                _attachedStreets = JsonConvert.DeserializeObject<IList<IAttachedStreets>>(File.ReadAllText(_savePath), _settings);

            return _attachedStreets; 
        }

        public void Remove(IAttachedStreets value)
        {
            if (!File.Exists(_savePath))
                _attachedStreets = new List<IAttachedStreets>();
            else
                _attachedStreets = JsonConvert.DeserializeObject<IList<IAttachedStreets>>(File.ReadAllText(_savePath), _settings);

            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (_attachedStreets == null)
                throw new ArgumentNullException(nameof(_attachedStreets));
            if (!_attachedStreets.Contains(value) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");
            
            
            _attachedStreets?.Remove(value);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_attachedStreets, Formatting.Indented, _settings));

        }


    }
}
