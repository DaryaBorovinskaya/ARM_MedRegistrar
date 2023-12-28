using ARM_MedRegistrar.Presenter;
using ARM_MedRegistrar.View.LogIn;

namespace ARM_MedRegistrar
{
    public partial class LogInForm : Form, ILogInForm
    {
        string result;
        private LogInPresenter _presenter;
        string ILogInForm.Login => textLog.Text;

        string ILogInForm.Password => textPassword.Text;

        public LogInForm()
        {
            InitializeComponent();
            _presenter = new(this);
        }


        private void buttLogIn_Click(object sender, EventArgs e)
        {

            errorNoLog.Clear();
            errorNoPassword.Clear();

            bool _isError = false;

            if (textLog.Text == string.Empty)
            {
                _isError = true;
                errorNoLog.SetError(textLog, "Поле не заполнено");
            }


            if (textPassword.Text == string.Empty)
            {
                _isError = true;
                errorNoPassword.SetError(textPassword, "Поле не заполнено");
            }

            if (!_isError)
            {
                result = _presenter.IsSuccessLogIn();
                if (result == string.Empty)
                {
                    MainWindowForm newForm = new(this);
                    newForm.ShowDialog();
                }
                else
                    labelWrongLogOrPassword.Visible = true;

            }

        }


        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new(this);
            registrationForm.ShowDialog();
        }

        private void checkViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkViewPassword.Checked)
                textPassword.UseSystemPasswordChar = false;

            else
                textPassword.UseSystemPasswordChar = true;
        }


    }
}
