using ARM_MedRegistrar.Model.Json.DoctorRepository;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.View.AddDoctor;
using ARM_MedRegistrar.Model.Json.DoctorRepository;

namespace ARM_MedRegistrar.Presenter
{
    public class AddDoctorPresenter
    {
        IAddDoctorForm _view;
        FullName _fullName;
        Doctor _newDoctor;
        IDoctorRepository _jsonDoctorRepository;
        public AddDoctorPresenter(IAddDoctorForm view)
        {
            _view = view;
        }

        

        public void AddDoctor()
        {
            _fullName = new(_view.Surname, _view.Name, _view.Patronymic);
            _newDoctor = new(_fullName, _view.PhoneNumber, _view.Specializations, _view.PlotNumber, _view.Cabinet);

            _jsonDoctorRepository = new JsonDoctorRepository("doctors.json");
            _jsonDoctorRepository.Add(_newDoctor);
        }
    }
}
