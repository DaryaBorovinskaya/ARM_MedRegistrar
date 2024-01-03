using ARM_MedRegistrar.View.AttachedToTheClinicStreets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Presenter
{
    public class AttachedStreetsPresenter
    {
        IAttachedStreetsForm _view;
        public AttachedStreetsPresenter(IAttachedStreetsForm view) 
        {
            _view = view;
        }



    }
}
