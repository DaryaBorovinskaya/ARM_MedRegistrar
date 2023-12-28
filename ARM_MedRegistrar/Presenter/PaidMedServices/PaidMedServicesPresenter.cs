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


        public string AddPaidMedService()
        {
            try
            {
                result = PaidMedService.AddPaidMedService(_view.Title,_view.Price);
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
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



        public  string ShowAllPaidMedServices()
        {
            try
            {
                result = PaidMedService.ShowAllPaidMedServices();
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
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




        public string CalculateTotalPrice(IList<uint> _listOfId)
        {
            try
            {
                result = PaidMedService.CalculateTotalPrice(_listOfId);
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
        }
    }
}
