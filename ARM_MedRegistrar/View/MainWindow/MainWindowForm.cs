using ARM_MedRegistrar.View.Doctors;
using ARM_MedRegistrar.View.MainWindow;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.View;
using ARM_MedRegistrar.View.ChangeDataOfAppointment;
using ARM_MedRegistrar.Presenter;
using ARM_MedRegistrar.View.ChangeDataOfPatient;
using ARM_MedRegistrar.View.AddAppointment;
using ARM_MedRegistrar.View.PaidMedServices;

namespace ARM_MedRegistrar
{
    public partial class MainWindowForm : Form, IMainWindowForm
    {
        Form _form;

        IUserEmployee _employee;

        MainWindowPresenter _presenter;
        int _lineOfListViewPatients;
        int _lineOfListViewAppointments;
        uint IMainWindowForm.PatientId
        {
            set
            {
                listViewPatients.Items.Add(value.ToString());
            }
        }

        int IMainWindowForm.PatientCountOfLine
        {
            set
            {
                _lineOfListViewPatients = value;
            }
        }

        string IMainWindowForm.PatientSurname
        {
            get => textSurname.Text;
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }
        string IMainWindowForm.PatientName
        {
            get => textName.Text;
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }

        string? IMainWindowForm.PatientPatronymic
        {
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }

        DateOnly IMainWindowForm.PatientDateOfBirth
        {
            get => DateOnly.FromDateTime(dateTimeDateOfBirth.Value);
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value.ToString());
            }
        }

        string IMainWindowForm.PatientDocumentSeries
        {

            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }

        string IMainWindowForm.PatientDocumentNumber
        {

            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }
        uint IMainWindowForm.PatientSelectedId
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


        int IMainWindowForm.PatientPlotNumber
        {
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value.ToString());
            }
        }
        string IMainWindowForm.PatientNumbOfPatientCard
        {
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }

        string IMainWindowForm.InfoAboutPatient
        {
            set
            {
                richTextBoxInfoAboutPatient.Text = value;
            }
        }

        uint IMainWindowForm.AppointmentId
        {
            set
            {
                listViewAppointments.Items.Add(value.ToString());
            }
        }

        int IMainWindowForm.AppointmentCountOfLine
        {
            set
            {
                _lineOfListViewAppointments = value;
            }
        }

        DateOnly IMainWindowForm.DateOfAppointment
        {
            get => DateOnly.FromDateTime(dateTimePickerDateOfAppointment.Value);
            set
            {
                listViewAppointments.Items[_lineOfListViewAppointments].SubItems.Add(value.ToString());
            }
        }
        TimeOnly IMainWindowForm.TimeOfAppointment
        {
            set
            {
                listViewAppointments.Items[_lineOfListViewAppointments].SubItems.Add(value.ToString());
            }
        }
        string IMainWindowForm.PlaceOfAppointment
        {
            set
            {
                listViewAppointments.Items[_lineOfListViewAppointments].SubItems.Add(value);
            }
        }

        string IMainWindowForm.AppointmentDoctorSpecialization
        {
            set
            {
                listViewAppointments.Items[_lineOfListViewAppointments].SubItems.Add(value);
            }
        }
        string IMainWindowForm.TypeOfAppointment
        {
            set
            {
                listViewAppointments.Items[_lineOfListViewAppointments].SubItems.Add(value);
            }
        }



        uint IMainWindowForm.AppointmentDoctorId
        {
            set
            {
                listViewAppointments.Items[_lineOfListViewAppointments].SubItems.Add(value.ToString());
            }
        }
        string IMainWindowForm.AppointmentDoctorSurname
        {
            set
            {
                listViewAppointments.Items[_lineOfListViewAppointments].SubItems.Add(value);
            }
        }
        string IMainWindowForm.AppointmentDoctorName
        {
            set
            {
                listViewAppointments.Items[_lineOfListViewAppointments].SubItems.Add(value);
            }
        }
        string? IMainWindowForm.AppointmentDoctorPatronymic
        {
            set
            {
                listViewAppointments.Items[_lineOfListViewAppointments].SubItems.Add(value);
            }
        }


        uint IMainWindowForm.AppointmentPatientId
        {
            set
            {
                listViewAppointments.Items[_lineOfListViewAppointments].SubItems.Add(value.ToString());
            }
        }
        string IMainWindowForm.AppointmentPatientSurname
        {
            set
            {
                listViewAppointments.Items[_lineOfListViewAppointments].SubItems.Add(value);
            }
        }
        string IMainWindowForm.AppointmentPatientName
        {
            set
            {
                listViewAppointments.Items[_lineOfListViewAppointments].SubItems.Add(value);
            }
        }
        string? IMainWindowForm.AppointmentPatientPatronymic
        {
            set
            {
                listViewAppointments.Items[_lineOfListViewAppointments].SubItems.Add(value);
            }
        }

        uint IMainWindowForm.AppointmentSelectedId
        {
            get
            {
                if (listViewAppointments.SelectedItems.Count == 0)
                {
                    return 0;
                }
                return uint.Parse(listViewAppointments.SelectedItems[0].Text);
            }

        }

        string IMainWindowForm.InfoAboutAppointment
        {
            set
            {
                richTextBoxInfoAboutAppointment.Text = value;
            }
        }





        public MainWindowForm(Form form)   //Form form, IUserEmployee employee
        {

            _form = form;
            form.Hide();
            FormClosed += OnClosed;
            InitializeComponent();


            //_employee = employee;
            //textFullNameOfRegistr.Text = _employee.PersonalData.FullName.Surname;         //из файла (данные User)

            toolTipAllDataAboutPatients.SetToolTip(buttAllDataAboutPatient, "Выберите пациента из списка, нажав на его ID. \nЗатем нажмите кнопку");
            toolTipRemovePatient.SetToolTip(buttRemovePatient, "Выберите пациента из списка, нажав на его ID. \nЗатем нажмите кнопку");

            _presenter = new(this);
            //_presenter.ClearFreeAppointments();
        }

        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void buttAddPatient_Click(object sender, EventArgs e)
        {
            AddPatientForm newForm = new();
            newForm.ShowDialog();
        }

        private void buttAttachedStreets_Click(object sender, EventArgs e)
        {
            AttachedStreetsForm attachedStreetsForm = new();
            attachedStreetsForm.ShowDialog();


        }

        private void buttInfoAboutUser_Click(object sender, EventArgs e)
        {
            InfoAboutUserForm infoAboutUserForm = new();
            infoAboutUserForm.ShowDialog();
        }



        private void buttDoctors_Click(object sender, EventArgs e)
        {
            DoctorsForm doctorForm = new(this);
            doctorForm.ShowDialog();
        }

        private void buttAllPatients_Click(object sender, EventArgs e)
        {
            listViewPatients.Items.Clear();
            if (!_presenter.ShowAllPatients())
                MessageBox.Show("Список пациентов пуст");
        }

        private void buttAllDataAboutPatient_Click(object sender, EventArgs e)
        {
            errorMultiSelect.Clear();
            if (!checkIsMultiSelect.Checked)
            {
                richTextBoxInfoAboutPatient.Clear();

                _presenter.ShowInfoAboutPatient();
            }
            else
                errorMultiSelect.SetError(checkIsMultiSelect, "Нельзя выполнить действие, т.к. \nвыбрано несколько пациентов");
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
                errorNoSurname.SetError(textSurname, "Поле \"Фамилия\" не заполнено");
            }

            if (textName.Text == string.Empty)
            {
                _isError = true;
                errorNoName.SetError(textName, "Поле \"Имя\" не заполнено");
            }

            if ((dateTimeDateOfBirth.Value.Day >= DateTime.Today.Day && dateTimeDateOfBirth.Value.Month >= DateTime.Today.Month
                && dateTimeDateOfBirth.Value.Year >= DateTime.Today.Year) || dateTimeDateOfBirth.Value.Year > DateTime.Today.Year)
            {
                _isError = true;
                errorWrongDate.SetError(dateTimeDateOfBirth, "Поле \"Дата рождения\" заполнено неверно");
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

        private void buttRemovePatient_Click(object sender, EventArgs e)
        {
            IList<uint> _selectedId = new List<uint>();
            if (checkIsMultiSelect.Checked)
            {
                if (listViewPatients.SelectedItems.Count != 0)
                {
                    for (int i = 0; i < listViewPatients.SelectedItems.Count; i++)
                    {
                        uint selectItemValue = uint.Parse(listViewPatients.SelectedItems[i].Text);
                        _selectedId.Add(selectItemValue);

                    }

                    string _lineOfId = "";

                    foreach (uint id in _selectedId)
                        _lineOfId += id.ToString() + "  ";

                    DialogResult dialogResult = MessageBox.Show($"Подтвердите действие: удаление пациентов с ID: {_lineOfId}", " ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (_presenter.RemovePatient(_selectedId))
                            MessageBox.Show("Пациенты успешно удалены");
                        else
                            MessageBox.Show("Не удалось удалить пациентов");
                    }

                }
            }


            else
            {
                uint _selIndex = listViewPatients.SelectedItems.Count != 0 ? uint.Parse(listViewPatients.SelectedItems[0].Text) : 0;

                if (_selIndex != 0)
                {
                    DialogResult dialogResult = MessageBox.Show($"Подтвердите действие: удаление пациента с ID: {_selIndex}", " ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _selectedId.Add(_selIndex);
                        if (_presenter.RemovePatient(_selectedId))
                            MessageBox.Show("Пациент успешно удалён");
                        else
                            MessageBox.Show("Не удалось удалить пациента");
                    }
                }
            }
        }

        private void buttChangeData_Click(object sender, EventArgs e)
        {
            ChangeDataOfPatientForm changeDataOfPatientForm = new();
            changeDataOfPatientForm.ShowDialog();

        }

        private void buttAddAppointment_Click(object sender, EventArgs e)
        {
            AddAppointmentForm addAppointmentForm = new();
            addAppointmentForm.ShowDialog();
        }

        private void buttPaidMedServices_Click(object sender, EventArgs e)
        {
            PaidMedServicesForm paidMedServicesForm = new(this);
            paidMedServicesForm.ShowDialog();
        }

        private void checkIsMultiSelect_CheckedChanged_1(object sender, EventArgs e)
        {
            listViewPatients.MultiSelect = true;
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {

        }

        private void buttRemoveAppointment_Click(object sender, EventArgs e)
        {
            IList<uint> _selectedId = new List<uint>();
            if (checkMultiSelectcheckIsMultiSelectAppointments.Checked)
            {
                if (listViewAppointments.SelectedItems.Count != 0)
                {
                    for (int i = 0; i < listViewAppointments.SelectedItems.Count; i++)
                    {
                        uint selectItemValue = uint.Parse(listViewAppointments.SelectedItems[i].Text);
                        _selectedId.Add(selectItemValue);

                    }

                    string _lineOfId = "";

                    foreach (uint id in _selectedId)
                        _lineOfId += id.ToString() + "  ";

                    DialogResult dialogResult = MessageBox.Show($"Подтвердите действие: удаление записей с ID: {_lineOfId}", " ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (_presenter.RemoveAppointment(_selectedId))
                            MessageBox.Show("Записи успешно удалены");
                        else
                            MessageBox.Show("Не удалось удалить записи");
                    }

                }
            }
            else
            {
                uint _selIndex = listViewAppointments.SelectedItems.Count != 0 ? uint.Parse(listViewAppointments.SelectedItems[0].Text) : 0;

                if (_selIndex != 0)
                {
                    DialogResult dialogResult = MessageBox.Show($"Подтвердите действие: удаление записи с ID: {_selIndex}", " ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _selectedId.Add(_selIndex);
                        if (_presenter.RemoveAppointment(_selectedId))
                            MessageBox.Show("Запись успешно удалена");
                        else
                            MessageBox.Show("Не удалось удалить запись");
                    }
                }
            }
        }

        private void checkMultiSelectcheckIsMultiSelectAppointments_CheckedChanged(object sender, EventArgs e)
        {
            listViewAppointments.MultiSelect = true;
        }

        private void buttSearchAppointment_Click(object sender, EventArgs e)
        {
            listViewAppointments.Items.Clear();

            if (!_presenter.SearchAppointment())
                MessageBox.Show("Записи не найдены");

            dateTimeDateOfBirth.Value = DateTime.Today;

        }

        private void buttAllAppointments_Click(object sender, EventArgs e)
        {
            listViewAppointments.Items.Clear();
            if (!_presenter.ShowAllAppointments())
                MessageBox.Show("Список записей пуст");
        }

        private void buttAllDataAboutAppointment_Click(object sender, EventArgs e)
        {
            errorMultiSelect.Clear();
            if (!checkMultiSelectcheckIsMultiSelectAppointments.Checked)
            {
                richTextBoxInfoAboutAppointment.Clear();

                _presenter.ShowInfoAboutAppointment();
            }
            else
                errorMultiSelect.SetError(checkMultiSelectcheckIsMultiSelectAppointments, "Нельзя выполнить действие, т.к. \nвыбрано несколько записей");
        }

        private void buttChangeDataOfAppointment_Click(object sender, EventArgs e)
        {
            ChangeDataOfAppointmentForm changeDataOfAppointmentForm = new();
            changeDataOfAppointmentForm.ShowDialog();
        }
    }
}
