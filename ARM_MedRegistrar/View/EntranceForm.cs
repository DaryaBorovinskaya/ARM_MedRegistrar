using ARM_MedRegistrar.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARM_MedRegistrar.Presenter;


namespace ARM_MedRegistrar
{
    public partial class EntranceForm : Form , IEntranceForm
    {
        private EntrancePresenter presenter;
        public string Login => throw new NotImplementedException();

        public string Password => throw new NotImplementedException();

        public EntranceForm()
        {
            InitializeComponent();

            presenter = new();
        }



        private void buttEntrance_Click(object sender, EventArgs e)
        {
            string _login, _password;

            errorNoLog.Clear();
            errorNoPassword.Clear();
            _login = textLog.Text;
            _password = textPassword.Text;

            if (_login != string.Empty && _password != string.Empty)
            {

                MainWindowForm newForm = new MainWindowForm(this);
                if (newForm.ShowDialog() == DialogResult.OK) Close();

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
