using ARM_MedRegistrar.Model.Persons;

namespace ARM_MedRegistrar.View
{
    public partial class InfoAboutUserForm : Form
    {
        IUserEmployee _employee;
        public InfoAboutUserForm(IUserEmployee employee)
        {
            InitializeComponent();
            _employee = employee;

            textSurname.Text = _employee.PersonalData.FullName.Surname;
            textName.Text = _employee.PersonalData.FullName.Name;
            textPatr.Text = _employee.PersonalData.FullName.Patronymic;
            textPost.Text = _employee.Post;
            textPhoneNumber.Text = _employee.PersonalData.PhoneNumber;
        }

        private void textSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
