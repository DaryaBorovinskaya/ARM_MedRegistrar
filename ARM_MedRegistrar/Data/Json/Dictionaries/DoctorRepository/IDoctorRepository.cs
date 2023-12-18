using ARM_MedRegistrar.Model.Doctors;

namespace ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository
{
    public interface IDoctorRepository : IBaseRepository<uint , IDoctor>, ICreateId
    {

    }
}
