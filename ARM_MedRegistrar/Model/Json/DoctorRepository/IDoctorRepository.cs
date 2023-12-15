using ARM_MedRegistrar.Model.Persons;


namespace ARM_MedRegistrar.Model.Json.DoctorRepository
{
    public interface IDoctorRepository
    {

        public  void Add(IDoctor element);


        public  IDictionary<int, IDoctor>? GetAll();


        public void Remove(IDoctor element);
    }
}
