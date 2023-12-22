using ARM_MedRegistrar.Model.PaidMedServices;

namespace ARM_MedRegistrar.Data.Json.Dictionaries.PaidMedServiceRepository
{
    public interface IPaidMedServiceRepository : IBaseRepository<uint, IPaidMedService>, ICreateId
    {
    }
}
