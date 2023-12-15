using ARM_MedRegistrar.Model.Users;

namespace ARM_MedRegistrar.Model.Json.UserRepository
{
    public interface IUserRepository
    {

        public void Add(string key, IUser value);


        public IDictionary<string, IUser>? GetAll();


        public void Remove(string key);
    }
}
