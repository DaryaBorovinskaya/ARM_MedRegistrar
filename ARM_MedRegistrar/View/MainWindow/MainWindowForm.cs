using ARM_MedRegistrar.View.Doctors;
using ARM_MedRegistrar.View.MainWindow;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.View;
using ARM_MedRegistrar.View.InfoAboutUser;
using ARM_MedRegistrar.View.AttachedToTheClinicStreets;
using ARM_MedRegistrar.Model.Persons.Patients;
using ARM_MedRegistrar.Data.Json.Dictionaries.PatientRepository;
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
        uint IMainWindowForm.Id
        {
            set
            {
                listViewPatients.Items.Add(value.ToString());
            }
        }

        int IMainWindowForm.CountOfLine
        {
            set
            {
                _lineOfListViewPatients = value;
            }
        }

        string IMainWindowForm.Surname
        {
            get => textSurname.Text;
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }
        string IMainWindowForm.Name
        {
            get => textName.Text;
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }

        string? IMainWindowForm.Patronymic
        {
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }

        string IMainWindowForm.DateOfBirth
        {
            get => dateTimeDateOfBirth.Value.ToShortDateString();
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }

        string IMainWindowForm.DocumentSeries
        {

            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }

        string IMainWindowForm.DocumentNumber
        {

            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }
        uint IMainWindowForm.SelectedId
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


        int IMainWindowForm.PlotNumber
        {
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value.ToString());
            }
        }
        string IMainWindowForm.NumbOfPatientCard
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

        public MainWindowForm(Form form, IUserEmployee employee)
        {

            _form = form;
            form.Hide();

            InitializeComponent();
            

            FormClosed += OnClosed;

            _employee = employee;
            textFullNameOfRegistr.Text = _employee.FullName.Surname;         //из файла (данные User)

            toolTipAllDataAboutPatients.SetToolTip(buttAllDataAboutPatient, "Выберите пациента из списка, нажав на его ID. \nЗатем нажмите кнопку");
            toolTipRemovePatient.SetToolTip(buttRemovePatient, "Выберите пациента из списка, нажав на его ID. \nЗатем нажмите кнопку");

            _presenter = new(this);

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
            InfoAboutUserForm infoAboutUserForm = new(_employee);
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
    }
}
