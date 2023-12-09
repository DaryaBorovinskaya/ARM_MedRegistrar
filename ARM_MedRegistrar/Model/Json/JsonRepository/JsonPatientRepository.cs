using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_MedRegistrar.Model.Json.Repository;
using ARM_MedRegistrar.Model.Persons;
using Newtonsoft.Json;

namespace ARM_MedRegistrar.Model.Json.JsonRepository
{
    public class JsonPatientRepository : PatientRepository
    {
        private readonly string _savePath;

        public JsonPatientRepository(string savePath)
        {
            _savePath = savePath;
        }

        public override void Add(IPatient element)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

            if (!File.Exists(_savePath))
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_patients, Formatting.Indented, settings));
            else
            {
                _patients = JsonConvert.DeserializeObject<List<IPatient>>(File.ReadAllText(_savePath), settings);
                _patients?.Add(element);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_patients, Formatting.Indented, settings));
            }

            
        }

        public override IList<IPatient>? GetAll()
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

            _patients = JsonConvert.DeserializeObject<List<IPatient>>(File.ReadAllText(_savePath), settings);
            return _patients;
        }

        public override void Remove(IPatient element)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));
            if (_patients == null)
                throw new ArgumentNullException(nameof(_patients));
            if (!_patients.Contains(element) || !File.Exists(_savePath))
                throw new Exception("Не удалось удалить объект из файла: удаляемый элемент или/и файл не найдены");


            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

            _patients = JsonConvert.DeserializeObject<List<IPatient>>(File.ReadAllText(_savePath), settings);
            _patients.Remove(element);
            File.WriteAllText(_savePath, JsonConvert.SerializeObject(_patients, Formatting.Indented, settings));

           
        }
    }
}
