using ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository;
using ARM_MedRegistrar.Data.Json.Dictionaries.PaidMedicalServiceRepository;
using ARM_MedRegistrar.Model.PaidMedServices;
using ARM_MedRegistrar.Model.Persons.Doctors;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.View.PaidMedServices;
using System.Security.Cryptography;
using ARM_MedRegistrar.Data.Json.Dictionaries;

namespace ARM_MedRegistrar.Presenter.PaidMedServices
{
    public class PaidMedServicesPresenter :IPaidMedServicesPresenter
    {
        IPaidMedServicesForm _view;
        string result;
        IPaidMedService _paidMedService;

        uint IPaidMedServicesPresenter.Id { set => _view.Id = value; }
        int IPaidMedServicesPresenter.CountOfLine { set => _view.CountOfLine = value; }
        string IPaidMedServicesPresenter.Title { set => _view.Title = value; }
        decimal IPaidMedServicesPresenter.Price { set => _view.Price = value; }
        decimal IPaidMedServicesPresenter.TotalPrice { set => _view.TotalPrice = value; }

        public PaidMedServicesPresenter(IPaidMedServicesForm view)
        {
            _view = view;
            _paidMedService = new PaidMedService(this);
        }


        public int MaxPrice()
        {
            return PaidMedService.MaxPrice();
        }


        public void AddPaidMedService()
        {
            _id = _jsonPaidMedServiceRepository.CreateID();
            _paidMedService = new PaidMedService(_view.Title, _view.Price, _id);
            _jsonPaidMedServiceRepository.Create(_paidMedService);
        }



        public string IsSearchPaidMedService()
        {
            try
            {
                result = PaidMedService.IsSearchPaidMedService(_view.SearchingTitle);
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
        }


        public string EmptyList()
        {
            return PaidMedService.EmptyList();
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


        public string ConfirmationRemove(string line)
        {
            return PaidMedService.ConfirmationRemove(line);
        }



        public string IsRemovePaidMedService(IList<uint> _listOfId)
        {
            try
            {
                result = PaidMedService.IsRemovePaidMedService(_listOfId);
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
        }

        public  string SuccessRemove()
        {
            return PaidMedService.SuccessRemove();
        }

        public  string FailureRemove()
        {
            return PaidMedService.FailureRemove();
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
