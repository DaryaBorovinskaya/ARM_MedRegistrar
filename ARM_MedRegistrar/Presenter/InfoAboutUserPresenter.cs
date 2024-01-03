using ARM_MedRegistrar.View.InfoAboutUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Presenter
{
    public class InfoAboutUserPresenter
    {
        IInfoAboutUserForm _view;
        private void ShowData() 
        {

        }
        public InfoAboutUserPresenter(IInfoAboutUserForm view)
        {
            _view = view;
            ShowData();
        }

        
    }
}
