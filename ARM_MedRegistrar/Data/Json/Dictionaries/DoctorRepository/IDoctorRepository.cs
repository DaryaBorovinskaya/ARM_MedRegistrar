using ARM_MedRegistrar.Model.Persons.Doctors;

namespace ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository
{
    public interface IDoctorRepository : IBaseRepository<uint , IDoctor>, ICreateId
    {

    }
}
