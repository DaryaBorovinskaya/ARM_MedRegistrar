using ARM_MedRegistrar.View.AddDoctor;
using ARM_MedRegistrar.Model.Doctors;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository;

namespace ARM_MedRegistrar.Presenter
{
    public class AddDoctorPresenter
    {
        IAddDoctorForm _view;
        IFullName _fullName;
        IDoctor _newDoctor;
        IDoctorRepository _jsonDoctorRepository;
        uint _id;
        public AddDoctorPresenter(IAddDoctorForm view)
        {
            _view = view;
            _jsonDoctorRepository = new JsonDoctorRepository();
        }

        

        public void AddDoctor()
        {
            _fullName = new FullName(_view.Surname, _view.Name, _view.Patronymic);
            _id = _jsonDoctorRepository.CreateId();
            _newDoctor = new Doctor(_id, _fullName, _view.PhoneNumber, _view.Specializations, _view.PlotNumber, _view.Cabinet);
                  
            _jsonDoctorRepository.Add(_newDoctor);
        }
    }
}
