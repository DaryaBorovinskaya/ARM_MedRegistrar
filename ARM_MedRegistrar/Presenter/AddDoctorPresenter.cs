using ARM_MedRegistrar.Model.Json.DoctorRepository;
using ARM_MedRegistrar.View.AddDoctor;
using ARM_MedRegistrar.Model.Json.DoctorRepository;
using ARM_MedRegistrar.Model.Doctors;
using ARM_MedRegistrar.Model.Persons;

namespace ARM_MedRegistrar.Presenter
{
    public class AddDoctorPresenter
    {
        IAddDoctorForm _view;
        IFullName _fullName;
        IDoctor _newDoctor;
        IDoctorRepository _jsonDoctorRepository;
        public AddDoctorPresenter(IAddDoctorForm view)
        {
            _view = view;
        }

        

        public void AddDoctor()
        {
            _fullName = new FullName(_view.Surname, _view.Name, _view.Patronymic);
            _newDoctor = new Doctor(_fullName, _view.PhoneNumber, _view.Specializations, _view.PlotNumber, _view.Cabinet);

            _jsonDoctorRepository = new JsonDoctorRepository("doctors.json");
            _jsonDoctorRepository.Add(_newDoctor);
        }
    }
}
