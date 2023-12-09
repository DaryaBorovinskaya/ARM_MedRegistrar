﻿
using Newtonsoft.Json;
using ARM_MedRegistrar.Model.Json.Repository;
using ARM_MedRegistrar.Model.AttachedStreets;

namespace ARM_MedRegistrar.Model.Json.JsonRepository
{
    public class JsonAttachedStreetsRepository : AttachedStreetsRepository
    {
        private readonly string _savePath;

        public JsonAttachedStreetsRepository(string savePath)
        {
            _savePath = savePath;
        }

        public override void Add(IAttachedStreets element)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

            if (!File.Exists(_savePath))
            {
                _attachedStreets?.Add(element);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_attachedStreets, Formatting.Indented, settings));
            }
            else
            {
                _attachedStreets = JsonConvert.DeserializeObject<IList<IAttachedStreets>>(File.ReadAllText(_savePath), settings);
                _attachedStreets?.Add(element);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_attachedStreets, Formatting.Indented, settings));
            }

            
        }

        public override IList<IAttachedStreets>? GetAll()
        {
            if (!File.Exists(_savePath)) return null;

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            _attachedStreets = JsonConvert.DeserializeObject<IList<IAttachedStreets>>(File.ReadAllText(_savePath), settings);
            return _attachedStreets;
        }

        public override void Remove(IAttachedStreets element)
        {
            if (element == null ) 
                throw new ArgumentNullException(nameof(element));
            if (_attachedStreets == null)
                throw new ArgumentNullException(nameof(_attachedStreets));
            if (!_attachedStreets.Contains(element) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");


            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            _attachedStreets = JsonConvert.DeserializeObject<IList<IAttachedStreets>>(File.ReadAllText(_savePath), settings);
            _attachedStreets?.Remove(element);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_attachedStreets, Formatting.Indented, settings));

            
        }


    }
}
