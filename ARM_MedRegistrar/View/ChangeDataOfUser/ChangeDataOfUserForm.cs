

namespace ARM_MedRegistrar
{
    public partial class ChangeDataOfUserForm : Form
    {
        Form _form;


        public ChangeDataOfUserForm(Form form)
        {
            _form = form;
            _form.Hide();
            InitializeComponent();
            //DialogResult = DialogResult.Cancel;
            FormClosed += OnClosed;
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




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttHeadRegistr_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttChangeData_Click(object sender, EventArgs e)
        {
            ////string _name, _surname, _patronymic, _oldLogin, _oldPassword, _newLogin, _newPassword, _post;
            ////IFullName _fullName;
            ////IUser _newUser;

            ////bool _isError = false;

            ////errorNoPost.Clear();
            ////errorNoSurname.Clear();
            ////errorNoName.Clear();
            ////errorNoOldLog.Clear();
            ////errorNoOldPassword.Clear();
            ////errorNoNewLog.Clear();
            ////errorNoNewPassword.Clear();

            ////_surname = textSurname.Text;
            ////_name = textName.Text;
            ////_patronymic = textPatr.Text;
            ////_oldLogin = textOldLog.Text;
            ////_oldPassword = textOldPassword.Text;
            ////_newLogin = textNewLog.Text;
            ////_newPassword = textNewPassword.Text;


            ////if (_surname == string.Empty)
            ////{
            ////    _isError = true;
            ////    errorNoSurname.SetError(textSurname, "Поле \"Фамилия\" не заполнено");
            ////}

            ////if (_name == string.Empty)
            ////{
            ////    _isError = true;
            ////    errorNoName.SetError(textName, "Поле \"Имя\" не заполнено");
            ////}

            ////if (_oldLogin == string.Empty)
            ////{
            ////    _isError = true;
            ////    errorNoOldLog.SetError(textOldLog, "Поле \"Старый логин\" не заполнено");
            ////}


            ////if (_oldPassword == string.Empty)
            ////{
            ////    _isError = true;
            ////    errorNoOldPassword.SetError(textOldPassword, "Поле \"Старый пароль\" не заполнено");
            ////}

            ////if (_newLogin == string.Empty)
            ////{
            ////    _isError = true;
            ////    errorNoNewLog.SetError(textNewLog, "Поле \"Новый логин\" не заполнено");
            ////}

            ////if (_newPassword == string.Empty)
            ////{
            ////    _isError = true;
            ////    errorNoNewPassword.SetError(textNewPassword, "Поле \"Новый пароль\" не заполнено");
            ////}


            ////if (!_isError)
            ////{
            ////    //поиск и удаление пользователя со старыми данными



            ////    _fullName = new FullName(_surname, _name, _patronymic);
            ////    _newUser = new User(_fullName, _newLogin, _newPassword, comboBoxPost.SelectedItem.ToString(),  );




            ////    MainWindowForm newForm = new MainWindowForm(this, );
            ////    if (newForm.ShowDialog() == DialogResult.OK)
            ////        Close();
            ////}


        }

        private void comboProfess_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelLog_Click(object sender, EventArgs e)
        {

        }



        private void checkViewNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkViewNewPassword.Checked)
                textNewPassword.UseSystemPasswordChar = false;

            else
                textNewPassword.UseSystemPasswordChar = true;
        }

        private void checkViewOldPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkViewOldPassword.Checked)
                textOldPassword.UseSystemPasswordChar = false;

            else
                textOldPassword.UseSystemPasswordChar = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void textOldPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNewPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
