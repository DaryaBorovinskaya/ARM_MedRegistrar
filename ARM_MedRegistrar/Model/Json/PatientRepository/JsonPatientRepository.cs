using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_MedRegistrar.Model.Patients;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ARM_MedRegistrar.Model.Json.PatientRepository
{
    public class JsonPatientRepository : IPatientRepository
    {
        private readonly string _savePath;
        private IDictionary<int, IPatient>? _patients = new Dictionary<int, IPatient>();

        public JsonPatientRepository(string savePath)
        {
            _savePath = savePath;
        }

        public  void Add(IPatient element)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));

            if (value == null)
                throw new ArgumentNullException(nameof(value));

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

            if (!File.Exists(_savePath))
            {
                _patients?.Add(element);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_patients, Formatting.Indented, settings));
            }

            else
            {
                _patients = JsonConvert.DeserializeObject<List<IPatient>>(File.ReadAllText(_savePath), settings);
                _patients?.Add(element);
                File.WriteAllText(_savePath, JsonConvert.SerializeObject(_patients, Formatting.Indented, settings));
            }


        }

        public  IList<IPatient>? GetAll()
        {
            if (!File.Exists(_savePath)) return null;

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

            _patients = JsonConvert.DeserializeObject<List<IPatient>>(File.ReadAllText(_savePath), settings);
            return _patients;
        }

        public  void Remove(IPatient element)
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
