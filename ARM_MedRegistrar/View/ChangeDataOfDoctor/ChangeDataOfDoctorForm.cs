using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ARM_MedRegistrar.Presenter;

namespace ARM_MedRegistrar.View.ChangeDataOfDoctor
{
    public partial class ChangeDataOfDoctorForm : Form, IChangeDataOfDoctorForm
    {
        ChangeDataOfDoctorPresenter _presenter;

        uint IChangeDataOfDoctorForm.Id => uint.Parse(textId.Text);

        string IChangeDataOfDoctorForm.Surname
        {
            get => textSurname.Text;
            set
            {
                textSurname.Text = value;
            }
        }
        string IChangeDataOfDoctorForm.Name
        {
            get => textName.Text;
            set
            {
                textName.Text = value;
            }
        }
        string? IChangeDataOfDoctorForm.Patronymic
        {
            get => textPatr.Text;
            set
            {
                textPatr.Text = value;
            }
        }
        string IChangeDataOfDoctorForm.Specialization
        {
            get => comboBoxSpecializations.SelectedItem.ToString();
            set
            {
                comboBoxSpecializations.SelectedItem = value;
            }
        }
        string IChangeDataOfDoctorForm.PhoneNumber
        {
            get => textPhoneNumber.Text;
            set
            {
                textPhoneNumber.Text = value;
            }
        }

        int IChangeDataOfDoctorForm.PlotNumber
        {
            get => int.Parse(textPlotNumber.Text);
            set
            {
                textPlotNumber.Text = value.ToString();
            }
        }
        int IChangeDataOfDoctorForm.Cabinet
        {
            get => int.Parse(textCabinet.Text);
            set
            {
                textCabinet.Text = value.ToString();
            }
        }

        public ChangeDataOfDoctorForm()
        {
            InitializeComponent();
            comboBoxSpecializations.Items.AddRange(new string[] { "терапевт", "педиатр", "врач общей практики", "хирург", "невролог", "оториноларинголог", "офтальмолог", "травматолог", "акушер-гинеколог", "уролог", "инфекционист", "онколог", "гастроэнтеролог", "кардиолог", "эндокринолог" });

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
            errorNoId.Clear();

            if (textId.Text == string.Empty)
                errorNoId.SetError(textId, "Поле \"ID\" не заполнено");

            

            else
            {
                textId.Text = textBoxWithoutNullInBeginning(textId);

                if (!_presenter.ShowDataAboutDoctor())
                {
                    textId.ReadOnly = false;
                    MessageBox.Show($"Не удалось найти врача с ID: {textId.Text}");
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
            errorNoPhoneNumber.Clear();
            errorNoSpecialization.Clear();
            errorNoCabinet.Clear();
            errorNoPlotNumber.Clear();


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

            if (textPhoneNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoPhoneNumber.SetError(textPhoneNumber, "Поле \"Номер телефона\" не заполнено");
            }
            if (comboBoxSpecializations.SelectedIndex == -1)
            {
                _isError = true;
                errorNoSpecialization.SetError(comboBoxSpecializations, "Поле \"Специализация\" не заполнено");
            }
            if (textCabinet.Text == string.Empty)
            {
                _isError = true;
                errorNoCabinet.SetError(textCabinet, "Поле \"Номер кабинета\" не заполнено");
            }
            if (textPlotNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoPlotNumber.SetError(textPlotNumber, "Поле \"Номер участка\" не заполнено");
            }

            textPhoneNumber.Text = textBoxWithoutNullInBeginning(textPhoneNumber);
            textPlotNumber.Text = textBoxWithoutNullInBeginning(textPlotNumber);
            textCabinet.Text = textBoxWithoutNullInBeginning(textCabinet);


            if (!_isError)
            {
                if (_presenter.SaveChanges())
                {
                    MessageBox.Show("Данные врача успешно изменены");

                    textId.ReadOnly = false;
                    if (!checkNoCloseWindow.Checked)
                        Close();
                    else
                    {
                        textId.Clear();
                        textSurname.Clear();
                        textName.Clear();
                        textPatr.Clear();
                        textPhoneNumber.Clear();
                        textCabinet.Clear();
                        textPlotNumber.Clear();
                        comboBoxSpecializations.SelectedIndex = -1;


                    }
                }
                else
                    MessageBox.Show("Не удалось внести изменения");
            }
        }



    }
}
