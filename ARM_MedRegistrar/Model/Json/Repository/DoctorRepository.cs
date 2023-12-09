
using ARM_MedRegistrar.Model.Persons;


namespace ARM_MedRegistrar.Model.Json.Repository
{
    public abstract class DoctorRepository : IBaseRepository<IDoctor>
    {
        protected IList<IDoctor>? _doctors = new List<IDoctor>();
        public abstract void Add(IDoctor element);


        public abstract IList<IDoctor>? GetAll();


        public abstract void Remove(IDoctor element);
    }
}
