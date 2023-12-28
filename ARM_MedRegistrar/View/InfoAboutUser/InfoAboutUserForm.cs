using ARM_MedRegistrar.Presenter.InfoAboutUserPresenter;
using ARM_MedRegistrar.View.InfoAboutUser;

namespace ARM_MedRegistrar.View
{
    public partial class InfoAboutUserForm : Form, IInfoAboutUserForm
    {
        InfoAboutUserPresenter _presenter;
        string result;
        string IInfoAboutUserForm.Surname { set => textSurname.Text = value; }
        string IInfoAboutUserForm.Name { set => textName.Text = value; }
        string IInfoAboutUserForm.Patronymic { set => textPatr.Text = value; }
        string IInfoAboutUserForm.PhoneNumber { set => textPhoneNumber.Text = value; }
        string IInfoAboutUserForm.Post { set => textPost.Text = value; }

        public InfoAboutUserForm()
        {
            InitializeComponent();
            _presenter = new(this);
            result = _presenter.ShowData();
            if (result != string.Empty)
                MessageBox.Show(result);
            result = _presenter.CheckAccessLevel();
            if (result != string.Empty)
            { 
                buttChangeDataOfUser.Visible = false;
            }
        }

        private void buttChangeDataOfUser_Click(object sender, EventArgs e)
        {
            result = _presenter.CheckAccessLevel();
            if (result == string.Empty)
            {
                ChangeDataOfUserForm changeDataOfUserForm = new(this);
                changeDataOfUserForm.ShowDialog();
            }
            else
                MessageBox.Show(result);
        }
    }
}
