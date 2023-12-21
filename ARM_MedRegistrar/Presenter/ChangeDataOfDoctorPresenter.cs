using ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository;
using ARM_MedRegistrar.Model.Persons.Doctors;
using ARM_MedRegistrar.View.ChangeDataOfDoctor;

namespace ARM_MedRegistrar.Presenter
{
    public class ChangeDataOfDoctorPresenter
    {
        IChangeDataOfDoctorForm _view;
        IDoctorRepository _jsonDoctorRepository;
        IDictionary<uint, IDoctor> _doctors;
        IDoctor _doctor;

        public ChangeDataOfDoctorPresenter(IChangeDataOfDoctorForm view) 
        { 
            _view = view;
            _jsonDoctorRepository = new JsonDoctorRepository();
        }


        public bool ShowDataAboutDoctor()
        {
            _doctors = _jsonDoctorRepository.GetAll();
            if (_doctors == null || _doctors.Count == 0)
                return false;

            if (_doctors != null && _doctors.Count != 0)
            {
                foreach (uint key in _doctors.Keys)

                    if (key == _view.Id)
                    {
                        _doctor = _doctors[key];

                        _view.Surname = _doctor.FullName.Surname;
                        _view.Name = _doctor.FullName.Name;
                        _view.Patronymic = _doctor.FullName.Patronymic;
                        _view.PhoneNumber = _doctor.PhoneNumber;
                        _view.PlotNumber = _doctor.PlotNumber;
                        _view.Specialization = _doctor.Specialization;
                        _view.Cabinet = _doctor.Cabinet;

                        return true;
                    }

            }
            return false;
        }

        public bool SaveChanges()
        {
            foreach (uint key in _doctors.Keys)
            {
                if (key == _view.Id)
                {
                    _doctor = _doctors[key];
                    _doctor.FullName.Surname = _view.Surname;
                    _doctor.FullName.Name = _view.Name;
                    _doctor.FullName.Patronymic = _view.Patronymic;
                    _doctor.PhoneNumber = _view.PhoneNumber;
                    _doctor.PlotNumber = _view.PlotNumber;
                    _doctor.Specialization = _view.Specialization;
                    _doctor.Cabinet = _view.Cabinet;

                    if (_jsonDoctorRepository.SaveChangedData(_doctor))
                        return true;
                }
            }
            return false;
        }
    }
}

