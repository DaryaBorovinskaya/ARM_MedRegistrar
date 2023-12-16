using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Model.Json.UserRepository;
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

        string IRegistrationForm.Patronymic => textPatr.Text;

        string IRegistrationForm.Login => textLog.Text;

        string IRegistrationForm.Password => textPassword.Text;

        string IRegistrationForm.Post => comboBoxPost.SelectedItem.ToString();

        string IRegistrationForm.PhoneNumber => textPhoneNumber.Text;

        string IRegistrationForm.TIN => textTIN.Text;

        public RegistrationForm(Form form)
        {
            _form = form;
            _form.Hide();
            InitializeComponent();
            //DialogResult = DialogResult.Cancel;
            FormClosed += OnClosed;


            comboBoxPost.Items.AddRange(new string[] { "медицинский регистратор", "заведующий регистратурой", "главный врач" });

            _presenter = new(this);

            _presenter.NoOneHeadDoctorEvent += NoOneHeadDoctorSet;
            _presenter.MatchedLogEvent += MatchedLogSet;

        }


        private void MatchedLogSet(object? sender, EventArgs e)
        {
            errorMatchedLog.SetError(textLog, "Такой логин уже используется");

        }

        private void NoOneHeadDoctorSet(object? sender, EventArgs e)
        {
            errorNoOneHeadDoctor.SetError(comboBoxPost, "Пользователь с должностью \"главный врач\" уже есть");

        }

        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            _form.Visible = true;
            //DialogResult = DialogResult.OK;
        }

        private void textBox_SpacePress(object sender, KeyPressEventArgs e)
        {
            //char ch = e.KeyChar;

            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }
        private void textBox_ContainsExceptNumbers(object sender, KeyPressEventArgs e)
        {
            //char ch = e.KeyChar;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)     //(8 - это Backspace)
                e.KeyChar = '\0';

        }
        private void buttRegistration_Click(object sender, EventArgs e)
        {


            errorNoSurname.Clear();
            errorNoName.Clear();
            errorNoLog.Clear();
            errorNoPassword.Clear();
            errorNoPost.Clear();
            errorMatchedLog.Clear();
            errorMatchedPassword.Clear();
            errorNoOneHeadDoctor.Clear();
            errorNoPhoneNumber.Clear();


            bool _isError = false;


            if (comboBoxPost.SelectedIndex == -1)
            {
                _isError = true;
                errorNoPost.SetError(comboBoxPost, "Поле \"Должность\" не заполнено");
            }

            if (textSurname.Text == string.Empty)
            {
                _isError = true;
                errorNoSurname.SetError(textSurname, "Поле \"Фамилия\" не заполнено");
            }

            if (textName.Text == string.Empty)
            {
                _isError = true;
                errorNoName.SetError(textName, "Поле \"Имя\" не заполнено");
            }

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

            if (textPhoneNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoPhoneNumber.SetError(textPhoneNumber, "Поле \"Номер телефона\" не заполнено");
            }




            if (!_isError)
            {
                if (_presenter.IsSuccessRegistration())
                {
                    MessageBox.Show($"Вы успешно зарегистрированы (должность {comboBoxPost.SelectedItem})");

                    Close();
                }
            }
        }

        private void checkViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkViewPassword.Checked)
                textPassword.UseSystemPasswordChar = false;

            else
                textPassword.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
