using ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository;
using ARM_MedRegistrar.Data.Json.Dictionaries.PaidMedicalServiceRepository;
using ARM_MedRegistrar.Model.PaidMedServices;
using ARM_MedRegistrar.Model.Persons.Doctors;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.View.PaidMedServices;
using System.Security.Cryptography;
using ARM_MedRegistrar.Data.Json.Dictionaries;

namespace ARM_MedRegistrar.Presenter
{
    public class PaidMedServicesPresenter
    {
        IPaidMedServicesForm _view;
        IBaseWithIdRepository<uint, IPaidMedService> _jsonPaidMedServiceRepository;
        IPaidMedService _paidMedService;
        IDictionary<uint, IPaidMedService> _paidMedServices;
        uint _id;
        int _countOfLine;
        bool _isSuccess;
        public PaidMedServicesPresenter(IPaidMedServicesForm view) 
        { 
            _view = view;
            _jsonPaidMedServiceRepository = new JsonPaidMedServiceRepository();
        }

        public void AddPaidMedService()
        {
            
            _id = _jsonPaidMedServiceRepository.CreateId();
            _paidMedService = new PaidMedService(_view.Title, _view.Price, _id);
            _jsonPaidMedServiceRepository.Create(_paidMedService);
        }



        public bool SearchPaidMedService()
        {
            _countOfLine = -1;
            _isSuccess = false;
            _paidMedServices = _jsonPaidMedServiceRepository.Read();
            if (_paidMedServices == null || _paidMedServices.Count == 0)
                return false;

            if (_paidMedServices != null && _paidMedServices.Count != 0)
            {
                foreach (IPaidMedService paidMedService in _paidMedServices.Values)
                {
                    if (paidMedService.Title == _view.SearchingTitle)
                    {
                        _isSuccess = true;
                        _countOfLine++;
                        _view.CountOfLine = _countOfLine;
                        _view.Id = paidMedService.Id;
                        _view.Title = paidMedService.Title;
                        _view.Price = paidMedService.Price;
                    }
                }
                if (_isSuccess)
                    return true;
                else
                    return false;
            }

            return false;
        }

        public bool ShowAllPaidMedServices()
        {
            _countOfLine = -1;
            _isSuccess = false;
            _paidMedServices = _jsonPaidMedServiceRepository.Read();
            if (_paidMedServices == null || _paidMedServices.Count == 0)
                return false;

            if (_paidMedServices != null && _paidMedServices.Count != 0)
            {
                foreach (IPaidMedService paidMedService in _paidMedServices.Values)
                {
                    _isSuccess = true;
                    _countOfLine++;
                    _view.CountOfLine = _countOfLine;
                    _view.Id = paidMedService.Id;
                    _view.Title = paidMedService.Title;
                    _view.Price = paidMedService.Price;
                }
                if (_isSuccess)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public bool RemovePaidMedService(IList<uint> _listOfId)
        {
            _paidMedServices = _jsonPaidMedServiceRepository.Read();
            if (_paidMedServices == null || _paidMedServices.Count == 0 || _listOfId.Count == 0)
                return false;

            if (_listOfId.Count == _paidMedServices.Count)
                return false;

            foreach (uint key in _paidMedServices.Keys)
            {
                foreach (uint id in _listOfId)
                {
                    if (key == id)
                    {
                        _jsonPaidMedServiceRepository.Delete(id);
                    }
                }

            }
                
            return true;
            
            
        }


        public bool CalculateTotalPrice(IList<uint> _listOfId)
        {
            _paidMedServices = _jsonPaidMedServiceRepository.Read();
            if (_paidMedServices == null || _paidMedServices.Count == 0 || _listOfId.Count == 0)
                return false;

            if (_paidMedServices != null && _paidMedServices.Count != 0)
            {
                decimal _totalPrice = 0;
                foreach (uint key in _paidMedServices.Keys)
                {
                    foreach (uint id in _listOfId)
                    {
                        if (key == id)
                        {
                            _totalPrice += _paidMedServices[id].Price;
                        }
                    }

                }
                _view.TotalPrice = _totalPrice;
                return true;
            }
            return false;
        }
    }
}
