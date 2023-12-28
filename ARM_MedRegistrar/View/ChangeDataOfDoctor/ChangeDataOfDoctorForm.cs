using ARM_MedRegistrar.Presenter;

namespace ARM_MedRegistrar.View.ChangeDataOfDoctor
{
    public partial class ChangeDataOfDoctorForm : Form, IChangeDataOfDoctorForm
    {
        IList<TimeOnly> _timesOfWork;
        DateTime _nullDateTime = new(1753,1,1,0, 0, 0);
        TimeOnly _nullTime = new(0, 0, 0);
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

        IList<TimeOnly> IChangeDataOfDoctorForm.TimesOfWork
        {
            get
            {
                _timesOfWork = new List<TimeOnly>()
                {
                    TimeOnly.FromDateTime(timeMonWorkBeginning.Value),
                    TimeOnly.FromDateTime(timeMonWorkEnd.Value),
                    TimeOnly.FromDateTime(timeTuesWorkBeginning.Value),
                    TimeOnly.FromDateTime(timeTuesWorkEnd.Value),
                    TimeOnly.FromDateTime(timeWedWorkBeginning.Value),
                    TimeOnly.FromDateTime(timeWedWorkEnd.Value),
                    TimeOnly.FromDateTime(timeThursWorkBeginning.Value),
                    TimeOnly.FromDateTime(timeThursWorkEnd.Value),
                    TimeOnly.FromDateTime(timeFriWorkBeginning.Value),
                    TimeOnly.FromDateTime(timeFriWorkEnd.Value),
                    TimeOnly.FromDateTime(timeSatWorkBeginning.Value),
                    TimeOnly.FromDateTime(timeSatWorkEnd.Value),
                    TimeOnly.FromDateTime(timeSunWorkBeginning.Value),
                    TimeOnly.FromDateTime(timeSunWorkEnd.Value)
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
                    timeMonWorkBeginning.Value = new DateTime(1753,1,1, _timesOfWork[0].Hour, _timesOfWork[0].Minute,0);
                    timeMonWorkEnd.Value = new DateTime(1753, 1, 1, _timesOfWork[1].Hour, _timesOfWork[1].Minute, 0);
                }

                if (_timesOfWork[2] == _nullTime && _timesOfWork[3] == _nullTime)
                    checkIsWeekendTues.Checked = true;
                else
                {
                    timeTuesWorkBeginning.Value = new DateTime(1753, 1, 1, _timesOfWork[2].Hour, _timesOfWork[2].Minute, 0);
                    timeTuesWorkEnd.Value = new DateTime(1753, 1, 1, _timesOfWork[3].Hour, _timesOfWork[3].Minute, 0);
                }

                if (_timesOfWork[4] == _nullTime && _timesOfWork[5] == _nullTime)
                    checkIsWeekendWed.Checked = true;
                else
                {
                    timeWedWorkBeginning.Value = new DateTime(1753, 1, 1, _timesOfWork[4].Hour, _timesOfWork[4].Minute, 0);
                    timeWedWorkEnd.Value = new DateTime(1753, 1, 1, _timesOfWork[5].Hour, _timesOfWork[5].Minute, 0);
                }

                if (_timesOfWork[6] == _nullTime && _timesOfWork[7] == _nullTime)
                    checkIsWeekendThurs.Checked = true;
                else
                {
                    timeThursWorkBeginning.Value = new DateTime(1753, 1, 1, _timesOfWork[6].Hour, _timesOfWork[6].Minute, 0);
                    timeThursWorkEnd.Value = new DateTime(1753, 1, 1, _timesOfWork[7].Hour, _timesOfWork[7].Minute, 0);
                }

                if (_timesOfWork[8] == _nullTime && _timesOfWork[9] == _nullTime)
                    checkIsWeekendFri.Checked = true;
                else
                {
                    timeFriWorkBeginning.Value = new DateTime(1753, 1, 1, _timesOfWork[8].Hour, _timesOfWork[8].Minute, 0);
                    timeFriWorkEnd.Value = new DateTime(1753, 1, 1, _timesOfWork[9].Hour, _timesOfWork[9].Minute, 0);
                }

                if (_timesOfWork[10] == _nullTime && _timesOfWork[11] == _nullTime)
                    checkIsWeekendSat.Checked = true;
                else
                {
                    timeSatWorkBeginning.Value = new DateTime(1753, 1, 1, _timesOfWork[10].Hour, _timesOfWork[10].Minute, 0);
                    timeSatWorkEnd.Value = new DateTime(1753, 1, 1, _timesOfWork[11].Hour, _timesOfWork[11].Minute, 0);
                }

                if (_timesOfWork[12] == _nullTime && _timesOfWork[13] == _nullTime)
                    checkIsWeekendSun.Checked = true;
                else
                {
                    timeSunWorkBeginning.Value = new DateTime(1753, 1, 1, _timesOfWork[12].Hour, _timesOfWork[12].Minute, 0);
                    timeSunWorkEnd.Value = new DateTime(1753, 1, 1, _timesOfWork[13].Hour, _timesOfWork[13].Minute, 0);
                }

            }
        }

        TimeOnly IChangeDataOfDoctorForm.DurationOfAppointment
        {
            get => TimeOnly.FromDateTime(timeDurationOfAppointment.Value);
            set
            {
                timeDurationOfAppointment.Value = new DateTime(1753, 1, 1, value.Hour,value.Minute,0);
            }
        }
        public ChangeDataOfDoctorForm()
        {
            InitializeComponent();
            _presenter = new(this);
            comboBoxSpecializations.Items.AddRange(_presenter.SetSpecializations().ToArray());
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
                errorNoId.SetError(textId, "Поле не заполнено");



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
                errorNoSurname.SetError(textSurname, "Поле не заполнено");
            }

            if (textName.Text == string.Empty)
            {
                _isError = true;
                errorNoName.SetError(textName, "Поле не заполнено");
            }

            if (textPhoneNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoPhoneNumber.SetError(textPhoneNumber, "Поле не заполнено");
            }
            if (comboBoxSpecializations.SelectedIndex == -1)
            {
                _isError = true;
                errorNoSpecialization.SetError(comboBoxSpecializations, "Поле не заполнено");
            }
            if (textCabinet.Text == string.Empty)
            {
                _isError = true;
                errorNoCabinet.SetError(textCabinet, "Поле не заполнено");
            }
            

            if (timeDurationOfAppointment.Value.Hour > 1 || (timeDurationOfAppointment.Value.Hour == DateTime.Now.Hour && timeDurationOfAppointment.Value.Minute == DateTime.Now.Minute))
            {
                _isError = true;
                errorNoDurationOfAppointment.SetError(timeDurationOfAppointment, "Поле заполнено некорректно");
            }

            if (!IsCorrectTime(timeMonWorkBeginning.Value, timeMonWorkEnd.Value) && !checkIsWeekendMon.Checked)
            {
                _isError = true;
                errorNoCorrectTimeMon.SetError(timeMonWorkBeginning, "Поле заполнено некорректно\n(нажмите \"Вых.\", если врач в этот день не работает)");
            }

            if (!IsCorrectTime(timeTuesWorkBeginning.Value, timeTuesWorkEnd.Value) && !checkIsWeekendTues.Checked)
            {
                _isError = true;
                errorNoCorrectTimeTues.SetError(timeTuesWorkBeginning, "Поле заполнено некорректно\n(нажмите \"Вых.\", если врач в этот день не работает)");
            }

            if (!IsCorrectTime(timeWedWorkBeginning.Value, timeWedWorkEnd.Value) && !checkIsWeekendWed.Checked)
            {
                _isError = true;
                errorNoCorrectTimeWed.SetError(timeWedWorkBeginning, "Поле заполнено некорректно\n(нажмите \"Вых.\", если врач в этот день не работает)");
            }

            if (!IsCorrectTime(timeThursWorkBeginning.Value, timeThursWorkEnd.Value) && !checkIsWeekendThurs.Checked)
            {
                _isError = true;
                errorNoCorrectTimeThurs.SetError(timeThursWorkBeginning, "Поле заполнено некорректно\n(нажмите \"Вых.\", если врач в этот день не работает)");
            }

            if (!IsCorrectTime(timeFriWorkBeginning.Value, timeFriWorkEnd.Value) && !checkIsWeekendFri.Checked)
            {
                _isError = true;
                errorNoCorrectTimeFri.SetError(timeFriWorkBeginning, "Поле заполнено некорректно\n(нажмите \"Вых.\", если врач в этот день не работает)");
            }

            if (!IsCorrectTime(timeSatWorkBeginning.Value, timeSatWorkEnd.Value) && !checkIsWeekendSat.Checked)
            {
                _isError = true;
                errorNoCorrectTimeSat.SetError(timeSatWorkBeginning, "Рабочее время заполнено некорректно\n(нажмите \"Вых.\", если врач в этот день не работает)");
            }

            if (!IsCorrectTime(timeSunWorkBeginning.Value, timeSunWorkEnd.Value) && !checkIsWeekendSun.Checked)
            {
                _isError = true;
                errorNoCorrectTimeSun.SetError(timeSunWorkBeginning, "Поле заполнено некорректно\n(нажмите \"Вых.\", если врач в этот день не работает)");
            }

            if (!_presenter.SetPlotNumber())
            {
                _isError = true;
                errorNoPlotNumber.SetError(textPlotNumber, "Поле заполнено неверно");
            }
            if (textPlotNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoPlotNumber.SetError(textPlotNumber, "Поле не заполнено");
            }



            if (!_isError)
            {
                textPhoneNumber.Text = textBoxWithoutNullInBeginning(textPhoneNumber);
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
                timeMonWorkBeginning.Value = _nullDateTime;
                timeMonWorkEnd.Value = _nullDateTime;
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
                timeTuesWorkBeginning.Value = _nullDateTime;
                timeTuesWorkEnd.Value = _nullDateTime;
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
                timeWedWorkBeginning.Value = _nullDateTime;
                timeWedWorkEnd.Value = _nullDateTime;
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
                timeThursWorkBeginning.Value = _nullDateTime;
                timeThursWorkEnd.Value = _nullDateTime;
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
                timeFriWorkBeginning.Value = _nullDateTime;
                timeFriWorkEnd.Value = _nullDateTime;
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
                timeSatWorkBeginning.Value = _nullDateTime;
                timeSatWorkEnd.Value = _nullDateTime;
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
                timeSunWorkBeginning.Value = _nullDateTime;
                timeSunWorkEnd.Value = _nullDateTime;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
