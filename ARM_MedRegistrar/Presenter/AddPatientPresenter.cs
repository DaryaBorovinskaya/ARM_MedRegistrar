using ARM_MedRegistrar.Data.Json.Dictionaries.PatientRepository;
using ARM_MedRegistrar.Data.Json.Lists.AttachedStreets;
using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.AttachedStreets;
using ARM_MedRegistrar.Model.Patients;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.View.AddPatient;

namespace ARM_MedRegistrar.Presenter
{
    public class AddPatientPresenter
    {
        IFullName _fullName;
        IPatient _newPatient;
        IAddress _address;
        IAddPatientForm _view;
        IAttachedStreetsRepository _jsonAttachedStreetsRepository;
        IList<IAttachedStreets>? _attStreets;
        uint _id;
        string _city, _region;
        IPatientRepository _jsonPatientRepository; 
        public AddPatientPresenter(IAddPatientForm view) 
        { 
            _view = view;
            _jsonAttachedStreetsRepository = new JsonAttachedStreetsRepository("attachedStreets.json");
            _attStreets = _jsonAttachedStreetsRepository.GetAll();
            _jsonPatientRepository = new JsonPatientRepository("patients.json");
        }



        public event EventHandler? NoCityEvent;
        public event EventHandler? NoRegionEvent;
        public bool AddPatient()
        {
            _fullName = new FullName(_view.Surname, _view.Name, _view.Patronymic);

            if (_attStreets != null && _attStreets.Count != 0)
            {
                _city = _view.City == string.Empty ? _attStreets[0].City : _view.City;
                _region = _view.Region == string.Empty ? _attStreets[0].Region : _view.Region;
                
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

            _address = new Address(_city, _region, _view.Street, _view.NumbOfHouse, _view.NumbOfFlat);


            _id = _jsonPatientRepository.CreateId();

            _newPatient = new Patient(_id, _fullName, _view.DateOfBirth, _address, _view.PlotNumber,
                _view.NumbOfPatientCard, _view.PolicySeries, _view.PolicyNumb, _view.DocumentSeries,
                _view.DocumentNumber, _view.BloodType, _view.RhFactor, _view.Allergies);

            _jsonPatientRepository.Add(_newPatient);
            return true;



            
            

        }

    }
}
