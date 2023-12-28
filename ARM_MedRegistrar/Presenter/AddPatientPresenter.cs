using ARM_MedRegistrar.Data.Json.Dictionaries.PatientRepository;
using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.AttachedStreets;
using ARM_MedRegistrar.Model.Persons.Patients;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.View.AddPatient;
using ARM_MedRegistrar.Data.Json.Dictionaries;
using ARM_MedRegistrar.Data.Json.Dictionaries.AttachedStreets;
using ARM_MedRegistrar.Model.AddressesOfBuilding;
using ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans;

namespace ARM_MedRegistrar.Presenter
{
    public class AddPatientPresenter
    {
        IFullName _fullName;
        IPersonalData _personalData;
        IPatient _newPatient;
        IPatientAddress _address;
        IAddPatientForm _view;
        IBaseRepositoryWithCreatedID<uint, IAttachedStreets> _jsonAttachedStreetsRepository;
        IDictionary<uint,IAttachedStreets>? _attStreets;
        uint _id;
        string _city, _region;
        int _plotNumber;
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


        public IList<string> SetBloodType()
        {
            return Patient.SetBloodType();
        }

        public IList<string> SetRhFactor()
        {
            return Patient.SetRhFactor();
        }


        public void SetDataFromAttStreets()
        {
            _attStreets = _jsonAttachedStreetsRepository.Read();
            if (_attStreets != null && _attStreets.Count != 0)
            {
                _city = _view.City == string.Empty ? _attStreets[_attStreets.First().Key].AddressOfBuilding.City : _view.City;
                _region = _view.Region == string.Empty ? _attStreets[_attStreets.First().Key].AddressOfBuilding.Region : _view.Region;

                _view.City = _city;
                _view.Region = _region;
                foreach(uint key in _attStreets.Keys)
                {
                    if (_attStreets[key].AddressOfBuilding.City == _view.City && _attStreets[key].AddressOfBuilding.Region == _view.Region
                        && _attStreets[key].AddressOfBuilding.Street == _view.Street && _attStreets[key].AddressOfBuilding.NumbOfHouse == _view.NumbOfHouse)
                    {
                        _plotNumber = (int)key;
                        _view.PlotNumber = _plotNumber;
                    }
                }
            }

            else if (_attStreets != null && _attStreets.Count == 0)
            {
                if (_view.City == string.Empty)
                {
                    NoCityEvent?.Invoke(this, EventArgs.Empty);
                    return;
                }
                else
                    _city = _view.City;


                if (_view.Region == string.Empty)
                {
                    NoRegionEvent?.Invoke(this, EventArgs.Empty);
                    return;
                }
                else
                    _region = _view.Region;

            }
        }

        public bool AddPatient()
        {
            
            _fullName = new FullName(_view.Surname, _view.Name, _view.Patronymic);
            _personalData = new PersonalData(_fullName, _view.PhoneNumber);

            

            _addressOfBuilding = new AddressOfBuilding(_city, _region, _view.Street, _view.NumbOfHouse);
            _address = new PatientAddress(_addressOfBuilding, _view.NumbOfFlat);


            _id = _jsonPatientRepository.CreateID();

            _newPatient = new Patient(_id, _personalData, _view.DateOfBirth, _address, _view.PlotNumber,
                _view.NumbOfPatientCard, _view.PolicySeries, _view.PolicyNumb, _view.DocumentSeries,
                _view.DocumentNumber, _view.BloodType, _view.RhFactor, _view.Allergies);

            _jsonPatientRepository.Create(_newPatient);
            return true;
        }

    }
}
