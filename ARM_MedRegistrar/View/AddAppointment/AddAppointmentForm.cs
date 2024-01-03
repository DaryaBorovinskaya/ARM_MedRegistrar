
using ARM_MedRegistrar.Presenter;
using ARM_MedRegistrar.View.MainWindow;
using Newtonsoft.Json.Linq;

namespace ARM_MedRegistrar.View.AddAppointment
{
    public partial class AddAppointmentForm : Form, IAddAppointmentForm
    {
        Form form;
        int _lineOfListViewDoctors;
        int _lineOfListViewPatients;
        AddAppointmentPresenter _presenter;
        uint IAddAppointmentForm.DoctorId
        {

            set
            {
                listViewDoctors.Items.Add(value.ToString());
            }
        }
        int IAddAppointmentForm.DoctorCountOfLine
        {
            set
            {
                _lineOfListViewDoctors = value;
            }
        }
        string IAddAppointmentForm.DoctorSurname
        {

            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }
        string IAddAppointmentForm.DoctorName
        {

            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }
        string? IAddAppointmentForm.DoctorPatronymic
        {
            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }
        string IAddAppointmentForm.DoctorSpecialization
        {
            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }
        string IAddAppointmentForm.DoctorWorkSchedule
        {
            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }

        int IAddAppointmentForm.DoctorPlotNumber
        {
            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }
        int IAddAppointmentForm.DoctorCabinet
        {
            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }

        uint IAddAppointmentForm.DoctorSelectedId
        {
            get
            {
                if (listViewDoctors.SelectedItems.Count == 0)
                {
                    return 0;
                }
                return uint.Parse(listViewDoctors.SelectedItems[0].Text);
            }
        }

        string IAddAppointmentForm.GetFreeTimeOfAppointment => comboBoxFreeTimeOfAppointment.SelectedItem.ToString();

        IList<string> IAddAppointmentForm.SetFreeTimeOfAppointment
        {
            set
            {
                comboBoxFreeTimeOfAppointment.Items.AddRange(value.ToArray());
            }
        }

        string IAddAppointmentForm.InfoAboutDoctor
        {
            set
            {
                richTextBoxInfoAboutDoctor.Text = value;
            }
        }

        uint IAddAppointmentForm.PatientId
        {
            set
            {
                listViewPatients.Items.Add(value.ToString());
            }
        }
        int IAddAppointmentForm.PatientCountOfLine
        {
            set
            {
                _lineOfListViewPatients = value;
            }
        }

        string IAddAppointmentForm.PatientSurname
        {
            get => textSurname.Text;
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }
        string IAddAppointmentForm.PatientName
        {
            get => textName.Text;
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }
        string? IAddAppointmentForm.PatientPatronymic
        {
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }
        DateOnly IAddAppointmentForm.PatientDateOfBirth
        {
            get => DateOnly.FromDateTime(dateTimeDateOfBirth.Value);
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value.ToString());
            }
        }

        uint IAddAppointmentForm.PatientSelectedId
        {
            get
            {
                if (listViewPatients.SelectedItems.Count == 0)
                {
                    return 0;
                }
                return uint.Parse(listViewPatients.SelectedItems[0].Text);
            }
        }

        DateOnly IAddAppointmentForm.DayOfAppointment => DateOnly.FromDateTime(dateTimePickerDateOfAppointment.Value);

        string IAddAppointmentForm.GetTypeOfAppointment => comboBoxTypeOfAppointment.SelectedItem.ToString();

        string IAddAppointmentForm.PlaceOfAppointment
        {
            get => textPlace.Text;
            set
            {
                textPlace.Text = value;
            }
        }

        string IAddAppointmentForm.InfoAboutPatient
        {
            set
            {
                richTextBoxInfoAboutPatient.Text = value;
            }
        }

        public AddAppointmentForm()
        {
            InitializeComponent();

            comboBoxTypeOfAppointment.Items.AddRange(new string[] { "Первичный приём у врача", "Вторичный приём у врача", "Вызов на дом" });
            toolTipShowFreeTimeOfAppointment.SetToolTip(buttShowFreeTimeOfAppointment, "Выберите врача из списка, нажав на его ID. \nЗатем нажмите кнопку и выберите нужное время записи\nв списке ниже");
            _presenter = new(this);

        }


        private void buttAllPatients_Click(object sender, EventArgs e)
        {
            listViewPatients.Items.Clear();
            if (!_presenter.ShowAllPatients())
                MessageBox.Show("Список пациентов пуст");
        }

        private void buttAllDoctors_Click(object sender, EventArgs e)
        {
            buttShowFreeTimeOfAppointment.Enabled = false;
            listViewDoctors.Items.Clear();
            if (!_presenter.ShowAllDoctors())
                MessageBox.Show("Список врачей пуст");
        }

        private void buttWorkingDoctors_Click(object sender, EventArgs e)
        {
            DateTime _dateFutureTime = DateTime.Today;
            if (_dateFutureTime.Month == 12)
                _dateFutureTime = new DateTime(_dateFutureTime.Year + 1, 1, _dateFutureTime.Day, 0, 0, 0);
            else
                _dateFutureTime = new DateTime(_dateFutureTime.Year, (_dateFutureTime.Month + 1) % 12, _dateFutureTime.Day, 0, 0, 0);

            errorWrongDate.Clear();

            if (dateTimePickerDateOfAppointment.Value.Date < DateTime.Today)
                errorWrongDate.SetError(dateTimePickerDateOfAppointment, "Нельзя записать на приём в прошедший день");
            else if (dateTimePickerDateOfAppointment.Value.Date > _dateFutureTime)
                errorWrongDate.SetError(dateTimePickerDateOfAppointment, "Нельзя записать на приём позже, чем через месяц");
            else
            {
                listViewDoctors.Items.Clear();
                buttShowFreeTimeOfAppointment.Enabled = true;

                if (!_presenter.WorkingDoctors())
                    MessageBox.Show("В указанные день и время ни один из врачей не имеет свободной записи");
            }
        }

        private void buttShowFreeTimeOfAppointment_Click(object sender, EventArgs e)
        {
            comboBoxFreeTimeOfAppointment.Items.Clear();
            if (!_presenter.ShowFreeTimeOfAppointment())
                MessageBox.Show("Врач не имеет свободной записи на этот день");
        }

        private void buttAllDataAboutDoctor_Click(object sender, EventArgs e)
        {
            richTextBoxInfoAboutDoctor.Clear();
            _presenter.ShowInfoAboutDoctor();
        }

        private void comboBoxFreeTimeOfAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTypeOfAppointment.Enabled = true;
        }

        private void buttSearchPatient_Click(object sender, EventArgs e)
        {
            listViewPatients.Items.Clear();
            bool _isError = false;

            errorNoSurname.Clear();
            errorNoName.Clear();
            errorWrongDate.Clear();

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

            if ((dateTimeDateOfBirth.Value.Day >= DateTime.Today.Day && dateTimeDateOfBirth.Value.Month >= DateTime.Today.Month
                && dateTimeDateOfBirth.Value.Year >= DateTime.Today.Year) || dateTimeDateOfBirth.Value.Year > DateTime.Today.Year)
            {
                _isError = true;
                errorWrongDate.SetError(dateTimeDateOfBirth, "Поле заполнено неверно");
            }

            if (!_isError)
            {
                if (!_presenter.SearchPatient())
                    MessageBox.Show("Пациент не найден");
                textSurname.Clear();
                textName.Clear();
                textPatr.Clear();
                dateTimeDateOfBirth.Value = DateTime.Today;
            }
        }

        private void comboBoxTypeOfAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {

            bool _isError = false;
            errorNoSelectedPatient.Clear();
            errorWrongDoctor.Clear();

            uint _selIndex = listViewPatients.SelectedItems.Count != 0 ? uint.Parse(listViewPatients.SelectedItems[0].Text) : 0;

            if (_selIndex == 0)
            {
                _isError = true;
                errorNoSelectedPatient.SetError(listViewPatients, "Сначала выберите пациента из списка, нажав на его ID");

            }
            if (!_presenter.IsDoctorCanTakeAtHome())
            {
                _isError = true;
                errorWrongDoctor.SetError(listViewDoctors, "Этот врач не принимает на дому");

            }


            if (!_isError)
            {

                if (!_presenter.GetPlaseOfAppointment())
                    MessageBox.Show("Не удалось получить место приёма");

                buttAddAppointment.Enabled = true;
            }

        }

        private void buttSaveChanges_Click(object sender, EventArgs e)
        {
            errorNoPlace.Clear();
            if (textPlace.Text == string.Empty)
                errorNoPlace.SetError(textPlace, "Поле не заполнено");
            else
            {
                if (!_presenter.SaveChangesOfPlaceOfAppointment())
                    MessageBox.Show("Не удалось сохранить изменения");
                else
                {
                    MessageBox.Show("Изменения в поле сохранены");
                    textPlace.Enabled = false;
                    buttAddAppointment.Enabled = true;
                }
            }
        }



        private void buttAllDataAboutPatient_Click(object sender, EventArgs e)
        {
            richTextBoxInfoAboutPatient.Clear();

            _presenter.ShowInfoAboutPatient();
        }

        private void buttChange_Click(object sender, EventArgs e)
        {
            textPlace.Enabled = true;
            buttAddAppointment.Enabled = false;
        }

        private void buttAddAppointment_Click(object sender, EventArgs e)
        {
            if (!_presenter.AddAppointment())
                MessageBox.Show("Не удалось добавить запись на приём");
            else
            {
                MessageBox.Show("Добавление записи успешно выполнено!");
                if (!checkNoCloseWindow.Checked)
                    Close();
                else
                {
                    listViewDoctors.Clear();
                    listViewPatients.Clear();
                    textSurname.Clear();
                    textName.Clear();
                    textPatr.Clear();
                    dateTimeDateOfBirth.Value = DateTime.Now;
                    dateTimePickerDateOfAppointment.Value = DateTime.Now;
                    richTextBoxInfoAboutDoctor.Clear();
                    richTextBoxInfoAboutPatient.Clear();
                    textPlace.Clear();
                    comboBoxTypeOfAppointment.SelectedIndex = 0;
                }
            }
        }
    }
}
