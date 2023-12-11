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
using ARM_MedRegistrar.Model.Json.JsonRepository;

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


            comboBoxPost.Items.AddRange(new string[] { "медицинский регистратор", "заведующий регистратурой", "главный врач" });
        }

        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
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
        private void textSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }
        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }
        private void textPatr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
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
            string _name, _surname, _patronymic, _login, _password, _post;
            FullName _fullName;
            User _newUser;
            bool IsSuccess = true;
            JsonUserRepository jsonUserRepository = new("users.json");
            IList<IUser>? _users = jsonUserRepository.GetAll();

            errorNoSurname.Clear();
            errorNoName.Clear();
            errorNoLog.Clear();
            errorNoPassword.Clear();
            errorNoPost.Clear();
            errorMatchedLog.Clear();
            errorMatchedPassword.Clear();
            errorNoOneHeadDoctor.Clear();

            _surname = textSurname.Text;
            _name = textName.Text;
            _patronymic = textPatr.Text;
            _login = textLog.Text;
            _password = textPassword.Text;

            if (_surname != string.Empty && _name != string.Empty && _login != string.Empty
            && _password != string.Empty && comboBoxPost.SelectedIndex != -1)
            {
                _post = comboBoxPost.SelectedItem.ToString();
                if (_users != null)
                {
                    for (int index = 0; index < _users.Count; index++)
                    {
                        if (_users[index].Post == "главный врач" && _post == "главный врач")
                        {
                            errorNoOneHeadDoctor.SetError(comboBoxPost, "Пользователь с должностью \"главный врач\" уже есть");
                            IsSuccess = false;
                            break;
                        }

                        if (_users[index].Login == _login)
                        {
                            errorMatchedLog.SetError(textLog, "Такой логин уже используется");
                            IsSuccess = false;
                            break;
                        }

                        if (_users[index].Password == _password)
                        {
                            errorMatchedPassword.SetError(textPassword, "Такой пароль уже используется");
                            IsSuccess = false;
                            break;
                        }
                    }
                }

                if (IsSuccess)
                {
                    _fullName = new(_surname, _name, _patronymic);
                    _newUser = new(_fullName, _login, _password, _post);
                    jsonUserRepository.Add(_newUser);

                    MessageBox.Show($"Вы успешно зарегистрированы (должность {_post})");
                    MainWindowForm newForm = new MainWindowForm(this);
                    if (newForm.ShowDialog() == DialogResult.OK)
                        Close();
                }
            }

            else
            {
                if (comboBoxPost.SelectedIndex == -1)
                    errorNoPost.SetError(comboBoxPost, "Поле \"Должность\" не заполнено");

                if (_surname == String.Empty)
                    errorNoSurname.SetError(textSurname, "Поле \"Фамилия\" не заполнено");

                if (_name == String.Empty)
                    errorNoName.SetError(textName, "Поле \"Имя\" не заполнено");

                if (_login == String.Empty)
                    errorNoLog.SetError(textLog, "Поле \"Логин\" не заполнено");


                if (_password == String.Empty)
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
