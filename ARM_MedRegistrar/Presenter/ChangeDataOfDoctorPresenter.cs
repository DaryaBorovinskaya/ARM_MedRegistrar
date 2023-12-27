using ARM_MedRegistrar.Data.Json.Dictionaries;
using ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository;
using ARM_MedRegistrar.Model.Persons.Doctors;
using ARM_MedRegistrar.Model.WorksBeginningEnd;
using ARM_MedRegistrar.Model.WorkSchedules;
using ARM_MedRegistrar.View.ChangeDataOfDoctor;

namespace ARM_MedRegistrar.Presenter
{
    public class ChangeDataOfDoctorPresenter
    {
        IChangeDataOfDoctorForm _view;
        IBaseRepository<uint, IDoctor> _jsonDoctorRepository;
        IDictionary<uint, IDoctor> _doctors;
        IList<TimeOnly> _timesOfWork;
        IWorkSchedule _workSchedule;
        IList<IWorkSchedule> _workSchedules = new List<IWorkSchedule>();
        IDoctor _doctor ;
        TimeOnly _nullTime = new( 0, 0, 0);
        int _plotNumber;

        public ChangeDataOfDoctorPresenter(IChangeDataOfDoctorForm view) 
        { 
            _view = view;
            _jsonDoctorRepository = new JsonDoctorRepository();
        }

        public bool SetPlotNumber()
        {
            if (_view.Specialization != "терапевт" && _view.Specialization != "педиатр" && _view.Specialization != "врач общей практики")
            {
                _plotNumber = 0;
                _view.PlotNumber = _plotNumber;
                return true;
            }
            else if (_view.PlotNumber == 0)
                return false;
            return true;
        }
        public bool ShowDataAboutDoctor()
        {
            _doctors = _jsonDoctorRepository.Read();
            if (_doctors == null || _doctors.Count == 0)
                return false;

            if (_doctors != null && _doctors.Count != 0)
            {
                _timesOfWork = new List<TimeOnly>(14)
                {
                    _nullTime, _nullTime, _nullTime, _nullTime, _nullTime,_nullTime, _nullTime,
                    _nullTime, _nullTime, _nullTime, _nullTime, _nullTime,_nullTime, _nullTime
                };
                foreach (uint key in _doctors.Keys)

                    if (key == _view.Id)
                    {
                        _doctor = _doctors[key];
                         
                        _view.Surname = _doctor.DoctorDataOfAppointment.PersonalData.FullName.Surname;
                        _view.Name = _doctor.DoctorDataOfAppointment.PersonalData.FullName.Name;
                        _view.Patronymic = _doctor.DoctorDataOfAppointment.PersonalData.FullName.Patronymic;
                        
                        foreach(IWorkSchedule workSchedule in _doctor.WorkSchedule)
                        {
                            if (workSchedule.DayOfWeek == WorkScheduleOfDoctor.GetDaysOfWeek[0])
                            {
                                _timesOfWork[0] = workSchedule.WorkBeginningEnd.WorkBeginning;
                                _timesOfWork[1] =  workSchedule.WorkBeginningEnd.WorkEnd;
                            }
                            else if (workSchedule.DayOfWeek == WorkScheduleOfDoctor.GetDaysOfWeek[1])
                            {
                                _timesOfWork[2] = workSchedule.WorkBeginningEnd.WorkBeginning;
                                _timesOfWork[3] = workSchedule.WorkBeginningEnd.WorkEnd;
                            }
                            else if(workSchedule.DayOfWeek == WorkScheduleOfDoctor.GetDaysOfWeek[2])
                            {
                                _timesOfWork[4] = workSchedule.WorkBeginningEnd.WorkBeginning;
                                _timesOfWork[5] = workSchedule.WorkBeginningEnd.WorkEnd;
                            }
                            else if(workSchedule.DayOfWeek == WorkScheduleOfDoctor.GetDaysOfWeek[3])
                            {
                                _timesOfWork[6] = workSchedule.WorkBeginningEnd.WorkBeginning;
                                _timesOfWork[7] = workSchedule.WorkBeginningEnd.WorkEnd;
                            }
                            else if(workSchedule.DayOfWeek == WorkScheduleOfDoctor.GetDaysOfWeek[4])
                            {
                                _timesOfWork[8] = workSchedule.WorkBeginningEnd.WorkBeginning;
                                _timesOfWork[9] = workSchedule.WorkBeginningEnd.WorkEnd;
                            }
                            if (workSchedule.DayOfWeek == WorkScheduleOfDoctor.GetDaysOfWeek[5])
                            {
                                _timesOfWork[10] = workSchedule.WorkBeginningEnd.WorkBeginning;
                                _timesOfWork[11] = workSchedule.WorkBeginningEnd.WorkEnd;
                            }
                            else if(workSchedule.DayOfWeek == WorkScheduleOfDoctor.GetDaysOfWeek[6])
                            {
                                _timesOfWork[12] = workSchedule.WorkBeginningEnd.WorkBeginning;
                                _timesOfWork[13] = workSchedule.WorkBeginningEnd.WorkEnd;
                            }
                        }

                        _view.TimesOfWork = _timesOfWork;
                        _view.TimesOfWork = _timesOfWork;
                        _view.PhoneNumber = _doctor.DoctorDataOfAppointment.PersonalData.PhoneNumber;
                        _view.PlotNumber = _doctor.DoctorDataOfAppointment.PlotNumber;
                        _view.Specialization = _doctor.DoctorDataOfAppointment.Specialization;
                        _view.Cabinet = _doctor.DoctorDataOfAppointment.Cabinet;
                        _view.DurationOfAppointment = _doctor.DoctorDataOfAppointment.DurationOfAppointment;
                        return true;
                    }

            }
            return false;
        }

        public bool SaveChanges()
        {
            _doctors = _jsonDoctorRepository.Read();
            foreach (uint key in _doctors.Keys)
            {
                if (key == _view.Id)
                {
                    _doctor = _doctors[key];
                    _doctor.DoctorDataOfAppointment.PersonalData.FullName.Surname = _view.Surname;
                    _doctor.DoctorDataOfAppointment.PersonalData.FullName.Name = _view.Name;
                    _doctor.DoctorDataOfAppointment.PersonalData.FullName.Patronymic = _view.Patronymic;
                    _doctor.DoctorDataOfAppointment.PersonalData.PhoneNumber = _view.PhoneNumber;
                    _doctor.DoctorDataOfAppointment.PlotNumber = _view.PlotNumber;
                    _doctor.DoctorDataOfAppointment.Specialization = _view.Specialization;
                    _doctor.DoctorDataOfAppointment.Cabinet = _view.Cabinet;
                    _doctor.DoctorDataOfAppointment.DurationOfAppointment = _view.DurationOfAppointment;

                    _timesOfWork = _view.TimesOfWork;
                    for (int i = 0; i < _timesOfWork.Count; i += 2)
                    {
                        if (_timesOfWork[i] == _nullTime && _timesOfWork[i + 1] == _nullTime)
                            continue;

                        else
                        {
                            _workSchedule = new WorkScheduleOfDoctor(WorkScheduleOfDoctor.GetDaysOfWeek[i / 2], new WorkBeginningEnd( _timesOfWork[i], _timesOfWork[i + 1]));
                            _workSchedules.Add(_workSchedule);
                        }

                    }

                    _doctor.WorkSchedule = _workSchedules;

                    if (_jsonDoctorRepository.Update(_doctor))
                        return true;
                }
            }
            return false;
        }
    }
}

