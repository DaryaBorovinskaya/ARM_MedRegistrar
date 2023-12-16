using ARM_MedRegistrar.Model.Doctors;

namespace ARM_MedRegistrar.Model.Json.DoctorRepository
{
    public interface IDoctorRepository
    {

        public  void Add(IDoctor value);


        public  IList< IDoctor>? GetAll();


        public void Remove(IDoctor value);
    }
}
