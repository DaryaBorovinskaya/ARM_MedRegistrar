using ARM_MedRegistrar.Presenter;
using ARM_MedRegistrar.Model.Json.UserRepository;
using System.Windows.Forms;
using ARM_MedRegistrar.View.LogIn;
using ARM_MedRegistrar.Model.Users;

namespace ARM_MedRegistrar
{
    public partial class LogInForm : Form, ILogInForm
    {
        private LogInPresenter _presenter;
        string ILogInForm.Login => textLog.Text;

        string ILogInForm.Password => textLog.Text;

        public LogInForm()
        {
            InitializeComponent();

            _presenter = new(this);

        }

        private void textBox_SpacePress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == (int)Keys.Space)
                ch = '\0';
        }

        private void textBox_ContainsExceptNumbers(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)     //(8 - это Backspace)
                ch = '\0';

        }
        private void buttEntrance_Click(object sender, EventArgs e)
        {
            IUser? _newUser;
            errorNoLog.Clear();
            errorNoPassword.Clear();

            bool _isError = false;

            

            if (textLog.Text == string.Empty)
            { 
                _isError = true;
                errorNoLog.SetError(textLog, "Поле \"Логин\" не заполнено"); 
            }


            if (textPassword.Text == string.Empty)
            {
                _isError = true;
                errorNoPassword.SetError(textPassword, "Поле \"Пароль\" не заполнено"); 
            }

            if (!_isError)
            {
                _newUser = _presenter.LogIn();
                if ( _newUser!= null)
                {
                    MainWindowForm newForm = new(this, _newUser);
                    if (newForm.ShowDialog() == DialogResult.OK)
                        Close();
                }

                else
                    labelWrongLogOrPassword.Visible = true;

            }

        }


        private void buttonRegistration_Click(object sender, EventArgs e)
        {

            RegistrationForm newForm = new RegistrationForm(this);
            if (newForm.ShowDialog() == DialogResult.OK) Close();
        }



        private void checkViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkViewPassword.Checked)
                textPassword.UseSystemPasswordChar = false;

            else
                textPassword.UseSystemPasswordChar = true;
        }

        private void buttChangeDataOfUser_Click(object sender, EventArgs e)
        {
            ChangeDataOfUserForm newForm = new ChangeDataOfUserForm(this);
            if (newForm.ShowDialog() == DialogResult.OK) Close();
        }
    }
}
