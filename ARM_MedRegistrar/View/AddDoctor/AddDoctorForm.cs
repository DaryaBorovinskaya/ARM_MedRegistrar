using ARM_MedRegistrar.View.AddDoctor;
using ARM_MedRegistrar.Presenter;
using ARM_MedRegistrar.Model.WorkSchedules;
using ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository;
using System.ComponentModel;
using System;

namespace ARM_MedRegistrar
{


    public partial class AddDoctorForm : Form, IAddDoctorForm
    {
        //private BindingList<IWorkSchedule> _schedules;
        IList<DateTime> _timesOfWork;
        AddDoctorPresenter _presenter;
        DateTime _nullTime = new(1753, 1, 1, 0, 0, 0);
        string IAddDoctorForm.Surname => textSurname.Text;

        string IAddDoctorForm.Name => textName.Text;

        string? IAddDoctorForm.Patronymic => textPatr.Text;

        string IAddDoctorForm.Specializations => comboBoxSpecializations.SelectedItem.ToString();

        string IAddDoctorForm.PhoneNumber => textPhoneNumber.Text;

        int IAddDoctorForm.PlotNumber => int.Parse(textPlotNumber.Text);

        int IAddDoctorForm.Cabinet => int.Parse(textCabinet.Text);

        IList<DateTime> IAddDoctorForm.TimesOfWork
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
        }

        DateTime IAddDoctorForm.DurationOfAppointment => timeDurationOfAppointment.Value;

        public AddDoctorForm()
        {
            InitializeComponent();
            comboBoxSpecializations.Items.AddRange(new string[] { "терапевт", "педиатр", "врач общей практики", "хирург", "невролог", "оториноларинголог", "офтальмолог", "травматолог", "акушер-гинеколог", "уролог", "инфекционист", "онколог", "гастроэнтеролог", "кардиолог", "эндокринолог" });
            toolEnterPhoneNumb.SetToolTip(textPhoneNumber, "Ввод цифр без иных символов");

            _presenter = new(this);



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


        private void buttClearSchedule_Click(object sender, EventArgs e)
        {
            //dataGridSchedule.DataSource = null;
            //dataGridSchedule.Rows.Clear();
            //buttShowSchedule.Enabled = true;
        }

        private void buttShowSchedule_Click(object sender, EventArgs e)
        {
            //_schedules = new BindingList<IWorkSchedule>();

            //dataGridSchedule.DataSource = _schedules;

            //if (dataGridSchedule.Columns["DayOfWeek"] != null)
            //    dataGridSchedule.Columns["DayOfWeek"].HeaderText = "День недели";
            //if (dataGridSchedule.Columns["WorkBeginning"] != null)
            //    dataGridSchedule.Columns["WorkBeginning"].HeaderText = "Начало работы";
            //if (dataGridSchedule.Columns["WorkEnd"] != null)
            //    dataGridSchedule.Columns["WorkEnd"].HeaderText = "Конец работы";

            //dataGridSchedule.Columns[0].Width = 200;
            //dataGridSchedule.Columns[1].Width = 180;
            //dataGridSchedule.Columns[2].Width = 180;

            //_schedules.Add(new WorkScheduleOfDoctor() { DayOfWeek = "Пн", WorkBeginning = "1", WorkEnd = "1" });
            //_schedules.Add(new WorkScheduleOfDoctor() { DayOfWeek = "Вт", WorkBeginning = "1", WorkEnd = "1" });
            //_schedules.Add(new WorkScheduleOfDoctor() { DayOfWeek = "Ср", WorkBeginning = "1", WorkEnd = "1" });
            //_schedules.Add(new WorkScheduleOfDoctor() { DayOfWeek = "Чт", WorkBeginning = "1", WorkEnd = "1" });
            //_schedules.Add(new WorkScheduleOfDoctor() { DayOfWeek = "Пт", WorkBeginning = "1", WorkEnd = "1" });
            //_schedules.Add(new WorkScheduleOfDoctor() { DayOfWeek = "Сб", WorkBeginning = "1", WorkEnd = "1" });
            //_schedules.Add(new WorkScheduleOfDoctor() { DayOfWeek = "Вс", WorkBeginning = "1", WorkEnd = "1" });


            //buttShowSchedule.Enabled = false;
        }

        private static bool IsCorrectTime(DateTime timeBeginning, DateTime timeEnd)
        {
            if ((timeEnd.Hour - timeBeginning.Hour < 1) && (timeEnd.Minute - timeBeginning.Minute <= 1))
                return false;
            return true;
        }



        private void buttAddDoctor_Click(object sender, EventArgs e)
        {
            //IList<IWorkSchedule> _workSchedules = new List<IWorkSchedule>();

            bool _isError = false;


            errorNoSurname.Clear();
            errorNoName.Clear();
            errorNoSpecial.Clear();
            errorNoCabinet.Clear();
            errorNoPhoneNumber.Clear();
            errorNoPlotNumber.Clear();
            errorNoDurationOfAppointment.Clear();
            errorNoCorrectTimeMon.Clear();
            errorNoCorrectTimeTues.Clear();
            errorNoCorrectTimeWed.Clear();
            errorNoCorrectTimeThurs.Clear();
            errorNoCorrectTimeFri.Clear();
            errorNoCorrectTimeSat.Clear();
            errorNoCorrectTimeSun.Clear();
            //errorNoSchedule.Clear();


            //for (int rows = 0; rows < dataGridSchedule.Rows.Count; rows++)
            //{
            //    for (int col = 0; col < dataGridSchedule.Rows[rows].Cells.Count; col++)
            //    {
            //        if (dataGridSchedule.Rows[rows].Cells[col].Value.ToString() == null)
            //        {
            //            _isError = true;
            //            errorNoSchedule.SetError(dataGridSchedule, "График работы не заполнен");
            //            break;
            //        }

            //    }
            //}



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

            if (comboBoxSpecializations.SelectedIndex == -1)
            {
                _isError = true;
                errorNoSpecial.SetError(comboBoxSpecializations, "Поле \"Специализация\" не заполнено");
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

            if (textPhoneNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoPhoneNumber.SetError(textPhoneNumber, "Поле \"Номер телефона\" не заполнено");
            }

            if (timeDurationOfAppointment.Value.Hour == DateTime.Now.Hour && timeDurationOfAppointment.Value.Minute == DateTime.Now.Minute)
            {
                _isError = true;
                errorNoDurationOfAppointment.SetError(timeDurationOfAppointment, "Поле \"Продолжительность приёма\" не заполнено");
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
