using ARM_MedRegistrar.Data.Json.Dictionaries.PatientRepository;
using ARM_MedRegistrar.Model.Persons.Patients;
using ARM_MedRegistrar.View.MainWindow;
using ARM_MedRegistrar.Data.Json.Dictionaries;
using ARM_MedRegistrar.Data.Json.Dictionaries.FreeTimeOfAppointments;
using ARM_MedRegistrar.Model.DaysWithFreeAppointments;
using ARM_MedRegistrar.Model.FreeTimeOfAppointments;
using ARM_MedRegistrar.Model.Appointments;
using ARM_MedRegistrar.Data.Json.Dictionaries.AppointmentRepository;

namespace ARM_MedRegistrar.Presenter
{
    public class MainWindowPresenter
    { 
        IMainWindowForm _view;
        IBaseRepositoryWithCreatedID<uint, IPatient>  _jsonPatientRepository;
        IBaseRepository<uint, IFreeTimeOfAppointment> _jsonFreeTimeOfAppointmentRepository;
        IBaseRepository<uint, IAppointment> _jsonAppointmentRepository;
        IDictionary<uint, IFreeTimeOfAppointment>? _dictFreeTimeOfAppointments;
        IList<IDayWithFreeAppointments>? _resultListOfDaysWithAppointments;
        IDictionary<uint, IPatient>? _patients;
        IDictionary<uint, IAppointment>? _appointments;
        int _countOfLine = -1;
        bool _isSuccess;
        public MainWindowPresenter(IMainWindowForm view)
        { 
            _view = view;
            _jsonPatientRepository = new JsonPatientRepository();
            _jsonFreeTimeOfAppointmentRepository = new JsonFreeTimeOfAppointmentRepository();
            _jsonAppointmentRepository = new JsonAppointmentRepository();
        }


        public void ClearFreeAppointments()
        {
            _dictFreeTimeOfAppointments = _jsonFreeTimeOfAppointmentRepository.Read();

            if (_dictFreeTimeOfAppointments == null || _dictFreeTimeOfAppointments.Count == 0)
            {
                return;
            }

            foreach (uint key in _dictFreeTimeOfAppointments.Keys)
            {
                _resultListOfDaysWithAppointments = _dictFreeTimeOfAppointments[key].FreeTimeOfAppointments;
                foreach (IDayWithFreeAppointments dayWithFreeAppointments in _dictFreeTimeOfAppointments[key].FreeTimeOfAppointments)
                {
                    if (dayWithFreeAppointments.DateOfAppointment < DateOnly.FromDateTime(DateTime.Now))
                    {
                        _resultListOfDaysWithAppointments.Remove(dayWithFreeAppointments);
                    }

                }
                _dictFreeTimeOfAppointments[key].FreeTimeOfAppointments = _resultListOfDaysWithAppointments;

                _jsonFreeTimeOfAppointmentRepository.Update(_dictFreeTimeOfAppointments[key]);
            }


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
                foreach(IPatient patient in _patients.Values)
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
                        _view.PatientDocumentSeries = patient.DocumentSeries;
                        _view.PatientDocumentNumber = patient.DocumentNumber;
                        _view.PatientPlotNumber = patient.PlotNumber;
                        _view.PatientNumbOfPatientCard = patient.NumbOfPatientCard; 
                    }
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
            _countOfLine= -1;
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
                    _view.PatientDocumentSeries = patient.DocumentSeries;
                    _view.PatientDocumentNumber = patient.DocumentNumber;
                    _view.PatientPlotNumber = patient.PlotNumber;
                    _view.PatientNumbOfPatientCard = patient.NumbOfPatientCard;
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
        public bool RemovePatient(IList<uint> _listOfId)
        {
            _patients = _jsonPatientRepository.Read();
            if (_patients == null || _patients.Count == 0 || _listOfId.Count == 0)
                return false;
            
            if (_listOfId.Count == _patients.Count)
                return false;

            foreach (uint key in _patients.Keys)
            {
                foreach (uint id in _listOfId)
                {
                    if (key == id)
                    {
                        _jsonPatientRepository.Delete(id);
                    }
                }

            }

            return true;
            
        }


        public bool SearchAppointment()
        {
            DateTime _viewDateOfAppointment;
            _countOfLine = -1;
            _isSuccess = false;
            _appointments = _jsonAppointmentRepository.Read();
            if (_appointments == null || _appointments.Count == 0)
                return false;

            if (_appointments != null && _appointments.Count != 0)
            {
                foreach (IAppointment appointment in _appointments.Values)
                {
                    _viewDateOfAppointment = new DateTime(_view.DateOfAppointment.Year, _view.DateOfAppointment.Month, _view.DateOfAppointment.Day);
                    if (appointment.DateAndTime.Date ==  _viewDateOfAppointment)
                    {
                        _isSuccess = true;
                        _countOfLine++;
                        _view.AppointmentCountOfLine = _countOfLine;
                        _view.AppointmentId = appointment.Id;
                        _view.DateOfAppointment = new DateOnly(appointment.DateAndTime.Year, appointment.DateAndTime.Month, appointment.DateAndTime.Day);
                        _view.TimeOfAppointment = new TimeOnly(appointment.DateAndTime.Hour, appointment.DateAndTime.Minute, 0);
                        _view.PlaceOfAppointment = appointment.Place;
                        _view.AppointmentDoctorSpecialization = appointment.DoctorDataOfAppointment.Specialization;
                        _view.TypeOfAppointment = appointment.TypeOfAppointment;

                        _view.AppointmentDoctorId = appointment.DoctorDataOfAppointment.Id;
                        _view.AppointmentDoctorSurname = appointment.DoctorDataOfAppointment.PersonalData.FullName.Surname;
                        _view.AppointmentDoctorName = appointment.DoctorDataOfAppointment.PersonalData.FullName.Name;
                        _view.AppointmentDoctorPatronymic = appointment.DoctorDataOfAppointment.PersonalData.FullName.Patronymic;

                        _view.AppointmentPatientId = appointment.Patient.Id;
                        _view.AppointmentPatientSurname = appointment.Patient.PersonalData.FullName.Surname;
                        _view.AppointmentPatientName = appointment.Patient.PersonalData.FullName.Name;
                        _view.AppointmentPatientPatronymic = appointment.Patient.PersonalData.FullName.Patronymic;
                    }
                }
                if (_isSuccess)
                    return true;
                else
                    return false;
            }

            return false;
        }

        public bool ShowAllAppointments()
        {
            _countOfLine = -1;
            _isSuccess = false;
            _appointments = _jsonAppointmentRepository.Read();
            if (_appointments == null || _appointments.Count == 0)
                return false;

            if (_appointments != null && _appointments.Count != 0)
            {
                foreach (IAppointment appointment in _appointments.Values)
                {
                    _isSuccess = true;
                    _countOfLine++;
                    _view.AppointmentCountOfLine = _countOfLine;
                    _view.AppointmentId = appointment.Id;
                    _view.DateOfAppointment = new DateOnly(appointment.DateAndTime.Year, appointment.DateAndTime.Month, appointment.DateAndTime.Day);
                    _view.TimeOfAppointment = new TimeOnly(appointment.DateAndTime.Hour, appointment.DateAndTime.Minute, 0);
                    _view.PlaceOfAppointment = appointment.Place;
                    _view.AppointmentDoctorSpecialization = appointment.DoctorDataOfAppointment.Specialization;
                    _view.TypeOfAppointment = appointment.TypeOfAppointment;

                    _view.AppointmentDoctorId = appointment.DoctorDataOfAppointment.Id;
                    _view.AppointmentDoctorSurname = appointment.DoctorDataOfAppointment.PersonalData.FullName.Surname;
                    _view.AppointmentDoctorName = appointment.DoctorDataOfAppointment.PersonalData.FullName.Name;
                    _view.AppointmentDoctorPatronymic = appointment.DoctorDataOfAppointment.PersonalData.FullName.Patronymic;

                    _view.AppointmentPatientId = appointment.Patient.Id;
                    _view.AppointmentPatientSurname = appointment.Patient.PersonalData.FullName.Surname;
                    _view.AppointmentPatientName = appointment.Patient.PersonalData.FullName.Name;
                    _view.AppointmentPatientPatronymic = appointment.Patient.PersonalData.FullName.Patronymic;
                }
                if (_isSuccess)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public void ShowInfoAboutAppointment()
        {
            _appointments = _jsonAppointmentRepository.Read();
            if (_appointments == null || _appointments.Count == 0)
                return;

            if (_appointments != null && _appointments.Count != 0 && _view.AppointmentSelectedId != 0)
                _view.InfoAboutAppointment = _appointments[_view.AppointmentSelectedId].Format();
        }
        public bool RemoveAppointment(IList<uint> _listOfId)
        {
            _appointments = _jsonAppointmentRepository.Read();
            if (_appointments == null || _appointments.Count == 0 || _listOfId.Count == 0)
                return false;

            if (_listOfId.Count == _appointments.Count)
                return false;

            foreach (uint key in _appointments.Keys)
            {
                foreach (uint id in _listOfId)
                {
                    if (key == id)
                    {
                        _jsonAppointmentRepository.Delete(id);
                    }
                }

            }

            return true;

        }
    }
}
