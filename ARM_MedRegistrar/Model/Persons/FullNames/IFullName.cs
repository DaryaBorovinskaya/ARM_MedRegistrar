

namespace ARM_MedRegistrar.Model.Persons
{
    public interface IFullName
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string? Patronymic { get; set; }

    }
}
