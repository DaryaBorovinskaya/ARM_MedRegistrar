
using Newtonsoft.Json;

using ARM_MedRegistrar.Model.AttachedStreets;
using Newtonsoft.Json.Linq;
using ARM_MedRegistrar.Model.Patients;

namespace ARM_MedRegistrar.Model.Json.AttachedStreets
{
    public class JsonAttachedStreetsRepository : IAttachedStreetsRepository
    {
        private readonly string _savePath;
        private IList< IAttachedStreets>? _attachedStreets = new List< IAttachedStreets>();
        public JsonAttachedStreetsRepository(string savePath)
        {
            _savePath = savePath;
        }

        public  void Add(IAttachedStreets value)
        {
            

            if (value == null)
                throw new ArgumentNullException(nameof(value));

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

            if (!File.Exists(_savePath))
            {
                _attachedStreets?.Add(value);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_attachedStreets, Formatting.Indented, settings));
            }
            else
            {
                _attachedStreets = JsonConvert.DeserializeObject<IList<IAttachedStreets>>(File.ReadAllText(_savePath), settings);
                _attachedStreets?.Add(value);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_attachedStreets, Formatting.Indented, settings));
            }


        }

        public  IList<IAttachedStreets>? GetAll()
        {
            if (!File.Exists(_savePath)) return new List<IAttachedStreets>();

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            _attachedStreets = JsonConvert.DeserializeObject<IList<IAttachedStreets>>(File.ReadAllText(_savePath), settings);
            return _attachedStreets;
        }

        public  void Remove(IAttachedStreets value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (_attachedStreets == null)
                throw new ArgumentNullException(nameof(_attachedStreets));
            if (!_attachedStreets.Contains(value) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");


            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            _attachedStreets = JsonConvert.DeserializeObject<IList<IAttachedStreets>>(File.ReadAllText(_savePath), settings);
            _attachedStreets?.Remove(value);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_attachedStreets, Formatting.Indented, settings));


        }


    }
}
