using ARM_MedRegistrar.Model.Formatter;


namespace ARM_MedRegistrar.Model.WorksBeginningEnd
{
    public interface IWorkBeginningEnd : IFormatter
    {
        public TimeOnly WorkBeginning { get; set; }
        public TimeOnly WorkEnd { get; set; }
    }
}
