using ARM_MedRegistrar.Presenter;


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
        DateOnly IChangeDataOfPatientForm.DateOfBirth
        {
            set
            {
                dateTimeDateOfBirth.Value = new DateTime(value.Year,value.Month,value.Day);
                dateTimeDateOfBirth.Enabled = false;
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


        private void buttSearch_Click(object sender, EventArgs e)
        {
            buttSaveChanges.Enabled = true;
            errorNoId.Clear();

            if (textId.Text == string.Empty)
                errorNoId.SetError(textId, "Поле не заполнено");

            else
            {
                textId.Text = textBoxWithoutNullInBeginning(textId);
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
            buttSaveChanges.Enabled = false;
            bool _isError = false;

            errorNoSurname.Clear();
            errorNoName.Clear();
            errorNoPolicySeries.Clear();
            errorNoPolicyNumber.Clear();
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

            if (textPolicyNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoPolicyNumber.SetError(textPolicyNumber, "Поле не заполнено");
            }

            
            if (textCity.Text == string.Empty)
            {
                _isError = true;
                errorNoCity.SetError(textCity, "Поле не заполнено");
            }

            if (textRegion.Text == string.Empty)
            {
                _isError = true;
                errorNoRegion.SetError(textRegion, "Поле не заполнено");
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
                textPolicyNumber.Text = textBoxWithoutNullInBeginning(textPolicyNumber);
                textDocumentSeries.Text = textBoxWithoutNullInBeginning(textDocumentSeries);
                textDocumentNumber.Text = textBoxWithoutNullInBeginning(textDocumentNumber);
                textNumbOfHouse.Text = textBoxWithoutNullInBeginning(textNumbOfHouse);
                textNumbOfFlat.Text = textBoxWithoutNullInBeginning(textNumbOfFlat);
                textPlotNumber.Text = textBoxWithoutNullInBeginning(textPlotNumber);
                textNumbOfPatientCard.Text = textBoxWithoutNullInBeginning(textNumbOfPatientCard);

                if (_presenter.SaveChanges())
                {
                    MessageBox.Show("Данные успешно изменены");

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
