using ARM_MedRegistrar.Data.Json.Dictionaries.PatientRepository;
using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.Persons.Patients;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.View.ChangeDataOfPatient;
using System.Windows.Forms;
using ARM_MedRegistrar.Data.Json.Dictionaries;

namespace ARM_MedRegistrar.Presenter
{
    public class ChangeDataOfPatientPresenter
    {
        IChangeDataOfPatientForm _view;
        IBaseRepositoryWithCreatedID<uint, IPatient> _jsonPatientRepository;
        IDictionary<uint, IPatient> _patients;
        IPatient _patient;

        public ChangeDataOfPatientPresenter(IChangeDataOfPatientForm view)
        {
            _view = view;
            _jsonPatientRepository = new JsonPatientRepository();
        }

        public bool ShowDataAboutPatient()
        {
            _patients = _jsonPatientRepository.Read();
            if (_patients == null || _patients.Count == 0)
                return false;

            if (_patients != null && _patients.Count != 0)
            {
                foreach (uint key in _patients.Keys)

                    if (key == _view.Id)
                    {
                        _patient = _patients[key];

                        _view.Surname = _patient.PersonalData.FullName.Surname;
                        _view.Name = _patient.PersonalData.FullName.Name;
                        _view.Patronymic = _patient.PersonalData.FullName.Patronymic;
                        _view.DateOfBirth = _patient.DateOfBirth;
                        _view.City = _patient.Address.AddressOfBuilding.City;
                        _view.Region = _patient.Address.AddressOfBuilding.Region;
                        _view.Street = _patient.Address.AddressOfBuilding.Street;
                        _view.NumbOfHouse = _patient.Address.AddressOfBuilding.NumbOfHouse;
                        _view.NumbOfFlat = _patient.Address.NumbOfFlat;
                        _view.PhoneNumber = _patient.PersonalData.PhoneNumber;
                        _view.PlotNumber = _patient.PlotNumber;
                        _view.NumbOfPatientCard = _patient.NumbOfPatientCard;
                        _view.PolicySeries = _patient.PolicySeries;
                        _view.PolicyNumb = _patient.PolicyNumb;
                        _view.DocumentSeries = _patient.DocumentSeries;
                        _view.DocumentNumber = _patient.DocumentNumber;
                        _view.BloodType = _patient.BloodType;
                        _view.RhFactor = _patient.RhFactor;
                        _view.Allergies = _patient.Allergies;

                        return true;
                    }

            }
            return false;
        }

        public bool SaveChanges()
        {
            _patients = _jsonPatientRepository.Read();
            if (_patients == null || _patients.Count == 0)
                return false;

            if (_patients != null && _patients.Count != 0)
            {
                foreach (uint key in _patients.Keys)
                {
                    if (key == _view.Id)
                    {
                        _patient = _patients[key];
                        _patient.PersonalData.FullName.Surname = _view.Surname;
                        _patient.PersonalData.FullName.Name = _view.Name;
                        _patient.PersonalData.FullName.Patronymic = _view.Patronymic;
                        _patient.Address.AddressOfBuilding.City = _view.City;
                        _patient.Address.AddressOfBuilding.Region = _view.Region;
                        _patient.Address.AddressOfBuilding.Street = _view.Street;
                        _patient.Address.AddressOfBuilding.NumbOfHouse = _view.NumbOfHouse;
                        _patient.Address.NumbOfFlat = _view.NumbOfFlat;
                        _patient.PersonalData.PhoneNumber = _view.PhoneNumber;
                        _patient.PlotNumber = _view.PlotNumber;
                        _patient.NumbOfPatientCard = _view.NumbOfPatientCard;
                        _patient.PolicySeries = _view.PolicySeries;
                        _patient.PolicyNumb = _view.PolicyNumb;
                        _patient.DocumentSeries = _view.DocumentSeries;
                        _patient.DocumentNumber = _view.DocumentNumber;
                        _patient.BloodType = _view.BloodType;
                        _patient.RhFactor = _view.RhFactor;
                        _patient.Allergies = _view.Allergies;

                        if (_jsonPatientRepository.Update(_patient))
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
