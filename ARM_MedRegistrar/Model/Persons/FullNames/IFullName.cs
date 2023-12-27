

using ARM_MedRegistrar.Model.Formatter;
using ARM_MedRegistrar.Model.Formatters;

namespace ARM_MedRegistrar.Model.Persons
{
    public interface IFullName : IFormatter, IFormatterOneLine
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string? Patronymic { get; set; }

    }
}
