using ARM_MedRegistrar.Model.PaidMedServices;
using ARM_MedRegistrar.Model.Persons.Patients;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Data.Json.Dictionaries.PaidMedicalServiceRepository
{
    public class JsonPaidMedServiceRepository : IBaseRepositoryWithCreatedID<uint, IPaidMedService>
    {
        private readonly string _savePath;
        private IDictionary<uint, IPaidMedService>? _paidMedServices;
        private JsonSerializerSettings _settings;
        public JsonPaidMedServiceRepository()
        {
            _savePath = "paidMedServices.json";
            _paidMedServices = new SortedDictionary<uint, IPaidMedService>();
            _settings = new() { TypeNameHandling = TypeNameHandling.Auto };

        }

        public void Create(IPaidMedService value)
        {
            if (!File.Exists(_savePath))
                _paidMedServices = new SortedDictionary<uint, IPaidMedService>();

            else
                _paidMedServices = JsonConvert.DeserializeObject<SortedDictionary<uint, IPaidMedService>>(File.ReadAllText(_savePath), _settings);


            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (_paidMedServices != null && _paidMedServices.ContainsKey(value.Id))
                throw new ArgumentException("ID занят");


            _paidMedServices?.Add(value.Id, value);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_paidMedServices, Formatting.Indented, _settings));

        }

        public IDictionary<uint, IPaidMedService>? Read()
        {
            if (!File.Exists(_savePath))
                _paidMedServices = new SortedDictionary<uint, IPaidMedService>();

            else
                _paidMedServices = JsonConvert.DeserializeObject<SortedDictionary<uint, IPaidMedService>>(File.ReadAllText(_savePath), _settings);

            return _paidMedServices;
        }

        public bool Update(IPaidMedService changedValue)
        {

            if (!File.Exists(_savePath))
                _paidMedServices = new SortedDictionary<uint, IPaidMedService>();

            else
                _paidMedServices = JsonConvert.DeserializeObject<SortedDictionary<uint, IPaidMedService>>(File.ReadAllText(_savePath), _settings);

            if (_paidMedServices != null && _paidMedServices.Count != 0)
            {
                _paidMedServices[changedValue.Id] = changedValue;
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_paidMedServices, Formatting.Indented, _settings));
                return true;
            }
            return false;
        }
        public void Delete(uint key)
        {
            if (!File.Exists(_savePath))
                _paidMedServices = new SortedDictionary<uint, IPaidMedService>();

            else
                _paidMedServices = JsonConvert.DeserializeObject<SortedDictionary<uint, IPaidMedService>>(File.ReadAllText(_savePath), _settings);

            if (_paidMedServices == null)
                throw new ArgumentNullException(nameof(_paidMedServices));
            if (!_paidMedServices.ContainsKey(key) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");



            _paidMedServices?.Remove(key);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_paidMedServices, Formatting.Indented, _settings));

        }

        public uint CreateID()
        {
            if (!File.Exists(_savePath))
                _paidMedServices = new SortedDictionary<uint, IPaidMedService>();

            else
                _paidMedServices = JsonConvert.DeserializeObject<SortedDictionary<uint, IPaidMedService>>(File.ReadAllText(_savePath), _settings);


            if (_paidMedServices == null)
                throw new ArgumentNullException(nameof(_paidMedServices));
            else if (_paidMedServices?.Count == 0)
                return 1;
            else if (_paidMedServices != null && _paidMedServices?.Count != 0)
                return _paidMedServices[_paidMedServices.Keys.Max()].Id + 1;

            return 0;
        }
    }
}
