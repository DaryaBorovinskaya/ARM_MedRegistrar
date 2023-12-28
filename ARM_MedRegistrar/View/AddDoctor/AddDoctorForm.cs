using ARM_MedRegistrar.View.AddDoctor;
using ARM_MedRegistrar.Presenter;

namespace ARM_MedRegistrar
{


    public partial class AddDoctorForm : Form, IAddDoctorForm
    {
        //private BindingList<IWorkSchedule> _schedules;
        IList<TimeOnly> _timesOfWork;
        AddDoctorPresenter _presenter;
        DateTime _nullTime = new(1753, 1, 1, 0, 0, 0);
        string IAddDoctorForm.Surname => textSurname.Text;

        string IAddDoctorForm.Name => textName.Text;

        string? IAddDoctorForm.Patronymic => textPatr.Text;

        string IAddDoctorForm.Specializations => comboBoxSpecializations.SelectedItem.ToString();

        string IAddDoctorForm.PhoneNumber => textPhoneNumber.Text;

        int IAddDoctorForm.PlotNumber
        {
            get => int.Parse(textPlotNumber.Text);
            set
            {
                textPlotNumber.Text = value.ToString();
            }
        }


        int IAddDoctorForm.Cabinet => int.Parse(textCabinet.Text);

        IList<TimeOnly> IAddDoctorForm.TimesOfWork
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
                    TimeOnly.FromDateTime(timeFriWorkEnd.Value) ,
                    TimeOnly.FromDateTime(timeSatWorkBeginning.Value),
                    TimeOnly.FromDateTime(timeSatWorkEnd.Value),
                    TimeOnly.FromDateTime(timeSunWorkBeginning.Value),
                    TimeOnly.FromDateTime(timeSunWorkEnd.Value)
                };

                return _timesOfWork;
            }
        }

        TimeOnly IAddDoctorForm.DurationOfAppointment => TimeOnly.FromDateTime(timeDurationOfAppointment.Value);

        public AddDoctorForm()
        {
            InitializeComponent();
            _presenter = new(this);
            comboBoxSpecializations.Items.AddRange(_presenter.SetSpecializations().ToArray());
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

        private string textBoxWithoutNullInBeginning(TextBox textBox)
        {
            string _newTextOfTextBox = textBox.Text;
            int _length = _newTextOfTextBox.Length;
            if (_newTextOfTextBox[0] == '0')
            {
                if (_length == 1)
                    _newTextOfTextBox = "1";
                else
                {
                    while (_newTextOfTextBox.Length >= 1 && _newTextOfTextBox[0] == '0')
                        _newTextOfTextBox = _newTextOfTextBox.Remove(0, 1);
                    if (_newTextOfTextBox.Length == 0) _newTextOfTextBox = "1";
                }
            }
            return _newTextOfTextBox;
        }

        private static bool IsCorrectTime(DateTime timeBeginning, DateTime timeEnd)
        {
            if ((timeEnd.Hour - timeBeginning.Hour < 1) && (timeEnd.Minute - timeBeginning.Minute <= 1))
                return false;
            return true;
        }



        private void buttAddDoctor_Click(object sender, EventArgs e)
        {
            
            
            
            bool _isError = false;
            errorNoPlotNumber.Clear();
            errorNoSurname.Clear();
            errorNoName.Clear();
            errorNoSpecial.Clear();
            errorNoCabinet.Clear();
            errorNoPhoneNumber.Clear();
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

            if (comboBoxSpecializations.SelectedIndex == -1)
            {
                _isError = true;
                errorNoSpecial.SetError(comboBoxSpecializations, "Поле не заполнено");
            }


            if (textCabinet.Text == string.Empty)
            {
                _isError = true;
                errorNoCabinet.SetError(textCabinet, "Поле не заполнено");
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

            if (textPhoneNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoPhoneNumber.SetError(textPhoneNumber, "Поле не заполнено");
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
                errorNoCorrectTimeSat.SetError(timeSatWorkBeginning, "Поле заполнено некорректно\n(нажмите \"Вых.\", если врач в этот день не работает)");
            }

            if (!IsCorrectTime(timeSunWorkBeginning.Value, timeSunWorkEnd.Value) && !checkIsWeekendSun.Checked)
            {
                _isError = true;
                errorNoCorrectTimeSun.SetError(timeSunWorkBeginning, "Поле заполнено некорректно\n(нажмите \"Вых.\", если врач в этот день не работает)");
            }

            if (!_isError)
            {
                textPhoneNumber.Text = textBoxWithoutNullInBeginning(textPhoneNumber);
                textCabinet.Text = textBoxWithoutNullInBeginning(textCabinet);

                if (timeDurationOfAppointment.Value.Minute == _nullTime.Minute)
                    timeDurationOfAppointment.Value = new DateTime(1753, 1, 1, 0, 12, 0);

                _presenter.AddDoctor();

                if (!checkNoCloseWindow.Checked)
                    Close();
                else
                {
                    textSurname.Clear();
                    textName.Clear();
                    textPatr.Clear();
                    textCabinet.Clear();
                    textPlotNumber.Clear();
                    textPhoneNumber.Clear();
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

                MessageBox.Show("Добавление врача успешно выполнено!");
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

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
