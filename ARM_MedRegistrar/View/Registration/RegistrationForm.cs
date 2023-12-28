using ARM_MedRegistrar.View.Registration;
using ARM_MedRegistrar.Presenter;

namespace ARM_MedRegistrar
{
    public partial class RegistrationForm : Form, IRegistrationForm
    {
        private Form _form;

        private RegistrationPresenter _presenter;
        string IRegistrationForm.Surname => textSurname.Text;

        string IRegistrationForm.Name => textName.Text;

        string? IRegistrationForm.Patronymic => textPatr.Text;

        string IRegistrationForm.Login => textLog.Text;

        string IRegistrationForm.Password => textPassword.Text;

        string IRegistrationForm.GetPost => comboBoxPost.SelectedItem.ToString();

        string IRegistrationForm.PhoneNumber => textPhoneNumber.Text;



        public RegistrationForm(Form form)
        {
            _form = form;
            _form.Hide();
            InitializeComponent();
            FormClosed += OnClosed;
            _presenter = new(this);
            comboBoxPost.Items.AddRange(_presenter.SetPost().ToArray());
        }


        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            _form.Visible = true;
        }

        private void buttRegistration_Click(object sender, EventArgs e)
        {
            errorNoSurname.Clear();
            errorNoName.Clear();
            errorNoLog.Clear();
            errorNoPassword.Clear();
            errorNoPost.Clear();
            errorMatchedLog.Clear();
            errorNoOneHeadOfRegistry.Clear();
            errorNoPhoneNumber.Clear();


            bool _isError = false;


            if (comboBoxPost.SelectedIndex == -1)
            {
                _isError = true;
                errorNoPost.SetError(comboBoxPost, "Поле не заполнено");
            }

            if (textSurname.Text == string.Empty)
            {
                _isError = true;
                errorNoSurname.SetError(textSurname, "Поле не заполнено");
            }

            if (textName.Text == string.Empty)
            {
                _isError = true;
                errorNoName.SetError(textName, "Поле не заполнено");
            }

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

            if (textPhoneNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoPhoneNumber.SetError(textPhoneNumber, "Поле не заполнено");
            }

            if (!_isError)
            {
                string result = _presenter.IsSuccessRegistration();
                if ( result == string.Empty)
                {
                    MessageBox.Show(_presenter.SuccessRegistration());
                    Close();
                }
                else
                    MessageBox.Show(result);
            }
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
