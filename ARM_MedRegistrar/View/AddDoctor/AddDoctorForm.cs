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
        private BindingList<IWorkSchedule> _schedules;
        AddDoctorPresenter _presenter;
        string IAddDoctorForm.Surname => textSurname.Text;

        string IAddDoctorForm.Name => textName.Text;

        string? IAddDoctorForm.Patronymic => textPatr.Text;

        string IAddDoctorForm.Specializations => comboBoxSpecializations.SelectedItem.ToString();

        string IAddDoctorForm.PhoneNumber => textPhoneNumber.Text;

        int IAddDoctorForm.PlotNumber => int.Parse(textPlotNumber.Text);

        int IAddDoctorForm.Cabinet => int.Parse(textCabinet.Text);

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
                    _newTextOfTextBox = _newTextOfTextBox.Remove(0, 1);
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

            textPhoneNumber.Text = textBoxWithoutNullInBeginning(textPhoneNumber);
            textPlotNumber.Text = textBoxWithoutNullInBeginning(textPlotNumber);
            textCabinet.Text = textBoxWithoutNullInBeginning(textCabinet);



            if (!_isError)
            {

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

                }

                MessageBox.Show("Добавление врача успешно выполнено!");
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }




}
