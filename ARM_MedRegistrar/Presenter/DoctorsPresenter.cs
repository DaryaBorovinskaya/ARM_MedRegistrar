using ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository;
using ARM_MedRegistrar.Data.Json.Dictionaries.PatientRepository;
using ARM_MedRegistrar.Model.Persons.Doctors;
using ARM_MedRegistrar.View.Doctors;


namespace ARM_MedRegistrar.Presenter
{
    public class DoctorsPresenter
    {
        IDoctorsForm _view;
        IDoctorRepository _jsonDoctorRepository;
        IDictionary<uint, IDoctor>? _doctors;
        int _countOfLine = -1;
        bool _isSuccess;
        public DoctorsPresenter(IDoctorsForm view)
        {
            _view = view;
            _jsonDoctorRepository = new JsonDoctorRepository();
        }


        public bool SearchDoctor()
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
                    if (doctor.FullName.Surname == _view.Surname && doctor.FullName.Name == _view.Name 
                        && doctor.Specialization == _view.Specialization)
                    {
                        _isSuccess = true;
                        _countOfLine++;
                        _view.CountOfLine = _countOfLine;
                        _view.Id = doctor.Id;
                        _view.Surname = doctor.FullName.Surname;
                        _view.Name = doctor.FullName.Name;
                        _view.Patronymic = doctor.FullName.Patronymic;
                        _view.Specialization = doctor.Specialization;
                        _view.Cabinet = doctor.Cabinet;
                        _view.PlotNumber = doctor.PlotNumber;
                    }
                }
                if (_isSuccess)
                    return true;
                else
                    return false;
            }

            return false;
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
                    _view.CountOfLine = _countOfLine; 
                    _view.Id = doctor.Id;
                    _view.Surname = doctor.FullName.Surname;
                    _view.Name = doctor.FullName.Name;
                    _view.Patronymic = doctor.FullName.Patronymic;
                    _view.Specialization = doctor.Specialization;
                    _view.Cabinet = doctor.Cabinet;
                    _view.PlotNumber = doctor.PlotNumber;
                }
                if (_isSuccess)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public void ShowInfoAboutDoctor()
        {
            _doctors = _jsonDoctorRepository.GetAll();
            if (_doctors == null || _doctors.Count == 0)
                return;

            if (_doctors != null && _doctors.Count != 0 && _view.SelectedId != 0)
                _view.InfoAboutPatient = _doctors[_view.SelectedId].Format();
        }
        public bool RemoveDoctor(IList<uint> _listOfId)
        {
            _doctors = _jsonDoctorRepository.GetAll();
            if (_doctors == null || _doctors.Count == 0 || _listOfId.Count == 0)
                return false;
            if (_listOfId.Count == _doctors.Count)
                return false;


            foreach (uint key in _doctors.Keys)
                {
                    foreach (uint id in _listOfId)
                    {
                        if (key == id)
                        {
                            _jsonDoctorRepository.Remove(id);
                        }
                    }

                }

                return true;
            
           
        }
    }

}
