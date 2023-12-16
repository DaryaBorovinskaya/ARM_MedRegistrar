using ARM_MedRegistrar.Model.Persons;

namespace ARM_MedRegistrar.Model.Json.UserRepository
{
    public interface IUserRepository
    {

        public void Add( IUser value);


        public IDictionary<string, IUser>? GetAll();


        public void Remove(string key);

        public void WriteToFile();
    }
}
