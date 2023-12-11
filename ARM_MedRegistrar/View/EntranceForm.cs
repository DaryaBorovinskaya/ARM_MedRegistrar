using ARM_MedRegistrar.View;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Presenter;
using ARM_MedRegistrar.Model.Json.JsonRepository;


namespace ARM_MedRegistrar
{
    public partial class EntranceForm : Form, IEntranceForm
    {
        private EntrancePresenter presenter;
        public string Login => throw new NotImplementedException();

        public string Password => throw new NotImplementedException();

        public EntranceForm()
        {
            InitializeComponent();

            presenter = new();
        }

        private void textLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void buttEntrance_Click(object sender, EventArgs e)
        {
            string _login, _password;
            JsonUserRepository jsonUserRepository = new("users.json");
            IList<IUser>? _users = jsonUserRepository.GetAll();

            errorNoLog.Clear();
            errorNoPassword.Clear();


            _login = textLog.Text;
            _password = textPassword.Text;

            if (_login != string.Empty && _password != string.Empty)
            {
                if (_users != null)
                {
                    for (int index = 0; index < _users.Count; index++)
                    {
                        if (_users[index].Login == _login && _users[index].Password == _password)
                        {
                            MainWindowForm newForm = new(this);
                            if (newForm.ShowDialog() == DialogResult.OK)
                                Close();
                            break;
                        }
                    }

                    labelWrongLogOrPassword.Visible = true;
                }
                else
                {
                    MessageBox.Show("Пожалуйста, пройдите регистрацию");
                    RegistrationForm newForm = new RegistrationForm(this);
                    if (newForm.ShowDialog() == DialogResult.OK) Close();
                }


            }

            else
            {
                if (_login == string.Empty)
                    errorNoLog.SetError(textLog, "Поле \"Логин\" не заполнено");


                if (_password == string.Empty)

                    errorNoPassword.SetError(textPassword, "Поле \"Пароль\" не заполнено");
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
