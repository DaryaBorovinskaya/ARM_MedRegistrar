using ARM_MedRegistrar.Presenter;
using ARM_MedRegistrar.View.InfoAboutUser;

namespace ARM_MedRegistrar.View
{
    public partial class InfoAboutUserForm : Form, IInfoAboutUserForm
    {
        InfoAboutUserPresenter _presenter;
        string IInfoAboutUserForm.Surname { set => textSurname.Text = value; }
        string IInfoAboutUserForm.Name { set => textName.Text = value; }
        string IInfoAboutUserForm.Patronymic { set => textPatr.Text = value; }
        string IInfoAboutUserForm.PhoneNumber { set => textPhoneNumber.Text = value; }
        string IInfoAboutUserForm.Post { set => textPost.Text = value; }

        public InfoAboutUserForm()
        {
            InitializeComponent();
            _presenter = new(this);
        }

    }
}
