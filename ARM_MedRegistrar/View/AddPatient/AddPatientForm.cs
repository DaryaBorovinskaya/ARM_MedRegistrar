﻿using ARM_MedRegistrar.View.AddPatient;
using ARM_MedRegistrar.Presenter.AddPatient;

namespace ARM_MedRegistrar
{
    public partial class AddPatientForm : Form, IAddPatientForm
    {
        private AddPatientPresenter _presenter;
        string IAddPatientForm.Surname => textSurname.Text;

        string IAddPatientForm.Name => textName.Text;

        string? IAddPatientForm.Patronymic => textPatr.Text;

        DateOnly IAddPatientForm.DateOfBirth => DateOnly.FromDateTime(dateTimeDateOfBirth.Value);
        string IAddPatientForm.PhoneNumber => textPhoneNumber.Text;
        string? IAddPatientForm.City
        { 
            get => textCity.Text; 
            set => textCity.Text = value;
        }
        string? IAddPatientForm.Region
        {
            get => textRegion.Text;
            set => textRegion.Text = value;
        }
        string IAddPatientForm.Street => textStreet.Text;
        int IAddPatientForm.NumbOfHouse => int.Parse(textNumbOfHouse.Text);
        int IAddPatientForm.NumbOfFlat => int.Parse(textNumbOfFlat.Text);
        int IAddPatientForm.PlotNumber
        {
            get => int.Parse(textPlotNumber.Text);
            set
            {
                textPlotNumber.Text = value.ToString();
            }
        }
        string IAddPatientForm.NumbOfPatientCard => textNumbOfPatientCard.Text;
        int IAddPatientForm.PolicySeries => int.Parse(textPolicySeries.Text);
        string IAddPatientForm.PolicyNumb => textPolicyNumb.Text;
        string IAddPatientForm.DocumentSeries => textDocumentSeries.Text;
        string IAddPatientForm.DocumentNumber => textDocumentNumber.Text;
        string IAddPatientForm.BloodType => comboBoxBloodType.SelectedItem.ToString();
        string IAddPatientForm.RhFactor => comboBoxRhFactor.SelectedItem.ToString();
        string? IAddPatientForm.Allergies => textAllergies.Text;

        public AddPatientForm()
        {
            InitializeComponent();
            _presenter = new(this);
            comboBoxBloodType.Items.AddRange(_presenter.SetBloodType().ToArray());
            comboBoxRhFactor.Items.AddRange(_presenter.SetRhFactor().ToArray());
            _presenter.NoCityEvent += NoCitySet;
            _presenter.NoRegionEvent += NoRegionSet;
        }

        private void NoRegionSet(object? sender, EventArgs e)
        {
            errorNoRegion.SetError(textRegion, "Поле не заполнено");
        }

        private void NoCitySet(object? sender, EventArgs e)
        {
            errorNoCity.SetError(textCity, "Поле не заполнено");
        }

        private void textBox_SpacePress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void textBox_ContainsExceptNumbers(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)     //(8 - это Backspace)
                e.KeyChar = '\0';

        }

        private string textBoxWithoutNullInBeginning(TextBox textBox)
        {
            string _newTextOfTextBox = textBox.Text;
            int _length = _newTextOfTextBox.Length;
            if (_newTextOfTextBox[0] == '0')
            {
                if (_length == 1)
                    _newTextOfTextBox = "1";
                else
                    _newTextOfTextBox = _newTextOfTextBox.Remove(0, 1);
            }
            return _newTextOfTextBox;
        }
        private void numericNumbOfHouse_ValueChanged(object sender, EventArgs e)
        {
            numericNumbOfFlat.Minimum = 0;
            numericNumbOfFlat.Maximum = 5000;
        }

        private void numericNumbOfFlat_ValueChanged(object sender, EventArgs e)
        {

            numericNumbOfFlat.Maximum = 5000;
        }



        private void numericPolicySeries_ValueChanged(object sender, EventArgs e)
        {
            numeric.Maximum = 9999;
        }

        private void buttAddPatient_Click(object sender, EventArgs e)
        {
            bool _isError = false;

            errorNoSurname.Clear();
            errorNoName.Clear();
            errorNoPolicySeries.Clear();
            errorNoPolicyNumber.Clear();
            errorWrongDate.Clear();
            errorNoStreet.Clear();
            errorNoNumbOfHouse.Clear();
            errorNoNumbOfFlat.Clear();
            errorNoBloodType.Clear();
            errorNoRhFactor.Clear();
            errorNoNumbOfPatientCard.Clear();
            errorNoDocumentSeries.Clear();
            errorNoDocumentNumber.Clear();
            //errorNoCity.Clear();
            //errorNoRegion.Clear();
            errorNoPlotNumber.Clear();
            errorNoPhoneNumber.Clear();

            _presenter.SetDataFromAttStreets();

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

            if (textPolicySeries.Text == string.Empty)
            {
                _isError = true;
                errorNoPolicySeries.SetError(textPolicySeries, "Поле не заполнено");
            }

            if (textPolicyNumb.Text == string.Empty)
            {
                _isError = true;
                errorNoPolicyNumber.SetError(textPolicyNumb, "Поле не заполнено");
            }

            if (dateTimeDateOfBirth.Value.Day >= DateTime.Today.Day && dateTimeDateOfBirth.Value.Month >= DateTime.Today.Month
                && dateTimeDateOfBirth.Value.Year >= DateTime.Today.Year || dateTimeDateOfBirth.Value.Year > DateTime.Today.Year)
            {
                _isError = true;
                errorWrongDate.SetError(dateTimeDateOfBirth, "Поле заполнено неверно");
            }

            if (textStreet.Text == string.Empty)
            {
                _isError = true;
                errorNoStreet.SetError(textStreet, "Поле не заполнено");
            }

            if (textNumbOfHouse.Text == string.Empty)
            {
                _isError = true;
                errorNoNumbOfHouse.SetError(textNumbOfHouse, "Поле не заполнено");
            }

            if (textNumbOfFlat.Text == string.Empty)
            {
                _isError = true;
                errorNoNumbOfFlat.SetError(textNumbOfFlat, "Поле не заполнено");
            }

            if (comboBoxBloodType.SelectedIndex == -1)
            {
                _isError = true;
                errorNoBloodType.SetError(comboBoxBloodType, "Поле не заполнено");
            }

            if (comboBoxRhFactor.SelectedIndex == -1)
            {
                _isError = true;
                errorNoRhFactor.SetError(comboBoxRhFactor, "Поле не заполнено");
            }

            if (textNumbOfPatientCard.Text == string.Empty)
            {
                _isError = true;
                errorNoNumbOfPatientCard.SetError(textNumbOfPatientCard, "Поле не заполнено");
            }

            if (textDocumentSeries.Text == string.Empty)
            {
                _isError = true;
                errorNoDocumentSeries.SetError(textDocumentSeries, "Поле не заполнено");
            }

            if (textDocumentNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoDocumentNumber.SetError(textDocumentNumber, "Поле не заполнено");
            }
            if (textPlotNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoPlotNumber.SetError(textPlotNumber, "Поле не заполнено");
            }
            if (textPhoneNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoPhoneNumber.SetError(textPhoneNumber, "Поле не заполнено");
            }



            if (!_isError)
            {
                textPhoneNumber.Text = textBoxWithoutNullInBeginning(textPhoneNumber);
                textPolicySeries.Text = textBoxWithoutNullInBeginning(textPolicySeries);
                textPolicyNumb.Text = textBoxWithoutNullInBeginning(textPolicyNumb);
                textDocumentSeries.Text = textBoxWithoutNullInBeginning(textDocumentSeries);
                textDocumentNumber.Text = textBoxWithoutNullInBeginning(textDocumentNumber);
                //textNumbOfHouse.Text = textBoxWithoutNullInBeginning(textNumbOfHouse);
                textNumbOfFlat.Text = textBoxWithoutNullInBeginning(textNumbOfFlat);
                //textPlotNumber.Text = textBoxWithoutNullInBeginning(textPlotNumber);
                textNumbOfPatientCard.Text = textBoxWithoutNullInBeginning(textNumbOfPatientCard);

                if (_presenter.AddPatient())
                {
                    MessageBox.Show("Добавление пациента успешно выполнено!");

                    if (!checkNoCloseWindow.Checked)
                        Close();
                    else
                    {
                        textSurname.Clear();
                        textName.Clear();
                        textPatr.Clear();
                        textPolicySeries.Clear();
                        textPolicyNumb.Clear();
                        textStreet.Clear();
                        textNumbOfHouse.Clear();
                        textNumbOfFlat.Clear();
                        textNumbOfPatientCard.Clear();
                        textDocumentSeries.Clear();
                        textDocumentNumber.Clear();
                        textPlotNumber.Clear();
                        textPhoneNumber.Clear();
                        
                    }
                }
            }

        }


    }
}
