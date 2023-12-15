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


        private void textBox_SpacePress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == (int)Keys.Space)
                ch = '\0';
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

        private void buttRegistration_Click(object sender, EventArgs e)
        {
            string _name, _surname, _patronymic, _oldLogin, _oldPassword, _newLogin, _newPassword, _post;
            FullName _fullName;
            User _newUser;

            bool _isError = false;

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


            if (_surname == string.Empty)
            { 
                _isError = true;
                errorNoSurname.SetError(textSurname, "���� \"�������\" �� ���������"); 
            }

            if (_name == string.Empty)
            { 
                _isError = true;
                errorNoName.SetError(textName, "���� \"���\" �� ���������"); 
            }

            if (_oldLogin == string.Empty)
            {
                _isError = true;
                errorNoOldLog.SetError(textOldLog, "���� \"������ �����\" �� ���������");
            }


            if (_oldPassword == string.Empty)
            {
                _isError = true;
                errorNoOldPassword.SetError(textOldPassword, "���� \"������ ������\" �� ���������");
            }

            if (_newLogin == string.Empty)
            {
                _isError = true;
                errorNoNewLog.SetError(textNewLog, "���� \"����� �����\" �� ���������");
            }

            if (_newPassword == string.Empty)
            {
                _isError = true;
                errorNoNewPassword.SetError(textNewPassword, "���� \"����� ������\" �� ���������");
            }


            if (!_isError)
            {
                //����� � �������� ������������ �� ������� �������



                _fullName = new(_surname, _name, _patronymic);
                //_newUser = new(_fullName, _newLogin, _newPassword, _profession);




                MainWindowForm newForm = new MainWindowForm(this);
                if (newForm.ShowDialog() == DialogResult.OK)
                    Close();
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

        private void textNewPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
