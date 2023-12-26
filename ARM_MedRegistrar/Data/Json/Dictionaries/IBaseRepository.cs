using ARM_MedRegistrar.Model.Addresses;

namespace ARM_MedRegistrar.Data.Json.Dictionaries
{
    public interface IBaseRepository<T, U> where U : class
    {
        public void Create(U value);
        public IDictionary<T, U>? Read();
        public bool Update(U changedValue);
        public void Delete(T key);



    }
}
