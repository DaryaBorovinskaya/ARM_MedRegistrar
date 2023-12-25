

using ARM_MedRegistrar.Model.Formatter;

namespace ARM_MedRegistrar.Model.Persons
{
    public interface IFullName : IFormatter
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string? Patronymic { get; set; }

    }
}
