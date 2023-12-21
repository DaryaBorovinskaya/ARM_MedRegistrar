
using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Model.Patients;
using ARM_MedRegistrar.View.AddPatient;
using ARM_MedRegistrar.Presenter;

namespace ARM_MedRegistrar
{
    public partial class AddPatientForm : Form, IAddPatientForm
    {
        private AddPatientPresenter _presenter;
        string IAddPatientForm.Surname => textSurname.Text;

        string IAddPatientForm.Name => textName.Text;

        string? IAddPatientForm.Patronymic => textPatr.Text;

        string IAddPatientForm.DateOfBirth => dateTimeDateOfBirth.Value.ToShortDateString();
        string IAddPatientForm.PhoneNumber => textPhoneNumber.Text;
        string? IAddPatientForm.City => textCity.Text;
        string? IAddPatientForm.Region => textRegion.Text;
        string IAddPatientForm.Street => textStreet.Text;
        int IAddPatientForm.NumbOfHouse => (int)numericNumbOfHouse.Value;
        int IAddPatientForm.NumbOfFlat => (int)numericNumbOfFlat.Value;
        int IAddPatientForm.PlotNumber => (int)numericPlotNumber.Value;
        string IAddPatientForm.NumbOfPatientCard => textNumbOfPatientCard.Text;
        int IAddPatientForm.PolicySeries => (int)numericPolicySeries.Value;
        string IAddPatientForm.PolicyNumb => textPolicyNumb.Text;
        string IAddPatientForm.DocumentSeries => textDocumentSeries.Text;
        string IAddPatientForm.DocumentNumber => textDocumentNumber.Text;
        string IAddPatientForm.BloodType => comboBoxBloodType.SelectedItem.ToString();
        string IAddPatientForm.RhFactor => comboBoxRhFactor.SelectedItem.ToString();
        string? IAddPatientForm.Allergies => textAllergies.Text;

        public AddPatientForm()
        {

            InitializeComponent();
            comboBoxBloodType.Items.AddRange(new string[] { "Неизвестно", "I", "II", "III", "IV" });
            comboBoxRhFactor.Items.AddRange(new string[] { "Неизвестно", "Положит.", "Отрицат." });

            _presenter = new(this);

            _presenter.NoCityEvent += NoCitySet;
            _presenter.NoRegionEvent += NoRegionSet;
        }

        private void NoRegionSet(object? sender, EventArgs e)
        {
            errorNoRegion.SetError(textRegion, "Поле \"Район\" не заполнено");
        }

        private void NoCitySet(object? sender, EventArgs e)
        {
            errorNoCity.SetError(textCity, "Поле \"Город\" не заполнено");
        }

        private void textBox_SpacePress(object sender, KeyPressEventArgs e)
        {
            //char ch = e.KeyChar;

            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void textBox_ContainsExceptNumbers(object sender, KeyPressEventArgs e)
        {
            //char ch = e.KeyChar;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)     //(8 - это Backspace)
                e.KeyChar = '\0';

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
            numericPolicySeries.Maximum = 9999;
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

            if (numericPolicySeries.Value == 0)
            {
                _isError = true;
                errorNoPolicySeries.SetError(numericPolicySeries, "Поле \"Серия полиса\" не заполнено");
            }

            if (textPolicyNumb.Text == string.Empty)
            {
                _isError = true;
                errorNoPolicyNumber.SetError(textPolicyNumb, "Поле \"Номер полиса\" не заполнено");
            }

            if (dateTimeDateOfBirth.Value.Day >= DateTime.Today.Day && dateTimeDateOfBirth.Value.Month >= DateTime.Today.Month
                && dateTimeDateOfBirth.Value.Year >= DateTime.Today.Year || dateTimeDateOfBirth.Value.Year > DateTime.Today.Year)
            {
                _isError = true;
                errorWrongDate.SetError(dateTimeDateOfBirth, "Поле \"Дата рождения\" заполнено неверно");
            }

            if (textStreet.Text == string.Empty)
            {
                _isError = true;
                errorNoStreet.SetError(textStreet, "Поле \"Улица\" не заполнено");
            }

            if (numericNumbOfHouse.Value == 0)
            {
                _isError = true;
                errorNoNumbOfHouse.SetError(numericNumbOfHouse, "Поле \"Дом\" не заполнено");
            }

            if (numericNumbOfFlat.Value == 0)
            {
                _isError = true;
                errorNoNumbOfFlat.SetError(numericNumbOfFlat, "Поле \"Квартира\" не заполнено");
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
            if (numericPlotNumber.Value == 0)
            {
                _isError = true;
                errorNoPlotNumber.SetError(numericPlotNumber, "Поле \"Номер участка\" не заполнено");
            }
            if (textPhoneNumber.Text == string.Empty) 
            {
                _isError = true;
                errorNoPhoneNumber.SetError(textPhoneNumber, "Поле \"Номер телефона\" не заполнено");
            }
            

            if (!_isError)
            {
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
                        numericPolicySeries.Value = 0;
                        textPolicyNumb.Clear();
                        textStreet.Clear();
                        numericNumbOfHouse.Value = 0;
                        numericNumbOfFlat.Value = 0;
                        textNumbOfPatientCard.Clear();
                        textDocumentSeries.Clear();
                        textDocumentNumber.Clear();
                        numericPlotNumber.Value = 0;
                        textPhoneNumber.Clear();
                    }
                }
            }

        }


    }
}
