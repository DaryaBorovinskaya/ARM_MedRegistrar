
using ARM_MedRegistrar.View.AttachedToTheClinicStreets;
using ARM_MedRegistrar.Presenter.AttachedStreets;
using ARM_MedRegistrar.Model.AddressesOfBuilding;
using ARM_MedRegistrar.Model.AttachedStreets;

namespace ARM_MedRegistrar.Presenter
{
    public class AttachedStreetsPresenter : IAttachedStreetsPresenter
    {
        IAttachedStreetsForm _view;
        IAttachedStreets _attachedStreets;
        string result;
        string IAttachedStreetsPresenter.AllAttStreets { set => _view.AllAttStreets = value; }

        public AttachedStreetsPresenter(IAttachedStreetsForm view)
        {
            _view = view;
            _attachedStreets = new Model.AttachedStreets.AttachedStreets(this);
        }


        public string CheckAccessLevel()
        {
            try
            {
                result = Model.AttachedStreets.AttachedStreets.CheckAccessLevel();
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
        }



        public string AddAttStreets()
        {
            try
            {
                result = Model.AttachedStreets.AttachedStreets.AddAttStreets(_view.City, _view.Region, _view.Street, _view.NumbOfHouse);
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
        }


        public string DeleteAttStreets()
        {
            try
            {
                result = Model.AttachedStreets.AttachedStreets.DeleteAttStreets(_view.City, _view.Region, _view.Street, _view.NumbOfHouse);
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
        }

        public string AllAttStreets()
        {
            try
            {
                result = Model.AttachedStreets.AttachedStreets.AllAttStreets();
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
        }


        public string SuccessAdd()
        {
            return Model.AttachedStreets.AttachedStreets.SuccessAdd();
        }

        public string SuccessRemove()
        {
            return Model.AttachedStreets.AttachedStreets.SuccessRemove();
        }

        public string FailureRemove()
        {
            return Model.AttachedStreets.AttachedStreets.FailureRemove();
        }
    }
}
