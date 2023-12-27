using ARM_MedRegistrar.Data.Json.Dictionaries.AttachedStreets;
using ARM_MedRegistrar.Data.Json.Dictionaries;
using ARM_MedRegistrar.Model.AttachedStreets;
using ARM_MedRegistrar.View.AttachedToTheClinicStreets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_MedRegistrar.Model.AddressesOfBuilding;

namespace ARM_MedRegistrar.Presenter
{
    public class AttachedStreetsPresenter
    {
        IAttachedStreetsForm _view;
        IAttachedStreets _newAttachedStreet;
        IBaseRepositoryWithCreatedID<uint, IAttachedStreets> _jsonAttachedStreetsRepository; 
        IDictionary<uint, IAttachedStreets>? _attachedStreets;
        public AttachedStreetsPresenter(IAttachedStreetsForm view) 
        {
            _view = view;
            _jsonAttachedStreetsRepository = new JsonAttachedStreetsRepository();
            
        }

        public void AddAttStreets()
        {
            _newAttachedStreet = new AttachedStreets(new AddressOfBuilding( _view.City, _view.Region, _view.Street ,_view.NumbOfHouse), _jsonAttachedStreetsRepository.CreateID());
            _jsonAttachedStreetsRepository.Create(_newAttachedStreet);
        }


        public bool DeleteAttStreets()
        {
            _attachedStreets = _jsonAttachedStreetsRepository.Read();
            if (_attachedStreets == null || _attachedStreets.Count == 0)
                return false;

            if (_attachedStreets != null && _attachedStreets.Count != 0)
            {
                foreach(uint key in  _attachedStreets.Keys) 
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

        public void AllAttStreets()
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
