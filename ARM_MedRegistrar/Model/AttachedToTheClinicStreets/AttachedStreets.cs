
using ARM_MedRegistrar.Data.Json.Dictionaries;
using ARM_MedRegistrar.Data.Json.Dictionaries.AttachedStreets;
using ARM_MedRegistrar.Data.Json.Dictionaries.UserRepository;
using ARM_MedRegistrar.Model.AddressesOfBuilding;
using ARM_MedRegistrar.Presenter.AttachedStreets;
using Newtonsoft.Json;
using ARM_MedRegistrar.Model.Persons.Users;


namespace ARM_MedRegistrar.Model.AttachedStreets
{
    public class AttachedStreets : IAttachedStreets
    {
        static IAttachedStreetsPresenter _presenter;
        public IAddressOfBuilding AddressOfBuilding { get; set; }
        public uint Id { get; }

        public AttachedStreets(IAttachedStreetsPresenter presenter)
        {
            _presenter = presenter;
        }


        [JsonConstructor]
        public AttachedStreets(IAddressOfBuilding addressOfBuilding, uint id) 
        {
            AddressOfBuilding = addressOfBuilding;
            Id = id;
        }

        public string Format()
        {
            return AddressOfBuilding.Format();
        }


        public static string AddAttStreets(string city, string region, string street, int numbOfHouse)
        {
            IAttachedStreets _newAttachedStreet;
            IBaseRepositoryWithCreatedID<uint, IAttachedStreets> _jsonAttachedStreetsRepository = new JsonAttachedStreetsRepository();
            IDictionary<uint, IAttachedStreets>? _attachedStreets;
            try 
            { 
                _newAttachedStreet = new AttachedStreets(new AddressOfBuilding(city, region, street, numbOfHouse), _jsonAttachedStreetsRepository.CreateID());
                _jsonAttachedStreetsRepository.Create(_newAttachedStreet);
            }
            catch (ArgumentException e)
            {
                return e.Message;
            }
            return string.Empty;
        }
        public static string DeleteAttStreets(string city, string region, string street, int numbOfHouse)
        {
            IAttachedStreets _newAttachedStreet;
            IBaseRepositoryWithCreatedID<uint, IAttachedStreets> _jsonAttachedStreetsRepository = new JsonAttachedStreetsRepository();
            IDictionary<uint, IAttachedStreets>? _attachedStreets;
            _attachedStreets = _jsonAttachedStreetsRepository.Read();
            if (_attachedStreets == null || _attachedStreets.Count == 0)
                throw new ArgumentException("Список прикреплённых улиц пуст");

            if (_attachedStreets != null && _attachedStreets.Count != 0)
            {
                foreach (uint key in _attachedStreets.Keys)
                {
                    if (_attachedStreets[key].AddressOfBuilding.City == city && _attachedStreets[key].AddressOfBuilding.Region == region
                        && _attachedStreets[key].AddressOfBuilding.Street == street && _attachedStreets[key].AddressOfBuilding.NumbOfHouse == numbOfHouse)
                    {
                        _jsonAttachedStreetsRepository.Delete(_attachedStreets[key].Id);
                        return string.Empty;
                    }
                }
            }
            throw new ArgumentException("Не удалось вывести список улиц");
        }

        public static string AllAttStreets()
        {
            IAttachedStreets _newAttachedStreet;
            IBaseRepositoryWithCreatedID<uint, IAttachedStreets> _jsonAttachedStreetsRepository = new JsonAttachedStreetsRepository();
            IDictionary<uint, IAttachedStreets>? _attachedStreets;
            string _result = string.Empty;

            _attachedStreets = _jsonAttachedStreetsRepository.Read();
            if (_attachedStreets == null || _attachedStreets.Count == 0)
                throw new ArgumentException("Список прикреплённых улиц пуст");

            if (_attachedStreets != null && _attachedStreets.Count != 0)
            {
                foreach (uint key in _attachedStreets.Keys)
                    _result += _attachedStreets[key].AddressOfBuilding.FormatOneLine() + "\n";

                _presenter.AllAttStreets = _result;
                return string.Empty;
            }
            throw new ArgumentException("Не удалось вывести список улиц");
        }



        public static string SuccessAdd()
        {
            return "Успешно добавлено";
        }

        public static string SuccessRemove()
        {
            return "Удаление выполнено успешно";
        }
        public static string FailureRemove()
        {
            return "Не удалось удалить";
        }


        public static string CheckAccessLevel()
        {
            JsonCurrentUserRepository _jsonCurrentUserRepository = new();
            User? _user = _jsonCurrentUserRepository.Read();
            if (_user == null)
                throw new ArgumentException("Нулевое значение пользователя");

            if (_user.Post == User.SetPost()[1])
                return string.Empty;
            throw new ArgumentException("Ошибка: данная функция Вам недоступна");
        }




    }
}
