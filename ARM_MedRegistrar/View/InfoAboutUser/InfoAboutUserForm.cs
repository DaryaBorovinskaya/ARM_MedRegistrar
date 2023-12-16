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

            textSurname.Text = _employee.FullName.Surname;
            textName.Text = _employee.FullName.Name;
            textPatr.Text = _employee.FullName.Patronymic;
            textPost.Text = _employee.Post;
            textPhoneNumber.Text = _employee.PhoneNumber;
        }

        
    }
}
