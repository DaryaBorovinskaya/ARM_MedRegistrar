using ARM_MedRegistrar.Data.Json.Dictionaries.PatientRepository;
using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.AttachedStreets;
using ARM_MedRegistrar.Model.Persons.Patients;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.View.AddPatient;
using ARM_MedRegistrar.Data.Json.Dictionaries;
using ARM_MedRegistrar.Data.Json.Dictionaries.AttachedStreets;
using ARM_MedRegistrar.Model.AddressesOfBuilding;

namespace ARM_MedRegistrar.Presenter
{
    public class AddPatientPresenter
    {
        IFullName _fullName;
        IPatient _newPatient;
        IPatientAddress _address;
        IAddPatientForm _view;
        IBaseRepositoryWithCreatedID<uint, IAttachedStreets> _jsonAttachedStreetsRepository;
        IDictionary<uint,IAttachedStreets>? _attStreets;
        uint _id;
        string _city, _region;
        IBaseRepositoryWithCreatedID<uint, IPatient> _jsonPatientRepository;
        IAddressOfBuilding _addressOfBuilding;
        public AddPatientPresenter(IAddPatientForm view) 
        { 
            _view = view;
            _jsonAttachedStreetsRepository = new JsonAttachedStreetsRepository();
            
            _jsonPatientRepository = new JsonPatientRepository();
        }



        public event EventHandler? NoCityEvent;
        public event EventHandler? NoRegionEvent;
        public bool AddPatient()
        {
            _attStreets = _jsonAttachedStreetsRepository.Read();
            _fullName = new FullName(_view.Surname, _view.Name, _view.Patronymic);

            if (_attStreets != null && _attStreets.Count != 0)
            {
                _city = _view.City == string.Empty ? _attStreets[0].AddressOfBuilding.City : _view.City;
                _region = _view.Region == string.Empty ? _attStreets[0].AddressOfBuilding.Region : _view.Region;
                
            }

            else if (_attStreets != null && _attStreets.Count == 0)
            {
                if (_view.City == string.Empty)
                {
                    NoCityEvent?.Invoke(this, EventArgs.Empty);
                    return false;
                }
                else
                    _city = _view.City;
                

                if (_view.Region == string.Empty) 
                {
                    NoRegionEvent?.Invoke(this, EventArgs.Empty);
                    return false;
                }
                else
                    _region = _view.Region;
                
            }

            _addressOfBuilding = new AddressOfBuilding(_city, _region, _view.Street, _view.NumbOfHouse);
            _address = new PatientAddress(_addressOfBuilding, _view.NumbOfFlat);


            _id = _jsonPatientRepository.CreateID();

            _newPatient = new Patient(_id, _fullName, _view.DateOfBirth, _address, _view.PhoneNumber, _view.PlotNumber,
                _view.NumbOfPatientCard, _view.PolicySeries, _view.PolicyNumb, _view.DocumentSeries,
                _view.DocumentNumber, _view.BloodType, _view.RhFactor, _view.Allergies);

            _jsonPatientRepository.Create(_newPatient);
            return true;
        }

    }
}
