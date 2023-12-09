using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Model.Lists;

namespace ARM_MedRegistrar
{
    public partial class RegistrationForm : Form
    {
        Form form;


        public RegistrationForm(Form form)
        {
            this.form = form;
            form.Hide();
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            FormClosed += OnClosed;
        }

        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }


        //private void Registration_Load(object sender, EventArgs e)
        //{

        //}
        //private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    e.Cancel = true;
        //}



        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void buttHeadRegistr_Click(object sender, EventArgs e)
        //{

        //}

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void textSurname_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void buttRegistration_Click(object sender, EventArgs e)
        {
            string _name, _surname, _patronymic, _oldLogin, _oldPassword;
            FullName _fullName;
            User _newUser;
            GroupOfUsers _groupOfUsers;
            Profession _profession;

            errorNoChoice.Clear();
            errorNoSurname.Clear();
            errorNoName.Clear();
            errorNoLog.Clear();
            errorNoPassword.Clear();

            _surname = textSurname.Text;
            _name = textName.Text;
            _patronymic = textPatr.Text;
            _oldLogin = textLog.Text;
            _oldPassword = textPassword.Text;


            if (_surname != string.Empty && _name != string.Empty && _oldLogin != string.Empty
                && _oldPassword != string.Empty)
            {

                if (!checkHeadReg.Checked)
                {
                    _profession = Profession.MedRegistrar;
                    MessageBox.Show("Вы успешно зарегистрированы\nкак медицинский регистратор");

                }
                else
                {
                    _profession = Profession.HeadOfRegistry;
                    MessageBox.Show("Вы успешно зарегистрированы\nкак заведующий регистратурой");
                }

                _fullName = new(_surname, _name, _patronymic);
                _newUser = new(_fullName, _oldLogin, _oldPassword, _profession);
                _groupOfUsers = new();
                _groupOfUsers.AddUser(_newUser);



                MainWindowForm newForm = new MainWindowForm(this);
                if (newForm.ShowDialog() == DialogResult.OK)
                    Close();
            }

            else
            {
                //if (!radioMedReg.Checked && !radioHeadReg.Checked)
                //    errorNoChoice.SetError(radioMedReg, "Не выбрана занимаемая дожность");

                if (_surname == String.Empty)
                    errorNoSurname.SetError(textSurname, "Поле \"Фамилия\" не заполнено");

                if (_name == String.Empty)
                    errorNoName.SetError(textName, "Поле \"Имя\" не заполнено");

                if (_oldLogin == String.Empty)
                    errorNoLog.SetError(textLog, "Поле \"Логин\" не заполнено");


                if (_oldPassword == String.Empty)

                    errorNoPassword.SetError(textPassword, "Поле \"Пароль\" не заполнено");

            }



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

        private void checkViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkViewPassword.Checked)
                textPassword.UseSystemPasswordChar = false;

            else
                textPassword.UseSystemPasswordChar = true;
        }
    }
}
