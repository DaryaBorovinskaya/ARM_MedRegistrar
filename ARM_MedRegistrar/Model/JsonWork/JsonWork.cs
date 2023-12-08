using ARM_MedRegistrar.Model.Persons;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.JsonWork
{
    public class JsonWork : IJsonWork
    {
        public void WriteToFile()
        {
            //if (!File.Exists("Doctors.json"))
            //    File.WriteAllText("Doctors.json", JsonConvert.SerializeObject(new List<Doctor> { _newDoctor }, Formatting.Indented));
            //else
            //{
            //    List<Doctor>? _doctors = JsonConvert.DeserializeObject<List<Doctor>>(File.ReadAllText("Doctors.json"));
            //    _doctors?.Add(_newDoctor);
            //    File.WriteAllText("Doctors.json", JsonConvert.SerializeObject(_doctors, Formatting.Indented));
            //}
        }
    }
}
