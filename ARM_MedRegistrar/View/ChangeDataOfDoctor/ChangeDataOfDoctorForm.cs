using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ARM_MedRegistrar.Presenter;

namespace ARM_MedRegistrar.View.ChangeDataOfDoctor
{
    public partial class ChangeDataOfDoctorForm : Form, IChangeDataOfDoctorForm
    {
        IList<DateTime> _timesOfWork;
        DateTime _nullTime = new(1753, 1, 1, 0, 0, 0);
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

        IList<DateTime> IChangeDataOfDoctorForm.TimesOfWork
        {
            get
            {
                _timesOfWork = new List<DateTime>()
                {
                    timeMonWorkBeginning.Value,
                    timeMonWorkEnd.Value,
                    timeTuesWorkBeginning.Value,
                    timeTuesWorkEnd.Value,
                    timeWedWorkBeginning.Value,
                    timeWedWorkEnd.Value,
                    timeThursWorkBeginning.Value,
                    timeThursWorkEnd.Value,
                    timeFriWorkBeginning.Value,
                    timeFriWorkEnd.Value,
                    timeSatWorkBeginning.Value,
                    timeSatWorkEnd.Value,
                    timeSunWorkBeginning.Value,
                    timeSunWorkEnd.Value
                };

                return _timesOfWork;
            }
            set
            {
                _timesOfWork = value;
                if (_timesOfWork[0] == _nullTime && _timesOfWork[1] == _nullTime)
                    checkIsWeekendMon.Checked = true;
                else
                {
                    timeMonWorkBeginning.Value = _timesOfWork[0];
                    timeMonWorkEnd.Value = _timesOfWork[1];
                }

                if (_timesOfWork[2] == _nullTime && _timesOfWork[3] == _nullTime)
                    checkIsWeekendTues.Checked = true;
                else
                {
                    timeTuesWorkBeginning.Value = _timesOfWork[2];
                    timeTuesWorkEnd.Value = _timesOfWork[3];
                }

                if (_timesOfWork[4] == _nullTime && _timesOfWork[5] == _nullTime)
                    checkIsWeekendWed.Checked = true;
                else
                {
                    timeWedWorkBeginning.Value = _timesOfWork[4];
                    timeWedWorkEnd.Value = _timesOfWork[5];
                }

                if (_timesOfWork[6] == _nullTime && _timesOfWork[7] == _nullTime)
                    checkIsWeekendThurs.Checked = true;
                else
                {
                    timeThursWorkBeginning.Value = _timesOfWork[6];
                    timeThursWorkEnd.Value = _timesOfWork[7];
                }

                if (_timesOfWork[8] == _nullTime && _timesOfWork[9] == _nullTime)
                    checkIsWeekendFri.Checked = true;
                else
                {
                    timeFriWorkBeginning.Value = _timesOfWork[8];
                    timeFriWorkEnd.Value = _timesOfWork[9];
                }

                if (_timesOfWork[10] == _nullTime && _timesOfWork[11] == _nullTime)
                    checkIsWeekendSat.Checked = true;
                else
                {
                    timeSatWorkBeginning.Value = _timesOfWork[10];
                    timeSatWorkEnd.Value = _timesOfWork[11];
                }

                if (_timesOfWork[12] == _nullTime && _timesOfWork[13] == _nullTime)
                    checkIsWeekendSun.Checked = true;
                else
                {
                    timeSunWorkBeginning.Value = _timesOfWork[12];
                    timeSunWorkEnd.Value = _timesOfWork[13];
                }

            }
        }

        DateTime IChangeDataOfDoctorForm.DurationOfAppointment
        {
            get => timeDurationOfAppointment.Value;
            set
            {
                timeDurationOfAppointment.Value = value;
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

        private static bool IsCorrectTime(DateTime timeBeginning, DateTime timeEnd)
        {
            if ((timeEnd.Hour - timeBeginning.Hour < 1) && (timeEnd.Minute - timeBeginning.Minute < 1))
                return false;
            return true;
        }


        private void buttSearch_Click(object sender, EventArgs e)
        {
            buttSaveChanges.Enabled = true;
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
            buttSaveChanges.Enabled = false;
            bool _isError = false;

            errorNoSurname.Clear();
            errorNoName.Clear();
            errorNoPhoneNumber.Clear();
            errorNoSpecialization.Clear();
            errorNoCabinet.Clear();
            errorNoPlotNumber.Clear();
            errorNoDurationOfAppointment.Clear();
            errorNoCorrectTimeMon.Clear();
            errorNoCorrectTimeTues.Clear();
            errorNoCorrectTimeWed.Clear();
            errorNoCorrectTimeThurs.Clear();
            errorNoCorrectTimeFri.Clear();
            errorNoCorrectTimeSat.Clear();
            errorNoCorrectTimeSun.Clear();

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

            if (timeDurationOfAppointment.Value.Hour > 1 || (timeDurationOfAppointment.Value.Hour == DateTime.Now.Hour && timeDurationOfAppointment.Value.Minute == DateTime.Now.Minute))
            {
                _isError = true;
                errorNoDurationOfAppointment.SetError(timeDurationOfAppointment, "Поле \"Продолжительность приёма\" заполнено некорректно");
            }

            if (!IsCorrectTime(timeMonWorkBeginning.Value, timeMonWorkEnd.Value) && !checkIsWeekendMon.Checked)
            {
                _isError = true;
                errorNoCorrectTimeMon.SetError(timeMonWorkBeginning, "Рабочее время заполнено некорректно\n(нажмите \"Вых.\", если врач в этот день не работает)");
            }

            if (!IsCorrectTime(timeTuesWorkBeginning.Value, timeTuesWorkEnd.Value) && !checkIsWeekendTues.Checked)
            {
                _isError = true;
                errorNoCorrectTimeTues.SetError(timeTuesWorkBeginning, "Рабочее время заполнено некорректно\n(нажмите \"Вых.\", если врач в этот день не работает)");
            }

            if (!IsCorrectTime(timeWedWorkBeginning.Value, timeWedWorkEnd.Value) && !checkIsWeekendWed.Checked)
            {
                _isError = true;
                errorNoCorrectTimeWed.SetError(timeWedWorkBeginning, "Рабочее время заполнено некорректно\n(нажмите \"Вых.\", если врач в этот день не работает)");
            }

            if (!IsCorrectTime(timeThursWorkBeginning.Value, timeThursWorkEnd.Value) && !checkIsWeekendThurs.Checked)
            {
                _isError = true;
                errorNoCorrectTimeThurs.SetError(timeThursWorkBeginning, "Рабочее время заполнено некорректно\n(нажмите \"Вых.\", если врач в этот день не работает)");
            }

            if (!IsCorrectTime(timeFriWorkBeginning.Value, timeFriWorkEnd.Value) && !checkIsWeekendFri.Checked)
            {
                _isError = true;
                errorNoCorrectTimeFri.SetError(timeFriWorkBeginning, "Рабочее время заполнено некорректно\n(нажмите \"Вых.\", если врач в этот день не работает)");
            }

            if (!IsCorrectTime(timeSatWorkBeginning.Value, timeSatWorkEnd.Value) && !checkIsWeekendSat.Checked)
            {
                _isError = true;
                errorNoCorrectTimeSat.SetError(timeSatWorkBeginning, "Рабочее время заполнено некорректно\n(нажмите \"Вых.\", если врач в этот день не работает)");
            }

            if (!IsCorrectTime(timeSunWorkBeginning.Value, timeSunWorkEnd.Value) && !checkIsWeekendSun.Checked)
            {
                _isError = true;
                errorNoCorrectTimeSun.SetError(timeSunWorkBeginning, "Рабочее время заполнено некорректно\n(нажмите \"Вых.\", если врач в этот день не работает)");
            }

            if (!_isError)
            {
                textPhoneNumber.Text = textBoxWithoutNullInBeginning(textPhoneNumber);
                textPlotNumber.Text = textBoxWithoutNullInBeginning(textPlotNumber);
                textCabinet.Text = textBoxWithoutNullInBeginning(textCabinet);

                if (timeDurationOfAppointment.Value.Minute == _nullTime.Minute)
                    timeDurationOfAppointment.Value = new DateTime(1753, 1, 1, 0, 12, 0);

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
                        timeDurationOfAppointment.Value = DateTime.Now;
                        timeMonWorkBeginning.Value = DateTime.Now;
                        timeMonWorkEnd.Value = DateTime.Now;
                        timeTuesWorkBeginning.Value = DateTime.Now;
                        timeTuesWorkEnd.Value = DateTime.Now;
                        timeWedWorkBeginning.Value = DateTime.Now;
                        timeWedWorkEnd.Value = DateTime.Now;
                        timeThursWorkBeginning.Value = DateTime.Now;
                        timeThursWorkEnd.Value = DateTime.Now;
                        timeFriWorkBeginning.Value = DateTime.Now;
                        timeFriWorkEnd.Value = DateTime.Now;
                        timeSatWorkBeginning.Value = DateTime.Now;
                        timeSatWorkEnd.Value = DateTime.Now;
                        timeSunWorkBeginning.Value = DateTime.Now;
                        timeSunWorkEnd.Value = DateTime.Now;

                    }
                }
                else
                    MessageBox.Show("Не удалось внести изменения");
            }
            else
                buttSaveChanges.Enabled = true;
        }

        private void checkIsWeekendMon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsWeekendMon.Checked)
            {
                timeMonWorkBeginning.Value = _nullTime;
                timeMonWorkEnd.Value = _nullTime;
                timeMonWorkBeginning.Visible = false;
                timeMonWorkEnd.Visible = false;
            }
            else
            {
                timeMonWorkBeginning.Value = DateTime.Now;
                timeMonWorkEnd.Value = DateTime.Now;
                timeMonWorkBeginning.Visible = true;
                timeMonWorkEnd.Visible = true;
            }
        }

        private void checkIsWeekendTues_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsWeekendTues.Checked)
            {
                timeTuesWorkBeginning.Value = _nullTime;
                timeTuesWorkEnd.Value = _nullTime;
                timeTuesWorkBeginning.Visible = false;
                timeTuesWorkEnd.Visible = false;
            }
            else
            {
                timeTuesWorkBeginning.Value = DateTime.Now;
                timeTuesWorkEnd.Value = DateTime.Now;
                timeTuesWorkBeginning.Visible = true;
                timeTuesWorkEnd.Visible = true;
            }
        }

        private void checkIsWeekendWed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsWeekendWed.Checked)
            {
                timeWedWorkBeginning.Value = _nullTime;
                timeWedWorkEnd.Value = _nullTime;
                timeWedWorkBeginning.Visible = false;
                timeWedWorkEnd.Visible = false;
            }
            else
            {
                timeWedWorkBeginning.Value = DateTime.Now;
                timeWedWorkEnd.Value = DateTime.Now;
                timeWedWorkBeginning.Visible = true;
                timeWedWorkEnd.Visible = true;
            }

        }

        private void checkIsWeekendThurs_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsWeekendThurs.Checked)
            {
                timeThursWorkBeginning.Value = _nullTime;
                timeThursWorkEnd.Value = _nullTime;
                timeThursWorkBeginning.Visible = false;
                timeThursWorkEnd.Visible = false;
            }
            else
            {
                timeThursWorkBeginning.Value = DateTime.Now;
                timeThursWorkEnd.Value = DateTime.Now;
                timeThursWorkBeginning.Visible = true;
                timeThursWorkEnd.Visible = true;
            }
        }

        private void checkIsWeekendFri_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsWeekendFri.Checked)
            {
                timeFriWorkBeginning.Value = _nullTime;
                timeFriWorkEnd.Value = _nullTime;
                timeFriWorkBeginning.Visible = false;
                timeFriWorkEnd.Visible = false;
            }
            else
            {
                timeFriWorkBeginning.Value = DateTime.Now;
                timeFriWorkEnd.Value = DateTime.Now;
                timeFriWorkBeginning.Visible = true;
                timeFriWorkEnd.Visible = true;
            }
        }

        private void checkIsWeekendSat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsWeekendSat.Checked)
            {
                timeSatWorkBeginning.Value = _nullTime;
                timeSatWorkEnd.Value = _nullTime;
                timeSatWorkBeginning.Visible = false;
                timeSatWorkEnd.Visible = false;
            }
            else
            {
                timeSatWorkBeginning.Value = DateTime.Now;
                timeSatWorkEnd.Value = DateTime.Now;
                timeSatWorkBeginning.Visible = true;
                timeSatWorkEnd.Visible = true;
            }
        }

        private void checkIsWeekendSun_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsWeekendSun.Checked)
            {
                timeSunWorkBeginning.Value = _nullTime;
                timeSunWorkEnd.Value = _nullTime;
                timeSunWorkBeginning.Visible = false;
                timeSunWorkEnd.Visible = false;
            }
            else
            {
                timeSunWorkBeginning.Value = DateTime.Now;
                timeSunWorkEnd.Value = DateTime.Now;
                timeSunWorkBeginning.Visible = true;
                timeSunWorkEnd.Visible = true;
            }
        }

    }
}
