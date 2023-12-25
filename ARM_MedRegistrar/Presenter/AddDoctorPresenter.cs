using ARM_MedRegistrar.View.AddDoctor;
using ARM_MedRegistrar.Model.Persons.Doctors;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository;
using ARM_MedRegistrar.Model.WorkSchedules;
using ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans;
using ARM_MedRegistrar.Data.Json.Dictionaries.FreeTimeOfAppointments;
using ARM_MedRegistrar.Model.FreeTimeOfAppointments;
using ARM_MedRegistrar.Model.DaysWithFreeAppointments;
using ARM_MedRegistrar.Data.Json.Dictionaries;

namespace ARM_MedRegistrar.Presenter
{
    public class AddDoctorPresenter 
    {
        IAddDoctorForm _view;
        IFullName _fullName;
        IPersonalData _personalData;
        IDoctor _newDoctor;
        IBaseRepositoryWithCreatedID<uint, IDoctor> _jsonDoctorRepository;
        IBaseRepository<uint, IFreeTimeOfAppointment> _jsonFreeTimeOfAppointmentRepository;
        uint _id;
        DateTime _nullTime = new(1753,1,1, 0, 0, 0);
        IWorkSchedule _workSchedule;
        IList<DateTime> _timesOfWork;
        IList<IWorkSchedule> _workSchedules;
        IDayWithFreeAppointments _dayWithFreeAppointments;
        IFreeTimeOfAppointment _freeTimeOfAppointments;

        public AddDoctorPresenter(IAddDoctorForm view)
        {
            _view = view;
            _workSchedules = new List<IWorkSchedule>();
            _jsonDoctorRepository = new JsonDoctorRepository();
            _jsonFreeTimeOfAppointmentRepository = new JsonFreeTimeOfAppointmentRepository();
        }

        
        public bool AddDoctor()
        {
            _fullName = new FullName(_view.Surname, _view.Name, _view.Patronymic);
            _personalData = new PersonalData(_fullName, _view.PhoneNumber);
            _id = _jsonDoctorRepository.CreateID();

            _timesOfWork = _view.TimesOfWork;
            for (int i = 0; i < _timesOfWork.Count; i += 2)
            {
                if (_timesOfWork[i] == _nullTime && _timesOfWork[i + 1] == _nullTime)
                    continue;

                else
                {
                    _workSchedule = new WorkScheduleOfDoctor(WorkScheduleOfDoctor.GetDaysOfWeek[i / 2], _timesOfWork[i], _timesOfWork[i + 1]);
                    _workSchedules.Add(_workSchedule);
                    
                    
                }
                
            }

            _newDoctor = new Doctor(_id, _personalData, _workSchedules, _view.Specializations, _view.PlotNumber,
                _view.Cabinet, _view.DurationOfAppointment);

            _jsonDoctorRepository.Create(_newDoctor);

            
            return true;
        }
    }
}
