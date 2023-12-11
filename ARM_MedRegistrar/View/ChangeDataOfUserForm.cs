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
    public partial class ChangeDataOfUserForm : Form
    {
        Form form;


        public ChangeDataOfUserForm(Form form)
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


        private void textOldLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void textOldPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void textNewLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void textNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        //private void ChangeDataOfUser_Load(object sender, EventArgs e)
        //{

        //}
        //private void ChangeDataOfUser_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    e.Cancel = true;
        //}



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

        private void buttRegistration_Click(object sender, EventArgs e)
        {
            string _name, _surname, _patronymic, _oldLogin, _oldPassword, _newLogin, _newPassword, _post;
            FullName _fullName;
            User _newUser;



            errorNoPost.Clear();
            errorNoSurname.Clear();
            errorNoName.Clear();
            errorNoOldLog.Clear();
            errorNoOldPassword.Clear();
            errorNoNewLog.Clear();
            errorNoNewPassword.Clear();

            _surname = textSurname.Text;
            _name = textName.Text;
            _patronymic = textPatr.Text;
            _oldLogin = textOldLog.Text;
            _oldPassword = textOldPassword.Text;
            _newLogin = textNewLog.Text;
            _newPassword = textNewPassword.Text;

            if (_surname != string.Empty && _name != string.Empty && _oldLogin != string.Empty
                && _oldPassword != string.Empty && _newLogin != string.Empty && _newPassword != string.Empty)
            {
                //поиск и удаление пользователя со старыми данными



                _fullName = new(_surname, _name, _patronymic);
                //_newUser = new(_fullName, _newLogin, _newPassword, _profession);




                MainWindowForm newForm = new MainWindowForm(this);
                if (newForm.ShowDialog() == DialogResult.OK)
                    Close();
            }

            else
            {


                if (_surname == string.Empty)
                    errorNoSurname.SetError(textSurname, "Поле \"Фамилия\" не заполнено");

                if (_name == string.Empty)
                    errorNoName.SetError(textName, "Поле \"Имя\" не заполнено");

                if (_oldLogin == string.Empty)
                    errorNoOldLog.SetError(textOldLog, "Поле \"Старый логин\" не заполнено");


                if (_oldPassword == string.Empty)
                    errorNoOldPassword.SetError(textOldPassword, "Поле \"Старый пароль\" не заполнено");

                if (_newLogin == string.Empty)
                    errorNoNewLog.SetError(textNewLog, "Поле \"Новый логин\" не заполнено");

                if (_newPassword == string.Empty)
                    errorNoNewPassword.SetError(textNewPassword, "Поле \"Новый пароль\" не заполнено");
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
    }
}
