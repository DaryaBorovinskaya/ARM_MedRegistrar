using ARM_MedRegistrar.Model.DaysWithFreeAppointments;



namespace ARM_MedRegistrar.Model.FreeTimeOfAppointments
{
    public class FreeTimeOfAppointment : IFreeTimeOfAppointment
    {
        private IList<IDayWithFreeAppointments> _freeTimeOfAppointments;
        public uint Id { get; }
        public IList<IDayWithFreeAppointments> FreeTimeOfAppointments
        {
            get => _freeTimeOfAppointments;
            set
            {
                _freeTimeOfAppointments = value;
            }
        }

        public FreeTimeOfAppointment(IList<IDayWithFreeAppointments> dayWithFreeAppointments, uint id)
        {
            FreeTimeOfAppointments = dayWithFreeAppointments;
            Id = id;
        }


    }
}
