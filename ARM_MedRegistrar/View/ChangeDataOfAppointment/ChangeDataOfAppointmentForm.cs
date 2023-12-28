using ARM_MedRegistrar.Presenter;

namespace ARM_MedRegistrar.View.ChangeDataOfAppointment
{
    public partial class ChangeDataOfAppointmentForm : Form, IChangeDataOfAppointmentForm
    {
        ChangeDataOfAppointmentPresenter _presenter;

        uint IChangeDataOfAppointmentForm.AppointmentId => uint.Parse(textId.Text);

        DateOnly IChangeDataOfAppointmentForm.DateOfAppointment
        {
            get => DateOnly.FromDateTime(dateTimePickerDateOfAppointment.Value);
            set
            {
                dateTimePickerDateOfAppointment.Value = new DateTime(value.Year, value.Month, value.Day);
            }
        }
        string IChangeDataOfAppointmentForm.FreeTimeOfAppointment
        {
            get => comboBoxFreeTimeOfAppointment.SelectedItem.ToString();
            set
            {
                textTimeOfAppointment.Text = value;
            }
        }

        IList<string> IChangeDataOfAppointmentForm.SetFreeTimeOfAppointments
        {
            set
            {
                comboBoxFreeTimeOfAppointment.Items.AddRange(value.ToArray());
            }
        }
        uint IChangeDataOfAppointmentForm.DoctorId
        {
            get => uint.Parse(textDoctorId.Text);
            set
            {
                textDoctorId.Text = value.ToString();
            }
        }
        string IChangeDataOfAppointmentForm.DoctorFullName
        {
            set
            {
                textDoctorFullName.Text = value;
            }
        }
        uint IChangeDataOfAppointmentForm.PatientId
        {
            set
            {
                textPatientId.Text = value.ToString();
            }
        }
        string IChangeDataOfAppointmentForm.PatientFullName
        {
            set
            {
                textPatientFullName.Text = value;
            }
        }
        string IChangeDataOfAppointmentForm.TypeOfAppointment
        {
            get => comboBoxTypeOfAppointment.SelectedItem.ToString();
            set
            {
                comboBoxTypeOfAppointment.SelectedItem = value;
            }
        }
        string IChangeDataOfAppointmentForm.Place
        {
            get => textPlace.Text;
            set
            {
                textPlace.Text = value;
            }
        }

        public ChangeDataOfAppointmentForm()
        {
            InitializeComponent();
            _presenter = new(this);
            comboBoxTypeOfAppointment.Items.AddRange(_presenter.SetTypeOfAppointment().ToArray());
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
                if (!_presenter.ShowDataAboutAppointment())
                {
                    textId.ReadOnly = false;
                    MessageBox.Show($"Не удалось найти запись с ID: {textId.Text}");
                }
                else
                    textId.ReadOnly = true;
            }
        }

        private void buttSaveChanges_Click(object sender, EventArgs e)
        {
            buttSaveChanges.Enabled = false;
            bool _isError = false;

            errorNoPlace.Clear();
            errorWrongDate.Clear();

            if (textPlace.Text == string.Empty)
            {
                _isError = true;
                errorNoPlace.SetError(textPlace, "Поле не заполнено");
            }

            DateTime _dateFutureTime = DateTime.Today;
            if (_dateFutureTime.Month == 12)
                _dateFutureTime = new DateTime(_dateFutureTime.Year + 1, 1, _dateFutureTime.Day, 0, 0, 0);
            else
                _dateFutureTime = new DateTime(_dateFutureTime.Year, (_dateFutureTime.Month + 1) % 12, _dateFutureTime.Day, 0, 0, 0);


            if (dateTimePickerDateOfAppointment.Value.Date < DateTime.Today)
            {
                _isError = true;
                errorWrongDate.SetError(dateTimePickerDateOfAppointment, "Нельзя записать на приём в прошедший день");
            }
            if (dateTimePickerDateOfAppointment.Value.Date > _dateFutureTime)
            {
                _isError = true;
                errorWrongDate.SetError(dateTimePickerDateOfAppointment, "Нельзя записать на приём позже, чем через месяц");
            }

            if (!_isError)
            {
                if (_presenter.SaveChanges())
                {
                    MessageBox.Show("Данные записи успешно изменены");

                    textId.ReadOnly = false;
                    if (!checkNoCloseWindow.Checked)
                        Close();
                    else
                    {
                        textId.Clear();
                        dateTimePickerDateOfAppointment.Value = DateTime.Today;
                        comboBoxFreeTimeOfAppointment.Items.Clear();
                        textDoctorId.Clear();
                        textPatientId.Clear();
                        textPatientFullName.Clear();
                        textDoctorFullName.Clear();
                        comboBoxTypeOfAppointment.SelectedIndex = 0;
                        textPlace.Clear();
                    }
                }
                else
                    MessageBox.Show("Не удалось внести изменения");
            }
        }

        private void comboBoxTypeOfAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_presenter.IsDoctorCanTakeAtHome())
            {
                errorWrongDoctor.SetError(textDoctorFullName, "Этот врач не принимает на дому");
                buttSaveChanges.Enabled = false;
            }
            else
                buttSaveChanges.Enabled = true;
        }
    }
}
