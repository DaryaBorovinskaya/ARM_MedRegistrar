using ARM_MedRegistrar.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM_MedRegistrar.View.ChangeDataOfPatient
{
    public partial class ChangeDataOfPatientForm : Form, IChangeDataOfPatientForm
    {
        ChangeDataOfPatientPresenter _presenter;

        uint IChangeDataOfPatientForm.Id => uint.Parse(textId.Text);
        string IChangeDataOfPatientForm.Surname
        {
            get => textSurname.Text;
            set
            {
                textSurname.Text = value;
            }
        }
        string IChangeDataOfPatientForm.Name
        {
            get => textName.Text;
            set
            {
                textName.Text = value;
            }
        }
        string? IChangeDataOfPatientForm.Patronymic
        {
            get => textPatr.Text;
            set
            {
                textPatr.Text = value;
            }



        }
        string IChangeDataOfPatientForm.DateOfBirth
        {
            set
            {
                dateTimeDateOfBirth.Value = DateTime.ParseExact(value, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            }
        }
        string IChangeDataOfPatientForm.PhoneNumber
        {
            get => textPhoneNumber.Text;
            set
            {
                textPhoneNumber.Text = value;
            }
        }
        string IChangeDataOfPatientForm.City
        {
            get => textCity.Text;
            set
            {
                textCity.Text = value;
            }
        }
        string IChangeDataOfPatientForm.Region
        {
            get => textRegion.Text;
            set
            {
                textRegion.Text = value;
            }
        }
        string IChangeDataOfPatientForm.Street
        {
            get => textStreet.Text;
            set
            {
                textStreet.Text = value;
            }
        }
        int IChangeDataOfPatientForm.NumbOfHouse
        {
            get => int.Parse(textNumbOfHouse.Text);
            set
            {
                textNumbOfHouse.Text = value.ToString();
            }
        }
        int IChangeDataOfPatientForm.NumbOfFlat
        {
            get => int.Parse(textNumbOfFlat.Text);
            set
            {
                textNumbOfFlat.Text = value.ToString();
            }
        }
        int IChangeDataOfPatientForm.PlotNumber
        {
            get => int.Parse(textPlotNumber.Text);
            set
            {
                textPlotNumber.Text = value.ToString();
            }
        }
        string IChangeDataOfPatientForm.NumbOfPatientCard
        {
            get => textNumbOfPatientCard.Text;
            set
            {
                textNumbOfPatientCard.Text = value;
            }
        }
        int IChangeDataOfPatientForm.PolicySeries
        {
            get => int.Parse(textPolicySeries.Text);
            set
            {
                textPolicySeries.Text = value.ToString();
            }
        }
        string IChangeDataOfPatientForm.PolicyNumb
        {
            get => textPolicyNumber.Text;
            set
            {
                textPolicyNumber.Text = value;
            }
        }
        string IChangeDataOfPatientForm.DocumentSeries
        {
            get => textDocumentSeries.Text;
            set
            {
                textDocumentSeries.Text = value;
            }
        }
        string IChangeDataOfPatientForm.DocumentNumber
        {
            get => textDocumentNumber.Text;
            set
            {
                textDocumentNumber.Text = value;
            }
        }
        string IChangeDataOfPatientForm.BloodType
        {
            get => comboBoxBloodType.SelectedItem.ToString();
            set
            {
                comboBoxBloodType.SelectedItem = value;
            }
        }
        string IChangeDataOfPatientForm.RhFactor
        {
            get => comboBoxRhFactor.SelectedItem.ToString();
            set
            {
                comboBoxRhFactor.SelectedItem = value;
            }
        }
        string? IChangeDataOfPatientForm.Allergies
        {
            get => textAllergies.Text;
            set
            {
                textAllergies.Text = value;
            }
        }



        public ChangeDataOfPatientForm()
        {
            InitializeComponent();

            comboBoxBloodType.Items.AddRange(new string[] { "Неизвестно", "I", "II", "III", "IV" });
            comboBoxRhFactor.Items.AddRange(new string[] { "Неизвестно", "Положит.", "Отрицат." });



            _presenter = new(this);
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
        private void buttSearch_Click(object sender, EventArgs e)
        {
            errorNoId.Clear();

            if (textId.Text == string.Empty)
                errorNoId.SetError(textId, "Поле \"ID\" не заполнено");

            else
            {

                if (!_presenter.ShowDataAboutPatient())
                {
                    textId.ReadOnly = false;
                    MessageBox.Show($"Не удалось найти пациента с ID: {textId.Text}");
                }
                else
                    textId.ReadOnly = true;
            }
        }

        private void buttSaveChanges_Click(object sender, EventArgs e)
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
            errorNoCity.Clear();
            errorNoRegion.Clear();
            errorNoPlotNumber.Clear();
            errorNoPhoneNumber.Clear();

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

            if (textPolicySeries.Text == string.Empty)
            {
                _isError = true;
                errorNoPolicySeries.SetError(textPolicySeries, "Поле \"Серия полиса\" не заполнено");
            }

            if (textPolicyNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoPolicyNumber.SetError(textPolicyNumber, "Поле \"Номер полиса\" не заполнено");
            }

            if (dateTimeDateOfBirth.Value.Day >= DateTime.Today.Day && dateTimeDateOfBirth.Value.Month >= DateTime.Today.Month
                && dateTimeDateOfBirth.Value.Year >= DateTime.Today.Year || dateTimeDateOfBirth.Value.Year > DateTime.Today.Year)
            {
                _isError = true;
                errorWrongDate.SetError(dateTimeDateOfBirth, "Поле \"Дата рождения\" заполнено неверно");
            }
            if (textCity.Text == string.Empty)
            {
                _isError = true;
                errorNoCity.SetError(textCity, "Поле \"Город\" не заполнено");
            }

            if (textRegion.Text == string.Empty)
            {
                _isError = true;
                errorNoRegion.SetError(textRegion, "Поле \"Район\" не заполнено");
            }

            if (textStreet.Text == string.Empty)
            {
                _isError = true;
                errorNoStreet.SetError(textStreet, "Поле \"Улица\" не заполнено");
            }

            if (textNumbOfHouse.Text == string.Empty)
            {
                _isError = true;
                errorNoNumbOfHouse.SetError(textNumbOfHouse, "Поле \"Дом\" не заполнено");
            }

            if (textNumbOfFlat.Text == string.Empty)
            {
                _isError = true;
                errorNoNumbOfFlat.SetError(textNumbOfFlat, "Поле \"Квартира\" не заполнено");
            }

            if (comboBoxBloodType.SelectedIndex == -1)
            {
                _isError = true;
                errorNoBloodType.SetError(comboBoxBloodType, "Поле \"Группа крови\" не заполнено");
            }

            if (comboBoxRhFactor.SelectedIndex == -1)
            {
                _isError = true;
                errorNoRhFactor.SetError(comboBoxRhFactor, "Поле \"Резус-фактор\" не заполнено");
            }

            if (textNumbOfPatientCard.Text == string.Empty)
            {
                _isError = true;
                errorNoNumbOfPatientCard.SetError(textNumbOfPatientCard, "Поле \"Номер амбулаторной карты\" не заполнено");
            }

            if (textDocumentSeries.Text == string.Empty)
            {
                _isError = true;
                errorNoDocumentSeries.SetError(textDocumentSeries, "Поле \"Серия документа\" не заполнено");
            }

            if (textDocumentNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoDocumentNumber.SetError(textDocumentNumber, "Поле \"Номер документа\" не заполнено");
            }
            if (textPlotNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoPlotNumber.SetError(textPlotNumber, "Поле \"Номер участка\" не заполнено");
            }
            if (textPhoneNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoPhoneNumber.SetError(textPhoneNumber, "Поле \"Номер телефона\" не заполнено");
            }



            if (!_isError)
            {
                if (_presenter.SaveChanges())
                {
                    MessageBox.Show("Данные пациента успешно изменены");

                    textId.ReadOnly = false;
                    if (!checkNoCloseWindow.Checked)
                        Close();
                    else
                    {
                        textId.Clear();
                        textSurname.Clear();
                        textName.Clear();
                        textPatr.Clear();
                        textDocumentSeries.Clear();
                        textDocumentNumber.Clear();
                        textPolicySeries.Clear();
                        textPolicyNumber.Clear();
                        dateTimeDateOfBirth.Value = DateTime.Today;
                        textPhoneNumber.Clear();
                        textCity.Clear();
                        textRegion.Clear();
                        textStreet.Clear();
                        textNumbOfHouse.Clear();    
                        textNumbOfFlat.Clear();
                        textPlotNumber.Clear();
                        textNumbOfPatientCard.Clear();
                        comboBoxBloodType.SelectedIndex = -1;
                        comboBoxRhFactor.SelectedIndex = -1;
                        textAllergies.Clear();

                    }
                }
                else
                    MessageBox.Show("Не удалось внести изменения");
            }
        }
    }
}
