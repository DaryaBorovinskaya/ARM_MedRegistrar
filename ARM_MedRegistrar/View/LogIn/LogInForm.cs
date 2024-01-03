using ARM_MedRegistrar.Presenter;
using ARM_MedRegistrar.View.LogIn;

namespace ARM_MedRegistrar
{
    public partial class LogInForm : Form, ILogInForm
    {
        private LogInPresenter _presenter;
        string ILogInForm.Login => textLog.Text;

        string ILogInForm.Password => textPassword.Text;

        public LogInForm()
        {

            InitializeComponent();

            _presenter = new(this);

        }

        private void TextBox_SpacePress(object sender, KeyPressEventArgs e)
        {
            //char ch = e.KeyChar;

            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
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

                if (_presenter.LogIn() != null)
                {
                    MainWindowForm newForm = new(this);  
                    newForm.ShowDialog();
                    //if (newForm.ShowDialog() == DialogResult.OK)
                    //    Close();

                }
                else
                    labelWrongLogOrPassword.Visible = true;

            }

        }


        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new(this);
            registrationForm.ShowDialog();
            //if (newForm.ShowDialog() == DialogResult.OK) Close();
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
            ChangeDataOfUserForm changeDataOfUserForm = new(this);
            changeDataOfUserForm.ShowDialog();
            //if (newForm.ShowDialog() == DialogResult.OK) Close();
        }
    }
}
