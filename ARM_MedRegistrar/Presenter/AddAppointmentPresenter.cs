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
using ARM_MedRegistrar.Model.WorksBeginningEnd;
using ARM_MedRegistrar.Model.Appointments;
using ARM_MedRegistrar.Data.Json.Dictionaries.AppointmentRepository;
using System.Globalization;

namespace ARM_MedRegistrar.Presenter
{
    public class AddAppointmentPresenter
    {
        IAddAppointmentForm _view;
        IBaseRepositoryWithCreatedID<uint, IDoctor>  _jsonDoctorRepository;
        IDictionary<uint, IDoctor>? _doctors;
        IFreeTimeOfAppointment _freeTimeOfAppointments;
        IDictionary<uint, IFreeTimeOfAppointment>? _dictFreeTimeOfAppointments;
        IBaseRepositoryWithCreatedID<uint, IPatient> _jsonPatientRepository;
        IDictionary<uint, IPatient>? _patients;
        IBaseRepository<uint, IFreeTimeOfAppointment> _jsonFreeTimeOfAppointmentRepository;
        IBaseRepositoryWithCreatedID<uint, IAppointment> _jsonAppointmentRepository;
        IAppointment _appointment;
        IDayWithFreeAppointments _dayWithFreeAppointments;
        IList<IDayWithFreeAppointments> _daysWithFreeAppointments;
        IList<TimeOnly> _delTimeOfAppointments;
        ITranslator _translator;
        string _placeOfAppointment;
        int _countOfLine = -1;
        bool _isSuccess;
        uint _id;

        public AddAppointmentPresenter(IAddAppointmentForm view)
        {
            _view = view;
            _translator = new Translator();
            _jsonDoctorRepository = new JsonDoctorRepository();
            _jsonPatientRepository = new JsonPatientRepository();
            _jsonFreeTimeOfAppointmentRepository = new JsonFreeTimeOfAppointmentRepository();
            _jsonAppointmentRepository = new JsonAppointmentRepository();
        }

        
        public IList<string> SetTypeOfAppointment()
        {
            return Appointment.SetTypeOfAppointment();
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
                    _view.DoctorId = doctor.DoctorDataOfAppointment.Id;
                    _view.DoctorSurname = doctor.DoctorDataOfAppointment.PersonalData.FullName.Surname;
                    _view.DoctorName = doctor.DoctorDataOfAppointment.PersonalData.FullName.Name;
                    _view.DoctorPatronymic = doctor.DoctorDataOfAppointment.PersonalData.FullName.Patronymic;
                    _view.DoctorSpecialization = doctor.DoctorDataOfAppointment.Specialization;
                    _view.DoctorCabinet = doctor.DoctorDataOfAppointment.Cabinet;
                    _view.DoctorPlotNumber = doctor.DoctorDataOfAppointment.PlotNumber;
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
                    _view.PatientSurname = patient.PersonalData.FullName.Surname;
                    _view.PatientName = patient.PersonalData.FullName.Name;
                    _view.PatientPatronymic = patient.PersonalData.FullName.Patronymic;
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
            bool _isSuccess = false;
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
                        if (workSchedule.DayOfWeek == _translator.Translate(_view.DayOfAppointment.DayOfWeek.ToString()))
                        {
                            
                            _countOfLine++;
                            _view.DoctorCountOfLine = _countOfLine;
                            _view.DoctorId = doctor.DoctorDataOfAppointment.Id;
                            _view.DoctorSurname = doctor.DoctorDataOfAppointment.PersonalData.FullName.Surname;
                            _view.DoctorName = doctor.DoctorDataOfAppointment.PersonalData.FullName.Name;
                            _view.DoctorPatronymic = doctor.DoctorDataOfAppointment.PersonalData.FullName.Patronymic;
                            _view.DoctorSpecialization = doctor.DoctorDataOfAppointment.Specialization;
                            _view.DoctorCabinet = doctor.DoctorDataOfAppointment.Cabinet;
                            _view.DoctorPlotNumber = doctor.DoctorDataOfAppointment.PlotNumber;
                            _isSuccess = true;
                        }
                    }

                }

                if (_isSuccess)
                    return true;
                
            }
            return false;
        }

        public bool ShowFreeTimeOfAppointment()
        {
            bool IsContainDayOfAppointment;
            IWorkSchedule _workSchedule;
            IList<string> _result = new List<string>();
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
                        
                        if (_dictFreeTimeOfAppointments.Count == 0 || !_dictFreeTimeOfAppointments.ContainsKey(key)  )   //если словарь записей пуст или не содержит в себе записи для выбранного врача 
                        {
                            foreach (IWorkSchedule workSchedule in _doctors[key].WorkSchedule)
                                if (workSchedule.DayOfWeek == _translator.Translate(_view.DayOfAppointment.DayOfWeek.ToString()))   //если день недели желаемой записи совпадает с рабочим днём врача
                                {
                                    _dayWithFreeAppointments = new DayWithFreeAppointments(new WorkBeginningEnd( workSchedule.WorkBeginningEnd.WorkBeginning, workSchedule.WorkBeginningEnd.WorkEnd), _doctors[key].DoctorDataOfAppointment.DurationOfAppointment, _view.DayOfAppointment); //создание записей на выбранный в части view день
                                    foreach (TimeOnly time in _dayWithFreeAppointments.TimeOfAppointments)
                                        _result.Add(time.ToString());                     //запись всех свободных записей в итоговый List<string>

                                    _view.SetFreeTimeOfAppointment = _result;       //итоговые значения передаются в view
                                    _daysWithFreeAppointments.Add(_dayWithFreeAppointments);
                                    _freeTimeOfAppointments = new FreeTimeOfAppointment(_daysWithFreeAppointments, key);
                                    //_dictFreeTimeOfAppointments.Add(key, _freeTimeOfAppointments);
                                    _jsonFreeTimeOfAppointmentRepository.Create(_freeTimeOfAppointments);    //запись в файл
                                    return true;
                                }
                        }
                        else if (_dictFreeTimeOfAppointments[key].FreeTimeOfAppointments.Count == 0)   //после очищения свободных записей с прошлого дня
                        {
                            foreach (IWorkSchedule workSchedule in _doctors[key].WorkSchedule)
                                if (workSchedule.DayOfWeek == _translator.Translate(_view.DayOfAppointment.DayOfWeek.ToString()))   //если день недели желаемой записи совпадает с рабочим днём врача
                                {
                                    _dayWithFreeAppointments = new DayWithFreeAppointments(new WorkBeginningEnd(workSchedule.WorkBeginningEnd.WorkBeginning, workSchedule.WorkBeginningEnd.WorkEnd), _doctors[key].DoctorDataOfAppointment.DurationOfAppointment, _view.DayOfAppointment); //создание записей на выбранный в части view день
                                    foreach (TimeOnly time in _dayWithFreeAppointments.TimeOfAppointments)
                                        _result.Add(time.ToString());                     //запись всех свободных записей в итоговый List<string>

                                    _view.SetFreeTimeOfAppointment = _result;       //итоговые значения передаются в view
                                    _daysWithFreeAppointments.Add(_dayWithFreeAppointments);
                                    _freeTimeOfAppointments = new FreeTimeOfAppointment(_daysWithFreeAppointments, key);
                                    //_dictFreeTimeOfAppointments.Add(key, _freeTimeOfAppointments);
                                    _jsonFreeTimeOfAppointmentRepository.Update(_freeTimeOfAppointments);    //запись в файл
                                    return true;
                                }
                        }
                        else 
                        { 
                            foreach (uint id in _dictFreeTimeOfAppointments.Keys) 
                            {
                                if (id == _view.DoctorSelectedId)
                                {
                                    foreach (DayWithFreeAppointments dayWithFreeAppointments in _dictFreeTimeOfAppointments[id].FreeTimeOfAppointments)
                                        if (dayWithFreeAppointments.DateOfAppointment != _view.DayOfAppointment)             //если на выбранную дату не создано свободных записей
                                        {
                                            foreach (IWorkSchedule workSchedule in _doctors[key].WorkSchedule)
                                                if (workSchedule.DayOfWeek == _translator.Translate(_view.DayOfAppointment.DayOfWeek.ToString()))
                                                {
                                                    _dayWithFreeAppointments = new DayWithFreeAppointments(new WorkBeginningEnd(workSchedule.WorkBeginningEnd.WorkBeginning, workSchedule.WorkBeginningEnd.WorkEnd), _doctors[key].DoctorDataOfAppointment.DurationOfAppointment, _view.DayOfAppointment);
                                                    foreach (TimeOnly time in _dayWithFreeAppointments.TimeOfAppointments)
                                                        _result.Add(time.ToString());



                                                    _view.SetFreeTimeOfAppointment = _result;
                                                    _freeTimeOfAppointments = _dictFreeTimeOfAppointments[key];
                                                    _freeTimeOfAppointments.FreeTimeOfAppointments.Add(_dayWithFreeAppointments);
                                                    _jsonFreeTimeOfAppointmentRepository.Update(_freeTimeOfAppointments);    //обновление данных свободных записей 
                                                    return true;
                                                }
                                        }
                                        else
                                        {
                                            foreach (TimeOnly time in dayWithFreeAppointments.TimeOfAppointments)     //получаем данные из уже созданного ранее List
                                                _result.Add(time.ToString());
                                            _view.SetFreeTimeOfAppointment = _result;
                                            return true;
                                        }
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
                    _placeOfAppointment = "кабинет " + _patients[_view.PatientSelectedId].Address.FormatOneLine(); ;
                    _view.PlaceOfAppointment = _patients[_view.PatientSelectedId].Address.FormatOneLine();
                    return true;
                }
                else
                { 
                    _placeOfAppointment = "кабинет " + _doctors[_view.DoctorSelectedId].DoctorDataOfAppointment.Cabinet.ToString(); ;
                    _view.PlaceOfAppointment = "кабинет " + _doctors[_view.DoctorSelectedId].DoctorDataOfAppointment.Cabinet.ToString();
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
                if (_view.GetTypeOfAppointment == "Вызов на дом" && !(_doctors[_view.DoctorSelectedId].DoctorDataOfAppointment.Specialization == "терапевт"
                    || _doctors[_view.DoctorSelectedId].DoctorDataOfAppointment.Specialization == "педиатр" || _doctors[_view.DoctorSelectedId].DoctorDataOfAppointment.Specialization == "врач общей практики"))
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
                    if (patient.DateOfBirth == _view.PatientDateOfBirth && patient.PersonalData.FullName.Surname == _view.PatientSurname
                        && patient.PersonalData.FullName.Name == _view.PatientName)
                    {
                        _isSuccess = true;
                        _countOfLine++;
                        _view.PatientCountOfLine = _countOfLine;
                        _view.PatientId = patient.Id;
                        _view.PatientSurname = patient.PersonalData.FullName.Surname;
                        _view.PatientName = patient.PersonalData.FullName.Name;
                        _view.PatientPatronymic = patient.PersonalData.FullName.Patronymic;
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

        public bool IsEqualPlotNumber()
        {
            _doctors = _jsonDoctorRepository.Read();
            _patients = _jsonPatientRepository.Read();

            if (_patients == null || _patients.Count == 0)
                return false;
            if (_doctors == null || _doctors.Count == 0)
                return false;

            if (_patients != null && _patients.Count != 0 && _doctors != null && _doctors.Count != 0)
            {
                if (_doctors[_view.DoctorSelectedId].DoctorDataOfAppointment.PlotNumber == 0 || _doctors[_view.DoctorSelectedId].DoctorDataOfAppointment.PlotNumber == _patients[_view.PatientSelectedId].PlotNumber)
                    return true;
                return false;
            }
            return false;
        }


        public bool AddAppointment()
        {
            _doctors = _jsonDoctorRepository.Read();
            _patients = _jsonPatientRepository.Read();

            if (_patients == null || _patients.Count == 0)
                return false;
            if (_doctors == null || _doctors.Count == 0)
                return false;

            if (_patients != null && _patients.Count != 0 && _doctors != null && _doctors.Count != 0) 
            {
                DateTime _timeOfAppointment = DateTime.Parse(_view.GetFreeTimeOfAppointment, CultureInfo.InvariantCulture);
                _id = _jsonAppointmentRepository.CreateID();
                _appointment = new Appointment(_id, _patients[_view.PatientSelectedId], _doctors[_view.DoctorSelectedId].DoctorDataOfAppointment, _view.GetTypeOfAppointment, 
                    new DateTime(_view.DayOfAppointment.Year, _view.DayOfAppointment.Month, _view.DayOfAppointment.Day,
                    _timeOfAppointment.Hour, _timeOfAppointment.Minute, 0), _placeOfAppointment);



                _dictFreeTimeOfAppointments = _jsonFreeTimeOfAppointmentRepository.Read();
                if (_dictFreeTimeOfAppointments != null)
                {
                    foreach (IDayWithFreeAppointments dayWithFreeAppointments in _dictFreeTimeOfAppointments[_view.DoctorSelectedId].FreeTimeOfAppointments)
                    {
                        if (dayWithFreeAppointments.DateOfAppointment == _view.DayOfAppointment)
                        {
                            _delTimeOfAppointments = dayWithFreeAppointments.TimeOfAppointments;
                            for (int i = 0; i < dayWithFreeAppointments.TimeOfAppointments.Count; i++)
                            {
                                if (dayWithFreeAppointments.TimeOfAppointments[i] == TimeOnly.FromDateTime(_timeOfAppointment))
                                    _delTimeOfAppointments.Remove(TimeOnly.FromDateTime(_timeOfAppointment));
                            }
                        }
                    }


                    foreach (IDayWithFreeAppointments dayWithFreeAppointments in _dictFreeTimeOfAppointments[_view.DoctorSelectedId].FreeTimeOfAppointments)
                    {
                        if (dayWithFreeAppointments.DateOfAppointment == _view.DayOfAppointment)
                        {
                            dayWithFreeAppointments.TimeOfAppointments = _delTimeOfAppointments;
                        }
                    }

                    _jsonFreeTimeOfAppointmentRepository.Update(_dictFreeTimeOfAppointments[_view.DoctorSelectedId]);

                }
                _jsonAppointmentRepository.Create(_appointment);
                return true;
            }
            return false;
        }

    }
}
