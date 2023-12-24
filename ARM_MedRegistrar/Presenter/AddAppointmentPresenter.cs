using ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository;
using ARM_MedRegistrar.Data.Json.Dictionaries.PatientRepository;
using ARM_MedRegistrar.Model.Persons.Doctors;
using ARM_MedRegistrar.Model.Persons.Patients;
using ARM_MedRegistrar.Model.WorkSchedules;
using ARM_MedRegistrar.View.AddAppointment;
using ARM_MedRegistrar.Model.Translators;
using ARM_MedRegistrar.Data.Json.Dictionaries.FreeTimeOfAppointments;
using ARM_MedRegistrar.Model.FreeTimeOfAppointments;
using System.Security.Cryptography;

namespace ARM_MedRegistrar.Presenter
{
    public class AddAppointmentPresenter
    {
        IAddAppointmentForm _view;
        IDoctorRepository _jsonDoctorRepository;
        IDictionary<uint, IDoctor>? _doctors;
        IList<IFreeTimeOfAppointment> _freeTimeOfAppointments;
        IDictionary<uint, IList<IFreeTimeOfAppointment>>? _dictFreeTimeOfAppointments;
        IPatientRepository _jsonPatientRepository;
        IDictionary<uint, IPatient>? _patients;
        IFreeTimeOfAppointmentRepository _jsonFreeTimeOfAppointmentRepository;
        IFreeTimeOfAppointment _freeTimeOfAppointment;
        ITranslator _translator;
        string _lineSchedule = "";
        int _countOfLine = -1;
        bool _isSuccess;

        public AddAppointmentPresenter(IAddAppointmentForm view)
        {
            _view = view;
            _translator = new Translator();
            _jsonDoctorRepository = new JsonDoctorRepository();
            _jsonPatientRepository = new JsonPatientRepository();
            _jsonFreeTimeOfAppointmentRepository = new JsonFreeTimeOfAppointmentRepository();
        }

        public bool ShowAllDoctors()
        {
            _countOfLine = -1;
            _isSuccess = false;
            _doctors = _jsonDoctorRepository.GetAll();
            if (_doctors == null || _doctors.Count == 0)
                return false;

            if (_doctors != null && _doctors.Count != 0)
            {
                foreach (IDoctor doctor in _doctors.Values)
                {
                    _isSuccess = true;
                    _countOfLine++;
                    _view.DoctorCountOfLine = _countOfLine;
                    _view.DoctorId = doctor.Id;
                    _view.DoctorSurname = doctor.FullName.Surname;
                    _view.DoctorName = doctor.FullName.Name;
                    _view.DoctorPatronymic = doctor.FullName.Patronymic;
                    _view.DoctorSpecialization = doctor.Specialization;
                    _view.DoctorCabinet = doctor.Cabinet;
                    _view.DoctorPlotNumber = doctor.PlotNumber;
                }
                if (_isSuccess)
                    return true;
                else
                    return false;
            }
            return false;
        }


        public bool ShowAllPatients()
        {
            _countOfLine = -1;
            _isSuccess = false;
            _patients = _jsonPatientRepository.GetAll();
            if (_patients == null || _patients.Count == 0)
                return false;

            if (_patients != null && _patients.Count != 0)
            {
                foreach (IPatient patient in _patients.Values)
                {
                    _isSuccess = true;
                    _countOfLine++;
                    _view.PatientCountOfLine = _countOfLine;
                    _view.PatientId = patient.Id;
                    _view.PatientSurname = patient.FullName.Surname;
                    _view.PatientName = patient.FullName.Name;
                    _view.PatientPatronymic = patient.FullName.Patronymic;
                    _view.PatientDateOfBirth = patient.DateOfBirth;

                }
                if (_isSuccess)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public bool WorkingDoctors()
        {
            _countOfLine = -1;
            _isSuccess = false;
            _doctors = _jsonDoctorRepository.GetAll();
            if (_doctors == null || _doctors.Count == 0)
                return false;

            if (_doctors != null && _doctors.Count != 0)
            {
                foreach (IDoctor doctor in _doctors.Values)
                {
                    foreach (IWorkSchedule workSchedule in doctor.WorkSchedule)
                    {
                        if (workSchedule.DayOfWeek == _translator.Translate(_view.DayOfAppointment.DayOfWeek.ToString()) &&
                             workSchedule.WorkBeginning.TimeOfDay <= _view.TimeOfAppointment.TimeOfDay && workSchedule.WorkEnd.TimeOfDay > _view.TimeOfAppointment.TimeOfDay)
                        {
                            _isSuccess = true;
                            _countOfLine++;
                            _view.DoctorCountOfLine = _countOfLine;
                            _view.DoctorId = doctor.Id;
                            _view.DoctorSurname = doctor.FullName.Surname;
                            _view.DoctorName = doctor.FullName.Name;
                            _view.DoctorPatronymic = doctor.FullName.Patronymic;
                            _view.DoctorSpecialization = doctor.Specialization;
                            _view.DoctorCabinet = doctor.Cabinet;
                            _view.DoctorPlotNumber = doctor.PlotNumber;
                        }
                    }
                }



                return true;
            }
            return false;
        }

        public bool ShowFreeTimeOfAppointment()
        {
            bool IsContainDayOfAppointment;
            IWorkSchedule _workSchedule;
            IList<string> _rezult = new List<string>();
            _freeTimeOfAppointments = new List<IFreeTimeOfAppointment>();
            _doctors = _jsonDoctorRepository.GetAll();
            _dictFreeTimeOfAppointments = _jsonFreeTimeOfAppointmentRepository.GetAll();
            if (_doctors == null || _doctors.Count == 0)
                return false;

            if (_doctors != null && _doctors.Count != 0 && _dictFreeTimeOfAppointments != null )
            {
                foreach (uint key in _doctors.Keys)
                {
                    if (key == _view.DoctorSelectedId)
                    {
                        
                        if (_dictFreeTimeOfAppointments.Count == 0 || !_dictFreeTimeOfAppointments.ContainsKey(key) )
                        {
                            
                            foreach (IWorkSchedule workSchedule in _doctors[key].WorkSchedule)
                                if (workSchedule.DayOfWeek == _translator.Translate(_view.DayOfAppointment.DayOfWeek.ToString()))
                                {
                                    _workSchedule = workSchedule;
                                    _freeTimeOfAppointment = new FreeTimeOfAppointment(_workSchedule.WorkBeginning, _workSchedule.WorkEnd, _doctors[key].DurationOfAppointment, _view.DayOfAppointment);
                                    foreach (DateTime time in _freeTimeOfAppointment.TimeOfAppointments)
                                        _rezult.Add(time.TimeOfDay.ToString());

                                    _view.SetFreeTimeOfAppointment = _rezult;
                                    _freeTimeOfAppointments.Add(_freeTimeOfAppointment);
                                    _dictFreeTimeOfAppointments.Add(key, _freeTimeOfAppointments);
                                    _jsonFreeTimeOfAppointmentRepository.Add(key, _freeTimeOfAppointments);
                                    return true;
                                }
                        }
                        else
                        { 
                            foreach (IList<IFreeTimeOfAppointment> freeTimeOfAppointments in _dictFreeTimeOfAppointments.Values)
                            {
                                foreach ( IFreeTimeOfAppointment freeTimeOfAppointment in freeTimeOfAppointments)
                                    if (freeTimeOfAppointment.DateOfAppointment != _view.DayOfAppointment.Date)
                                    {
                                        foreach (IWorkSchedule workSchedule in _doctors[key].WorkSchedule)
                                            if (workSchedule.DayOfWeek == _translator.Translate(_view.DayOfAppointment.DayOfWeek.ToString()))
                                            {
                                                _workSchedule = workSchedule;
                                                _freeTimeOfAppointment = new FreeTimeOfAppointment(_workSchedule.WorkBeginning, _workSchedule.WorkEnd, _doctors[key].DurationOfAppointment, _view.DayOfAppointment);
                                                foreach (DateTime time in _freeTimeOfAppointment.TimeOfAppointments)
                                                    _rezult.Add(time.TimeOfDay.ToString());


                                                
                                                _view.SetFreeTimeOfAppointment = _rezult;
                                                _freeTimeOfAppointments = _dictFreeTimeOfAppointments[key];
                                                _freeTimeOfAppointments.Add(_freeTimeOfAppointment);
                                                _jsonFreeTimeOfAppointmentRepository.SaveChangedData(key, _freeTimeOfAppointments);
                                                return true;
                                            }
                                    }
                                    else
                                    {
                                        foreach (DateTime time in freeTimeOfAppointment.TimeOfAppointments)
                                            _rezult.Add(time.TimeOfDay.ToString());


                                        _view.SetFreeTimeOfAppointment = _rezult;
                                        return true;
                                    }
                            }
                            
                                    
                        }
                            
                    }
                      
                      
                    
                }
                
            }
            return false;
        }



        public void ShowInfoAboutDoctor()
        {
            _doctors = _jsonDoctorRepository.GetAll();
            if (_doctors == null || _doctors.Count == 0)
                return;

            if (_doctors != null && _doctors.Count != 0 && _view.DoctorSelectedId != 0)
                _view.InfoAboutDoctor = _doctors[_view.DoctorSelectedId].Format();
        }
    }
}
