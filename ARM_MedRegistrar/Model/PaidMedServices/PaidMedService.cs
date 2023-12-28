using ARM_MedRegistrar.Data.Json.Dictionaries;
using ARM_MedRegistrar.Data.Json.Dictionaries.PaidMedicalServiceRepository;
using ARM_MedRegistrar.Presenter.PaidMedServices;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ARM_MedRegistrar.Model.PaidMedServices
{
    public class PaidMedService : IPaidMedService
    {
        static IPaidMedServicesPresenter _presenter;
        private string _title;
        private decimal _price;
        public string Title 
        {
            get => _title; 
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Наименование услуги не задано");

                _title = value;
            }
               
        }
        public decimal Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Цена не может иметь значение 0 и меньше");
                

                _price = value;
            }

        }
        public uint Id { get; }

        public PaidMedService(IPaidMedServicesPresenter presenter)
        {
            _presenter = presenter;
        }

        [JsonConstructor]
        public PaidMedService(string title, decimal price, uint id) 
        {
            Title = title;
            Price = price;
            Id = id;
        }



        public static string AddPaidMedService(string title, decimal price)
        {
            IBaseRepositoryWithCreatedID<uint, IPaidMedService> _jsonPaidMedServiceRepository = new JsonPaidMedServiceRepository();
            
            IDictionary<uint, IPaidMedService> _paidMedServices;
            uint _id = _jsonPaidMedServiceRepository.CreateID();
            try
            {
                IPaidMedService _paidMedService = new PaidMedService(title, price, _id);
                _jsonPaidMedServiceRepository.Create(_paidMedService);
            }
            catch (ArgumentException e)
            {
                return e.Message;
            }

            return string.Empty;
            
        }



        public static string IsSearchPaidMedService(string searchingTitle)
        {
            IBaseRepositoryWithCreatedID<uint, IPaidMedService> _jsonPaidMedServiceRepository = new JsonPaidMedServiceRepository();
            
            IDictionary<uint, IPaidMedService> _paidMedServices;
            uint _id;
            int _countOfLine = -1;
            bool _isSuccess = false;


            _paidMedServices = _jsonPaidMedServiceRepository.Read();

            if (_paidMedServices == null || _paidMedServices.Count == 0)
                throw new ArgumentException("Список платных медицинских услуг пуст");

            if (_paidMedServices != null && _paidMedServices.Count != 0)
            {
                foreach (IPaidMedService paidMedService in _paidMedServices.Values)
                {
                    if (paidMedService.Title == searchingTitle)
                    {
                        _isSuccess = true;
                        _countOfLine++;
                        _presenter.CountOfLine = _countOfLine;
                        _presenter.Id = paidMedService.Id;
                        _presenter.Title = paidMedService.Title;
                        _presenter.Price = paidMedService.Price;
                    }
                }
                if (!_isSuccess)
                    throw new ArgumentException("Не удалось найти");
                else
                    return string.Empty;

            }
            throw new ArgumentException("Список платных медицинских услуг пуст");
        }


        public static int MaxPrice()
        {
            return 50000;
        }


        public static string EmptyList()
        {
            return "Список услуг пуст";
        }


        public static string ConfirmationRemove( string line)
        {
            return $"Подтвердите действие: удаление услуг с ID: {line}";
        }



        public static string IsRemovePaidMedService(IList<uint> _listOfId)
        {
            IBaseRepositoryWithCreatedID<uint, IPaidMedService> _jsonPaidMedServiceRepository = new JsonPaidMedServiceRepository();
            IDictionary<uint, IPaidMedService> _paidMedServices;
            bool _isSuccess = false ;
            _paidMedServices = _jsonPaidMedServiceRepository.Read();

            if (_paidMedServices == null || _paidMedServices.Count == 0 || _listOfId.Count == 0)
                throw new ArgumentException("Список платных мед. услу пуст");

            if (_listOfId.Count == _paidMedServices.Count)
                throw new ArgumentException("Нельзя удалить все платные мед. услуги");

            foreach (uint key in _paidMedServices.Keys)
            {
                foreach (uint id in _listOfId)
                {
                    if (key == id)
                    {
                        _jsonPaidMedServiceRepository.Delete(id);
                        _isSuccess = true ;
                    }
                }
               
            }
            if (_isSuccess)
                return string.Empty;
            throw new ArgumentException("Hе удалось удалить");

        }

        public static string SuccessRemove()
        {
            return "Услуга(и) успешно удалены";
        }

        public static string FailureRemove()
        {
            return "Не удалось удалить услугу(и)";
        }


        public static string CalculateTotalPrice(IList<uint> listOfId)
        {
            IBaseRepositoryWithCreatedID<uint, IPaidMedService> _jsonPaidMedServiceRepository = new JsonPaidMedServiceRepository();
            IDictionary<uint, IPaidMedService> _paidMedServices;

            _paidMedServices = _jsonPaidMedServiceRepository.Read();

            if (_paidMedServices == null || _paidMedServices.Count == 0 || listOfId.Count == 0)
                throw new ArgumentException("Список платных мед. услу пуст");

            if (_paidMedServices != null && _paidMedServices.Count != 0)
            {
                decimal _totalPrice = 0;
                foreach (uint key in _paidMedServices.Keys)
                {
                    foreach (uint id in listOfId)
                    {
                        if (key == id)
                        {
                            _totalPrice += _paidMedServices[id].Price;
                        }
                    }
                }
                _presenter.TotalPrice = _totalPrice;
                return string.Empty;
            }
            throw new ArgumentException("Не удалось посчитать");
        }

        public static string ShowAllPaidMedServices()
        {
            IBaseRepositoryWithCreatedID<uint, IPaidMedService> _jsonPaidMedServiceRepository = new JsonPaidMedServiceRepository();

            IDictionary<uint, IPaidMedService> _paidMedServices;
            uint _id;
            int _countOfLine = -1;
            bool _isSuccess = false;


            _paidMedServices = _jsonPaidMedServiceRepository.Read();

            if (_paidMedServices == null || _paidMedServices.Count == 0)
                throw new ArgumentException("Список платных медицинских услуг пуст");

            if (_paidMedServices != null && _paidMedServices.Count != 0)
            {
                foreach (IPaidMedService paidMedService in _paidMedServices.Values)
                {
                    _isSuccess = true;
                    _countOfLine++;
                    _presenter.CountOfLine = _countOfLine;
                    _presenter.Id = paidMedService.Id;
                    _presenter.Title = paidMedService.Title;
                    _presenter.Price = paidMedService.Price;
                }
                if (!_isSuccess)
                    throw new ArgumentException("Не удалось найти");
                else
                    return string.Empty;
            }
            throw new ArgumentException("Список платных медицинских услуг пуст");
            
        }

    }
}
