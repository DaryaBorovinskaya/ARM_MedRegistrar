using ARM_MedRegistrar.Data.Json.Dictionaries;
using ARM_MedRegistrar.Data.Json.Dictionaries.AppointmentRepository;
using ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository;
using ARM_MedRegistrar.Data.Json.Dictionaries.FreeTimeOfAppointments;
using ARM_MedRegistrar.Model.Translators;
using ARM_MedRegistrar.Model.Appointments;
using ARM_MedRegistrar.Model.DaysWithFreeAppointments;
using ARM_MedRegistrar.Model.FreeTimeOfAppointments;
using ARM_MedRegistrar.Model.Persons.Doctors;
using ARM_MedRegistrar.Model.WorksBeginningEnd;
using ARM_MedRegistrar.Model.WorkSchedules;
using ARM_MedRegistrar.View.ChangeDataOfAppointment;
using System.Globalization;

namespace ARM_MedRegistrar.Presenter
{
    public class ChangeDataOfAppointmentPresenter
    {
        IChangeDataOfAppointmentForm _view;
        IDictionary<uint, IDoctor>? _doctors;
        IDictionary<uint, IAppointment>? _appointments;
        IAppointment _appointment;
        IBaseRepository<uint, IDoctor> _jsonDoctorRepository;
        IBaseRepository<uint, IAppointment> _jsonAppointmentRepository;
        IList<IDayWithFreeAppointments> _daysWithFreeAppointments;
        IBaseRepository<uint, IFreeTimeOfAppointment> _jsonFreeTimeOfAppointmentRepository;
        IDictionary<uint, IFreeTimeOfAppointment>? _dictFreeTimeOfAppointments;
        IDayWithFreeAppointments _dayWithFreeAppointments;
        ITranslator _translator;
        IFreeTimeOfAppointment _freeTimeOfAppointments;
        IList<TimeOnly> _newTimeOfAppointments;


        public ChangeDataOfAppointmentPresenter(IChangeDataOfAppointmentForm view)
        {
            _view = view;
            _translator = new Translator();
            _jsonDoctorRepository = new JsonDoctorRepository();
            _jsonAppointmentRepository = new JsonAppointmentRepository();
            _jsonFreeTimeOfAppointmentRepository = new JsonFreeTimeOfAppointmentRepository();
        }


        public bool IsDoctorCanTakeAtHome()
        {
            _doctors = _jsonDoctorRepository.Read();
            if (_doctors == null || _doctors.Count == 0)
                return false;

            if (_doctors != null && _doctors.Count != 0)
            {
                if (_view.TypeOfAppointment == "Вызов на дом" && !(_doctors[_view.DoctorId].DoctorDataOfAppointment.Specialization == "терапевт"
                || _doctors[_view.DoctorId].DoctorDataOfAppointment.Specialization == "педиатр" || _doctors[_view.DoctorId].DoctorDataOfAppointment.Specialization == "врач общей практики"))
                    return false;
                else
                    return true;
            }
            return false;
        }



        private void ShowFreeTimeOfAppointment()
        {
            bool IsContainDayOfAppointment;
            IWorkSchedule _workSchedule;
            IList<string> _result = new List<string>();
            _appointments = _jsonAppointmentRepository.Read();
            _daysWithFreeAppointments = new List<IDayWithFreeAppointments>();
            _doctors = _jsonDoctorRepository.Read();
            _dictFreeTimeOfAppointments = _jsonFreeTimeOfAppointmentRepository.Read();
            if (_doctors == null || _doctors.Count == 0)
                return ;

            if (_doctors != null && _doctors.Count != 0 && _dictFreeTimeOfAppointments != null)  //если есть доктора и есть словарь свободных записей
            {
                foreach (uint key in _doctors.Keys)
                {
                    if (key == _appointments[_view.AppointmentId].DoctorDataOfAppointment.Id)      //нашли ключ выбранного в части view врача
                    {

                        if (_dictFreeTimeOfAppointments.Count == 0 || !_dictFreeTimeOfAppointments.ContainsKey(key))   //если словарь записей пуст или не содержит в себе записи для выбранного врача 
                        {

                            foreach (IWorkSchedule workSchedule in _doctors[key].WorkSchedule)
                                if (workSchedule.DayOfWeek == _translator.Translate(_appointments[_view.AppointmentId].DateAndTime.DayOfWeek.ToString()))   //если день недели записи совпадает с рабочим днём врача
                                {
                                    _dayWithFreeAppointments = new DayWithFreeAppointments(new WorkBeginningEnd(workSchedule.WorkBeginningEnd.WorkBeginning, workSchedule.WorkBeginningEnd.WorkEnd), _doctors[key].DoctorDataOfAppointment.DurationOfAppointment, DateOnly.FromDateTime(_appointments[_view.AppointmentId].DateAndTime)); //создание записей на выбранный в части view день
                                    foreach (TimeOnly time in _dayWithFreeAppointments.TimeOfAppointments)
                                        _result.Add(time.ToString());                     //запись всех свободных записей в итоговый List<string>

                                    _view.SetFreeTimeOfAppointments = _result;       //итоговые значения передаются в view
                                    _daysWithFreeAppointments.Add(_dayWithFreeAppointments);
                                    _freeTimeOfAppointments = new FreeTimeOfAppointment(_daysWithFreeAppointments, key);
                                    //_dictFreeTimeOfAppointments.Add(key, _freeTimeOfAppointments);
                                    _jsonFreeTimeOfAppointmentRepository.Create(_freeTimeOfAppointments);    //запись в файл
                                    return ;
                                }
                        }
                        else
                        {
                            foreach (uint id in _dictFreeTimeOfAppointments.Keys)
                            {
                                if (id == _appointments[_view.AppointmentId].DoctorDataOfAppointment.Id)
                                {
                                    foreach (DayWithFreeAppointments dayWithFreeAppointments in _dictFreeTimeOfAppointments[id].FreeTimeOfAppointments)
                                        if (dayWithFreeAppointments.DateOfAppointment != DateOnly.FromDateTime(_appointments[_view.AppointmentId].DateAndTime))             //если на выбранную дату не создано свободных записей
                                        {
                                            foreach (IWorkSchedule workSchedule in _doctors[key].WorkSchedule)
                                                if (workSchedule.DayOfWeek == _translator.Translate(_appointments[_view.AppointmentId].DateAndTime.DayOfWeek.ToString()))
                                                {
                                                    _dayWithFreeAppointments = new DayWithFreeAppointments(new WorkBeginningEnd(workSchedule.WorkBeginningEnd.WorkBeginning, workSchedule.WorkBeginningEnd.WorkEnd), _doctors[key].DoctorDataOfAppointment.DurationOfAppointment, DateOnly.FromDateTime(_appointments[_view.AppointmentId].DateAndTime));
                                                    foreach (TimeOnly time in _dayWithFreeAppointments.TimeOfAppointments)
                                                        _result.Add(time.ToString());



                                                    _view.SetFreeTimeOfAppointments = _result;
                                                    _freeTimeOfAppointments = _dictFreeTimeOfAppointments[key];
                                                    _freeTimeOfAppointments.FreeTimeOfAppointments.Add(_dayWithFreeAppointments);
                                                    _jsonFreeTimeOfAppointmentRepository.Update(_freeTimeOfAppointments);    //обновление данных свободных записей 
                                                    return ;
                                                }
                                        }
                                        else
                                        {
                                            foreach (TimeOnly time in dayWithFreeAppointments.TimeOfAppointments)     //получаем данные из уже созданного ранее List
                                                _result.Add(time.ToString());
                                            _view.SetFreeTimeOfAppointments = _result;
                                            return;
                                        }
                                }
                            }


                        }

                    }

                }

            }
          
        }


        public bool ShowDataAboutAppointment()
        {
            _appointments = _jsonAppointmentRepository.Read();
            if (_appointments == null || _appointments.Count == 0)
                return false;

            if (_appointments != null && _appointments.Count != 0)
            {
                foreach (uint key in _appointments.Keys)

                    if (key == _view.AppointmentId)
                    {
                        _appointment = _appointments[key];
                        _view.DateOfAppointment = DateOnly.FromDateTime(_appointment.DateAndTime);
                        ShowFreeTimeOfAppointment();
                        _view.FreeTimeOfAppointment = TimeOnly.FromDateTime(_appointment.DateAndTime).ToLongTimeString();
                        _view.DoctorId = _appointment.DoctorDataOfAppointment.Id;
                        _view.DoctorFullName = _appointment.DoctorDataOfAppointment.PersonalData.FullName.FormatOneLine() + " " + _appointment.DoctorDataOfAppointment.Specialization;
                        _view.PatientId = _appointment.Patient.Id;
                        _view.PatientFullName = _appointment.Patient.PersonalData.FullName.FormatOneLine();
                        _view.TypeOfAppointment = _appointment.TypeOfAppointment;
                        _view.Place = _appointment.Place;
                        return true;
                    }

            }
            return false;
        }

        public bool SaveChanges()
        {
            _appointments = _jsonAppointmentRepository.Read();
            if (_appointments == null || _appointments.Count == 0)
                return false;

            if (_appointments != null && _appointments.Count != 0)
            {
                foreach (uint key in _appointments.Keys)
                {
                    if (key == _view.AppointmentId)
                    {
                        _dictFreeTimeOfAppointments = _jsonFreeTimeOfAppointmentRepository.Read();
                        if (_dictFreeTimeOfAppointments != null)
                        {
                            foreach (IDayWithFreeAppointments dayWithFreeAppointments in _dictFreeTimeOfAppointments[_appointments[_view.AppointmentId].DoctorDataOfAppointment.Id].FreeTimeOfAppointments)
                            {
                                if (dayWithFreeAppointments.DateOfAppointment == _view.DateOfAppointment)
                                {
                                    _newTimeOfAppointments = dayWithFreeAppointments.TimeOfAppointments;
                                    for (int i = 0; i < dayWithFreeAppointments.TimeOfAppointments.Count; i++)
                                    {
                                        if (dayWithFreeAppointments.TimeOfAppointments[i] == TimeOnly.FromDateTime(_appointment.DateAndTime))
                                        {
                                            _newTimeOfAppointments.Add(TimeOnly.FromDateTime(_appointment.DateAndTime));
                                            break;
                                        }
                                    }
                                }
                            }


                            foreach (IDayWithFreeAppointments dayWithFreeAppointments in _dictFreeTimeOfAppointments[_appointments[_view.AppointmentId].DoctorDataOfAppointment.Id].FreeTimeOfAppointments)
                            {
                                if (dayWithFreeAppointments.DateOfAppointment == _view.DateOfAppointment)
                                {
                                    dayWithFreeAppointments.TimeOfAppointments = _newTimeOfAppointments;
                                    break;
                                }
                            }

                            _jsonFreeTimeOfAppointmentRepository.Update(_dictFreeTimeOfAppointments[_appointments[_view.AppointmentId].DoctorDataOfAppointment.Id]);

                        }


                        




                            DateTime _timeOfAppointment = DateTime.Parse(_view.FreeTimeOfAppointment, CultureInfo.InvariantCulture);

                        _appointments[key].DateAndTime = new DateTime(_view.DateOfAppointment.Year, _view.DateOfAppointment.Month,
                            _view.DateOfAppointment.Day, _timeOfAppointment.Hour, _timeOfAppointment.Minute, 0);
                        _appointments[key].TypeOfAppointment = _view.TypeOfAppointment;
                        _appointments[key].Place = _view.Place;










                        _dictFreeTimeOfAppointments = _jsonFreeTimeOfAppointmentRepository.Read();
                        if (_dictFreeTimeOfAppointments != null)
                        {
                            foreach (IDayWithFreeAppointments dayWithFreeAppointments in _dictFreeTimeOfAppointments[_appointments[_view.AppointmentId].DoctorDataOfAppointment.Id].FreeTimeOfAppointments)
                            {
                                if (dayWithFreeAppointments.DateOfAppointment == _view.DateOfAppointment)
                                {
                                    _newTimeOfAppointments = dayWithFreeAppointments.TimeOfAppointments;
                                    for (int i = 0; i < dayWithFreeAppointments.TimeOfAppointments.Count; i++)
                                    {
                                        if (dayWithFreeAppointments.TimeOfAppointments[i] == TimeOnly.FromDateTime(_timeOfAppointment))
                                        {
                                            _newTimeOfAppointments.Remove(TimeOnly.FromDateTime(_timeOfAppointment));
                                            break;
                                        }
                                        
                                    }
                                }
                            }


                            foreach (IDayWithFreeAppointments dayWithFreeAppointments in _dictFreeTimeOfAppointments[_appointments[_view.AppointmentId].DoctorDataOfAppointment.Id].FreeTimeOfAppointments)
                            {
                                if (dayWithFreeAppointments.DateOfAppointment == _view.DateOfAppointment)
                                {
                                    dayWithFreeAppointments.TimeOfAppointments = _newTimeOfAppointments;
                                    break;
                                }
                            }

                            _jsonFreeTimeOfAppointmentRepository.Update(_dictFreeTimeOfAppointments[_appointments[_view.AppointmentId].DoctorDataOfAppointment.Id]);

                        }



                        if (_jsonAppointmentRepository.Update(_appointments[key]))
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
