using ARM_MedRegistrar.Model.Persons.Users;
using ARM_MedRegistrar.Data.Json.Dictionaries;
using ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository;
using ARM_MedRegistrar.Data.Json.Dictionaries.UserRepository;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans;
using ARM_MedRegistrar.Model.WorksBeginningEnd;
using ARM_MedRegistrar.Model.WorkSchedules;
using ARM_MedRegistrar.Presenter.AddDoctor;
using Newtonsoft.Json;
using ARM_MedRegistrar.Presenter.Doctors;

namespace ARM_MedRegistrar.Model.Persons.Doctors
{
    public class Doctor : IDoctor
    {
        static IAddDoctorPresenter _addPresenter;
        static IDoctorPresenter _doctorPresenter;
        static int _plotNumber;
        private IDoctorDataOfAppointment _doctorDataOfAppointment;
        private IList<IWorkSchedule> _workSchedules;
        
        public IDoctorDataOfAppointment DoctorDataOfAppointment 
        {
            get => _doctorDataOfAppointment;
            set
            {
                if (value == null)
                    throw new ArgumentException(nameof(value));
                _doctorDataOfAppointment = value;
            }
        }

        public IList<IWorkSchedule> WorkSchedule
        {
            get => _workSchedules;
            set
            {
                if (value == null)
                    throw new ArgumentException(nameof(value));
                _workSchedules = value;
            }
        }


        public Doctor(IAddDoctorPresenter addPresenter)
        {
            _addPresenter = addPresenter;
        }

        public Doctor(IDoctorPresenter doctorPresenter)
        {
            _doctorPresenter = doctorPresenter;
        }

        [JsonConstructor]
        public Doctor(IDoctorDataOfAppointment doctorDataOfAppointment,  IList<IWorkSchedule> workSchedule )
        {
            DoctorDataOfAppointment = doctorDataOfAppointment;
            WorkSchedule = workSchedule;
        }

        public string Format()
        {
            string _lineSchedule = "";
            foreach (IWorkSchedule workSchedule in WorkSchedule) 
                 _lineSchedule += workSchedule.Format();


            return $"{DoctorDataOfAppointment.Format()}ГРАФИК РАБОТЫ\n\n{_lineSchedule}";
        }

        public static IList<string> SetSpecialization()
        {
            return new List<string> { "терапевт", "педиатр", "врач общей практики", "хирург", "невролог", "оториноларинголог", "офтальмолог", "травматолог", "акушер-гинеколог", "уролог", "инфекционист", "онколог", "гастроэнтеролог", "кардиолог", "эндокринолог" };
        }


        public static bool IsCorrectTime(DateTime timeBeginning, DateTime timeEnd)
        {
            if ((timeEnd.Hour - timeBeginning.Hour < 1) && (timeEnd.Minute - timeBeginning.Minute <= 1))
                return false;
            return true;
        }

        public static string SuccessAdd()
        {
            return "Добавление врача успешно выполнено!";
        }

        public static string NoCorrectTime()
        {
            return "Поле заполнено некорректно\n(нажмите \"Вых.\", если врач в этот день не работает)";
        }


        public static string SetPlotNumber(string specialisation, int plotNumber)
        {
            if (specialisation != "терапевт" && specialisation != "педиатр" && specialisation != "врач общей практики")
            {
                _plotNumber = 0;
                _addPresenter.PlotNumber = 0;
                return string.Empty;
            }
            else if (plotNumber == 0)
                throw new ArgumentException("Поле заполнено неверно");
            return string.Empty;
        }

        public static string AddDoctor(string surname, string name, string? patronymic, string phoneNumber, 
            string specialization, int cabinet, TimeOnly duration, IList<TimeOnly> timesOfWork)
        {
            TimeOnly nullTime = new(0, 0, 0);
            IBaseRepositoryWithCreatedID<uint, IDoctor> _jsonDoctorRepository = new JsonDoctorRepository();
            IWorkSchedule _workSchedule;
            IList<IWorkSchedule> _workSchedules = new List<IWorkSchedule>();

            for (int i = 0; i < timesOfWork.Count; i += 2)
            {
                if (timesOfWork[i] == nullTime && timesOfWork[i + 1] == nullTime)
                    continue;

                else
                {
                    _workSchedule = new WorkScheduleOfDoctor(WorkScheduleOfDoctor.GetDaysOfWeek[i / 2], new WorkBeginningEnd(timesOfWork[i], timesOfWork[i + 1]));
                    _workSchedules.Add(_workSchedule);
                }

            }

            try 
            {
                IDoctor _newDoctor = new Doctor(new DoctorDataOfAppointment(_jsonDoctorRepository.CreateID(), new PersonalData(new FullName(surname,name, patronymic), phoneNumber), specialization, _plotNumber,
                cabinet, duration), _workSchedules);
                _jsonDoctorRepository.Create(_newDoctor);
            }
            catch (ArgumentException e)
            {
                return e.Message;
            }
            return string.Empty;
        }




        public static string SearchDoctor(string surname, string name, string specialization)
        {
            IBaseRepositoryWithCreatedID<uint, IDoctor> _jsonDoctorRepository = new JsonDoctorRepository();
            IDictionary<uint, IDoctor>? _doctors;
            int _countOfLine = -1;
            bool _isSuccess = false;
            _doctors = _jsonDoctorRepository.Read();
            if (_doctors == null || _doctors.Count == 0)
                throw new ArgumentException("Список врачей пуст");

            if (_doctors != null && _doctors.Count != 0)
            {
                foreach (IDoctor doctor in _doctors.Values)
                {
                    if (doctor.DoctorDataOfAppointment.PersonalData.FullName.Surname == surname && doctor.DoctorDataOfAppointment.PersonalData.FullName.Name == name
                        && doctor.DoctorDataOfAppointment.Specialization == specialization)
                    {
                        _isSuccess = true;
                        _countOfLine++;
                        _doctorPresenter.CountOfLine = _countOfLine;
                        _doctorPresenter.Id = doctor.DoctorDataOfAppointment.Id;
                        _doctorPresenter.Surname = doctor.DoctorDataOfAppointment.PersonalData.FullName.Surname;
                        _doctorPresenter.Name = doctor.DoctorDataOfAppointment.PersonalData.FullName.Name;
                        _doctorPresenter.Patronymic = doctor.DoctorDataOfAppointment.PersonalData.FullName.Patronymic;
                        _doctorPresenter.Specialization = doctor.DoctorDataOfAppointment.Specialization;
                        _doctorPresenter.Cabinet = doctor.DoctorDataOfAppointment.Cabinet;
                        _doctorPresenter.PlotNumber = doctor.DoctorDataOfAppointment.PlotNumber;
                    }
                }
                if (_isSuccess)
                    return string.Empty;
                else
                    throw new ArgumentException("Не удалось найти"); 
            }

            throw new ArgumentException("Список врачей пуст");
        }

        public static string ShowAllDoctors()
        {
            IBaseRepositoryWithCreatedID<uint, IDoctor> _jsonDoctorRepository = new JsonDoctorRepository();
            IDictionary<uint, IDoctor>? _doctors;
            int _countOfLine = 0 ;
            bool _isSuccess = false;

            
            _doctors = _jsonDoctorRepository.Read();
            if (_doctors == null || _doctors.Count == 0)
                throw new ArgumentException("Список врачей пуст");

            if (_doctors != null && _doctors.Count != 0)
            {
                foreach (IDoctor doctor in _doctors.Values)
                {
                    _isSuccess = true;
                    _doctorPresenter.CountOfLine = _countOfLine;
                    _doctorPresenter.Id = doctor.DoctorDataOfAppointment.Id;
                    _doctorPresenter.Surname = doctor.DoctorDataOfAppointment.PersonalData.FullName.Surname;
                    _doctorPresenter.Name = doctor.DoctorDataOfAppointment.PersonalData.FullName.Name;
                    _doctorPresenter.Patronymic = doctor.DoctorDataOfAppointment.PersonalData.FullName.Patronymic;
                    _doctorPresenter.Specialization = doctor.DoctorDataOfAppointment.Specialization;
                    _doctorPresenter.Cabinet = doctor.DoctorDataOfAppointment.Cabinet;
                    _doctorPresenter.PlotNumber = doctor.DoctorDataOfAppointment.PlotNumber;

                    _countOfLine++;
                }
                if (_isSuccess)
                    return string.Empty;
                else
                    throw new ArgumentException("Список врачей пуст");
            }
            throw new ArgumentException("Список врачей пуст");
        }



        public static string ShowInfoAboutDoctor(uint selectedId)
        {
            IBaseRepositoryWithCreatedID<uint, IDoctor> _jsonDoctorRepository = new JsonDoctorRepository();
            IDictionary<uint, IDoctor>? _doctors;
            
            _doctors = _jsonDoctorRepository.Read();

            if (_doctors == null || _doctors.Count == 0)
                throw  new ArgumentException("Список врачей пуст");

            if (_doctors != null && _doctors.Count != 0 && selectedId != 0)
                _doctorPresenter.InfoAboutDoctor = _doctors[selectedId].Format();
            return string.Empty;
        }


        public static string RemoveDoctor(IList<uint> _listOfId)
        {
            IBaseRepositoryWithCreatedID<uint, IDoctor> _jsonDoctorRepository = new JsonDoctorRepository();
            IDictionary<uint, IDoctor>? _doctors;
            
            _doctors = _jsonDoctorRepository.Read();
            if (_doctors == null || _doctors.Count == 0 || _listOfId.Count == 0)
                throw new ArgumentException("Список врачей пуст");
            if (_listOfId.Count == _doctors.Count && CheckAccessLevel() != string.Empty)
                throw new ArgumentException("Нельзя удалить всех врачей");


            foreach (uint key in _doctors.Keys)
            {
                foreach (uint id in _listOfId)
                {
                    if (key == id)
                    {
                        _jsonDoctorRepository.Delete(id);
                    }
                }

            }

            return string.Empty;


        }

        public static string CheckAccessLevel()
        {
            JsonCurrentUserRepository _jsonCurrentUserRepository = new();
            User? _user = _jsonCurrentUserRepository.Read();
            if (_user == null)
                throw new ArgumentException("Нулевое значение пользователя");

            if (_user.Post != User.SetPost()[0])
                return string.Empty;
            throw new ArgumentException("Ошибка: данная функция Вам недоступна");
        }


        public static string MultiSelect()
        {
            return "Нельзя выполнить действие, т.к. \nвыбрано несколько врачей";
        }



        public static string EmptyList()
        {
            return "Список врачей пуст";
        }

        public static string SuccessRemove()
        {
            return "Врач(и) успешно удален(ы)";
        }

        public static string FailureRemove()
        {
            return "Не удалось удалить врача(ей)";
        }


        public static string ConfirmationRemove(string line)
        {
            return $"Подтвердите действие: удаление врачей с ID: {line}";
        }
    }
}
