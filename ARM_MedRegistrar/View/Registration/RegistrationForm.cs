﻿using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Model.Json.UserRepository;
using ARM_MedRegistrar.View.Registration;
using ARM_MedRegistrar.Presenter;

namespace ARM_MedRegistrar
{
    public partial class RegistrationForm : Form, IRegistrationForm
    {
        Form form;

        RegistrationPresenter _presenter;
        string IRegistrationForm.Surname => textSurname.Text;

        string IRegistrationForm.Name => textName.Text;

        string IRegistrationForm.Patronymic => textPatr.Text;

        string IRegistrationForm.Login => textLog.Text;

        string IRegistrationForm.Password => textPassword.Text;

        string IRegistrationForm.Post => comboBoxPost.SelectedItem.ToString();

        public RegistrationForm(Form form)
        {
            this.form = form;
            form.Hide();
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
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
            DialogResult = DialogResult.OK;
        }

        private void textBox_SpacePress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == (int)Keys.Space)
                ch = '\0';
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



            if (!_isError)
            {
                if (_presenter.IsSuccessRegistration())
                {
                    MessageBox.Show($"Вы успешно зарегистрированы (должность {comboBoxPost.SelectedItem})");
                    MainWindowForm newForm = new (this);
                    if (newForm.ShowDialog() == DialogResult.OK)
                        Close();
                }
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
