using ARM_MedRegistrar.Model.Addresses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ARM_MedRegistrar.Model.Json.Repository;

namespace ARM_MedRegistrar.Model.Json.JsonRepository
{
    public class JsonAddressRepository : AddressRepository
    {
        private readonly string _savePath;

        public JsonAddressRepository(string savePath)
        {
            _savePath = savePath;
        }

        public override void Add(IAddress element)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

            if (!File.Exists(_savePath))
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_addresses, Formatting.Indented, settings));
            else
            {
                _addresses = JsonConvert.DeserializeObject<IList<IAddress>>(File.ReadAllText(_savePath), settings);
                _addresses?.Add(element);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_addresses, Formatting.Indented, settings));
            }

            
        }

        public override IList<IAddress>? GetAll()
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            _addresses = JsonConvert.DeserializeObject<IList<IAddress>>(File.ReadAllText(_savePath), settings);
            return _addresses;
        }

        public override void Remove(IAddress element)
        {
            if (element == null ) 
                throw new ArgumentNullException(nameof(element));
            if (_addresses == null)
                throw new ArgumentNullException(nameof(_addresses));
            if (!_addresses.Contains(element) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");


            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            _addresses = JsonConvert.DeserializeObject<IList<IAddress>>(File.ReadAllText(_savePath), settings);
            _addresses.Remove(element);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_addresses, Formatting.Indented, settings));

            
        }


    }
}
