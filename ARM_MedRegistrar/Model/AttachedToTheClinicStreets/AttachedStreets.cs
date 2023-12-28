
using ARM_MedRegistrar.Data.Json.Dictionaries.AttachedStreets;
using ARM_MedRegistrar.Model.AddressesOfBuilding;
using ARM_MedRegistrar.Presenter.AttachedStreets;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ARM_MedRegistrar.Model.AttachedStreets
{
    public class AttachedStreets : IAttachedStreets
    {
        IAttachedStreetsPresenter _presenter;
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


        public static string AddAttStreets()
        {
            _newAttachedStreet = new AttachedStreets(new AddressOfBuilding(_view.City, _view.Region, _view.Street, _view.NumbOfHouse), _jsonAttachedStreetsRepository.CreateID());
            _jsonAttachedStreetsRepository.Create(_newAttachedStreet);
        }
        public static string DeleteAttStreets()
        {
            _attachedStreets = _jsonAttachedStreetsRepository.Read();
            if (_attachedStreets == null || _attachedStreets.Count == 0)
                return false;

            if (_attachedStreets != null && _attachedStreets.Count != 0)
            {
                foreach (uint key in _attachedStreets.Keys)
                {
                    if (_attachedStreets[key].AddressOfBuilding.City == _view.City && _attachedStreets[key].AddressOfBuilding.Region == _view.Region
                        && _attachedStreets[key].AddressOfBuilding.Street == _view.Street && _attachedStreets[key].AddressOfBuilding.NumbOfHouse == _view.NumbOfHouse)
                    {
                        _jsonAttachedStreetsRepository.Delete(_attachedStreets[key].Id);
                        return true;
                    }
                }
            }
            return false;
        }

        public static string AllAttStreets()
        {
            string _result = string.Empty;
            _attachedStreets = _jsonAttachedStreetsRepository.Read();
            if (_attachedStreets == null || _attachedStreets.Count == 0)
                return;

            if (_attachedStreets != null && _attachedStreets.Count != 0)
            {
                foreach (uint key in _attachedStreets.Keys)
                    _result += _attachedStreets[key].AddressOfBuilding.FormatOneLine() + "\n";

                _view.AllAttStreets = _result;
            }
        }
    }
}
