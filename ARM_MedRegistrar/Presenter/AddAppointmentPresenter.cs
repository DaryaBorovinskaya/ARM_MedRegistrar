using ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository;
using ARM_MedRegistrar.Data.Json.Dictionaries.PatientRepository;
using ARM_MedRegistrar.Model.Persons.Doctors;
using ARM_MedRegistrar.Model.Persons.Patients;
using ARM_MedRegistrar.Model.WorkSchedules;
using ARM_MedRegistrar.View.AddAppointment;
using ARM_MedRegistrar.Model.Translators;
using ARM_MedRegistrar.Data.Json.Dictionaries.FreeTimeOfAppointments;
using ARM_MedRegistrar.Model.FreeTimeOfAppointments;
using ARM_MedRegistrar.Model.DaysWithFreeAppointments;
using ARM_MedRegistrar.Data.Json.Dictionaries;

namespace ARM_MedRegistrar.Presenter
{
    public class AddAppointmentPresenter
    {
        IAddAppointmentForm _view;
        IBaseWithIdRepository<uint, IDoctor>  _jsonDoctorRepository;
        IDictionary<uint, IDoctor>? _doctors;
        IFreeTimeOfAppointment _freeTimeOfAppointments;
        IDictionary<uint, IFreeTimeOfAppointment>? _dictFreeTimeOfAppointments;
        IBaseWithIdRepository<uint, IPatient> _jsonPatientRepository;
        IDictionary<uint, IPatient>? _patients;
        IBaseRepository<uint, IFreeTimeOfAppointment> _jsonFreeTimeOfAppointmentRepository;
        IDayWithFreeAppointments _dayWithFreeAppointments;
        IList<IDayWithFreeAppointments> _daysWithFreeAppointments;
        ITranslator _translator;
        string _placeOfAppointment;
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
            _doctors = _jsonDoctorRepository.Read();
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
            _patients = _jsonPatientRepository.Read();
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
            _doctors = _jsonDoctorRepository.Read();
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
                            
                            _countOfLine++;
                            _view.DoctorCountOfLine = _countOfLine;
                            _view.DoctorId = doctor.Id;
                            _view.DoctorSurname = doctor.FullName.Surname;
                            _view.DoctorName = doctor.FullName.Name;
                            _view.DoctorPatronymic = doctor.FullName.Patronymic;
                            _view.DoctorSpecialization = doctor.Specialization;
                            _view.DoctorCabinet = doctor.Cabinet;
                            _view.DoctorPlotNumber = doctor.PlotNumber;
                            return true;
                        }
                    }
                }


                
            }
            return false;
        }

        public bool ShowFreeTimeOfAppointment()
        {
            bool IsContainDayOfAppointment;
            IWorkSchedule _workSchedule;
            IList<string> _rezult = new List<string>();
            _daysWithFreeAppointments = new List<IDayWithFreeAppointments>();
            _doctors = _jsonDoctorRepository.Read();
            _dictFreeTimeOfAppointments = _jsonFreeTimeOfAppointmentRepository.Read();
            if (_doctors == null || _doctors.Count == 0)
                return false;

            if (_doctors != null && _doctors.Count != 0 && _dictFreeTimeOfAppointments != null )  //если есть доктора и есть словарь свободных записей
            {
                foreach (uint key in _doctors.Keys)
                {
                    if (key == _view.DoctorSelectedId)      //нашли ключ выбранного в части view врача
                    {
                        
                        if (_dictFreeTimeOfAppointments.Count == 0 || !_dictFreeTimeOfAppointments.ContainsKey(key))   //если словарь записей пуст или не содержит в себе записи для выбранного врача 
                        {
                            
                            foreach (IWorkSchedule workSchedule in _doctors[key].WorkSchedule)
                                if (workSchedule.DayOfWeek == _translator.Translate(_view.DayOfAppointment.DayOfWeek.ToString()))   //если день недели желаемой записи совпадает с рабочим днём врача
                                {
                                    _workSchedule = workSchedule;
                                    _dayWithFreeAppointments = new DayWithFreeAppointments(_workSchedule.WorkBeginning, _workSchedule.WorkEnd, _doctors[key].DurationOfAppointment, _view.DayOfAppointment); //создание записей на выбранный в части view день
                                    foreach (DateTime time in _dayWithFreeAppointments.TimeOfAppointments)
                                        _rezult.Add(time.TimeOfDay.ToString());                     //запись всех свободных записей в итоговый List<string>

                                    _view.SetFreeTimeOfAppointment = _rezult;       //итоговые значения передаются в view
                                    _daysWithFreeAppointments.Add(_dayWithFreeAppointments);
                                    _freeTimeOfAppointments = new FreeTimeOfAppointment(_daysWithFreeAppointments, key);
                                    //_dictFreeTimeOfAppointments.Add(key, _freeTimeOfAppointments);
                                    _jsonFreeTimeOfAppointmentRepository.Create(_freeTimeOfAppointments);    //запись в файл
                                    return true;
                                }
                        }
                        else
                        { 
                            foreach (IFreeTimeOfAppointment freeTimeOfAppointments in _dictFreeTimeOfAppointments.Values)
                            {
                                foreach ( DayWithFreeAppointments dayWithFreeAppointments in freeTimeOfAppointments.FreeTimeOfAppointments)
                                    if (dayWithFreeAppointments.DateOfAppointment != _view.DayOfAppointment.Date)             //если на выбранную дату не создано свободных записей
                                    {
                                        foreach (IWorkSchedule workSchedule in _doctors[key].WorkSchedule)
                                            if (workSchedule.DayOfWeek == _translator.Translate(_view.DayOfAppointment.DayOfWeek.ToString()))
                                            {
                                                _workSchedule = workSchedule;
                                                _dayWithFreeAppointments = new DayWithFreeAppointments(_workSchedule.WorkBeginning, _workSchedule.WorkEnd, _doctors[key].DurationOfAppointment, _view.DayOfAppointment);
                                                foreach (DateTime time in _dayWithFreeAppointments.TimeOfAppointments)
                                                    _rezult.Add(time.TimeOfDay.ToString());


                                                
                                                _view.SetFreeTimeOfAppointment = _rezult;
                                                _freeTimeOfAppointments = _dictFreeTimeOfAppointments[key];
                                                _freeTimeOfAppointments.FreeTimeOfAppointments.Add(_dayWithFreeAppointments);
                                                _jsonFreeTimeOfAppointmentRepository.Update(_freeTimeOfAppointments);    //обновление данных свободных записей 
                                                return true;
                                            }
                                    }
                                    else
                                    {
                                        foreach (DateTime time in dayWithFreeAppointments.TimeOfAppointments)     //получаем данные из уже созданного ранее List
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
            _doctors = _jsonDoctorRepository.Read();
            if (_doctors == null || _doctors.Count == 0)
                return;

            if (_doctors != null && _doctors.Count != 0 && _view.DoctorSelectedId != 0)
                _view.InfoAboutDoctor = _doctors[_view.DoctorSelectedId].Format();
        }

        public bool GetPlaseOfAppointment()
        {
            _doctors = _jsonDoctorRepository.Read();
            if (_doctors == null || _doctors.Count == 0)
                return false ;
            _patients = _jsonPatientRepository.Read();
            if (_patients == null || _patients.Count == 0)
                return false;

            if (_patients != null && _patients.Count != 0 && _doctors != null && _doctors.Count != 0)
            {
                if (_view.GetTypeOfAppointment == "Вызов на дом")
                { 
                    _placeOfAppointment = _patients[_view.PatientSelectedId].Address.Format(); ;
                    _view.PlaceOfAppointment = _patients[_view.PatientSelectedId].Address.Format();
                    return true;
                }
                else
                { 
                    _placeOfAppointment = _doctors[_view.DoctorSelectedId].Cabinet.ToString(); ;
                    _view.PlaceOfAppointment = _doctors[_view.DoctorSelectedId].Cabinet.ToString();
                    return true;
                }
            }
            return false;
        }

        public bool SaveChangesOfPlaceOfAppointment()
        {
            _placeOfAppointment = string.Empty;
            _doctors = _jsonDoctorRepository.Read();
            if (_doctors == null || _doctors.Count == 0)
                return false;

            if (_doctors != null && _doctors.Count != 0)
            {
                _placeOfAppointment = _view.PlaceOfAppointment;
                         
                return true;
                 
            }
            return false;
        }

        public bool IsDoctorCanTakeAtHome()
        {
            _doctors = _jsonDoctorRepository.Read();
            if (_doctors == null || _doctors.Count == 0)
                return false;

            if (_doctors != null && _doctors.Count != 0)
            {
                if (_view.GetTypeOfAppointment == "Вызов на дом" && !(_doctors[_view.DoctorSelectedId].Specialization == "терапевт"
                    || _doctors[_view.DoctorSelectedId].Specialization == "педиатр" || _doctors[_view.DoctorSelectedId].Specialization == "врач общей практики"))
                    return false;
                else 
                    return true;
            }
            return false;
        }

        public bool SearchPatient()
        {
            _countOfLine = -1;
            _isSuccess = false;
            _patients = _jsonPatientRepository.Read();
            if (_patients == null || _patients.Count == 0)
                return false;

            if (_patients != null && _patients.Count != 0)
            {
                foreach (IPatient patient in _patients.Values)
                {
                    if (patient.DateOfBirth == _view.PatientDateOfBirth && patient.FullName.Surname == _view.PatientSurname
                        && patient.FullName.Name == _view.PatientName)
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
                }
                if (_isSuccess)
                    return true;
                else
                    return false;
            }

            return false;
        }


        public void ShowInfoAboutPatient()
        {
            _patients = _jsonPatientRepository.Read();
            if (_patients == null || _patients.Count == 0)
                return;

            if (_patients != null && _patients.Count != 0 && _view.PatientSelectedId != 0)
                _view.InfoAboutPatient = _patients[_view.PatientSelectedId].Format();
        }


    }
}
