using ARM_MedRegistrar.View.Doctors;
using ARM_MedRegistrar.View.MainWindow;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.View;
using ARM_MedRegistrar.View.InfoAboutUser;
using ARM_MedRegistrar.View.AttachedToTheClinicStreets;
using ARM_MedRegistrar.Model.Patients;
using ARM_MedRegistrar.Data.Json.Dictionaries.PatientRepository;
using ARM_MedRegistrar.Presenter;
using ARM_MedRegistrar.View.ChangeDataOfPatient;

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
            get => textPatr.Text;
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
            get => textDocumentSeries.Text;
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }

        string IMainWindowForm.DocumentNumber
        {
            get => textDocumentNumber.Text;
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
            DialogResult = DialogResult.Cancel;

            FormClosed += OnClosed;

            _employee = employee;
            textFullNameOfRegistr.Text = _employee.FullName.Surname;         //из файла (данные User)

            toolTipAllDataAboutPatients.SetToolTip(buttAllDataAboutPatient, "Выберите пациента из списка, нажав на его ID. \nЗатем нажмите кнопку");
            toolTipRemovePatient.SetToolTip(buttRemovePatient, "Выберите пациента из списка, нажав на его ID. \nЗатем нажмите кнопку");
            toolTipSaveData.SetToolTip(buttChangeData, "Нажмите, чтобы ");

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






        private void buttAddresses_Click(object sender, EventArgs e)
        {

            AttachedStreetsForm newForm = new();
            newForm.ShowDialog();


        }

        private void buttInfoAboutUser_Click(object sender, EventArgs e)
        {
            InfoAboutUserForm newForm = new(_employee);
            newForm.ShowDialog();
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
            richTextBoxInfoAboutPatient.Clear();

            _presenter.ShowInfoAboutPatient();
        }

        private void buttSearchPatient_Click(object sender, EventArgs e)
        {
            listViewPatients.Items.Clear();
            bool _isError = false;

            errorNoSurname.Clear();
            errorNoName.Clear();
            errorWrongDate.Clear();
            errorNoDocumentSeries.Clear();
            errorNoDocumentNumber.Clear();

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

            if (textDocumentSeries.Text == string.Empty)
            {
                _isError = true;
                errorNoDocumentSeries.SetError(textDocumentSeries, "Поле \"Серия документа\" не заполнено");
            }

            if (textDocumentNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoDocumentNumber.SetError(textDocumentNumber, "Поле \"Номер документа\" не заполнено");
            }

            if (!_isError)
            {
                if (!_presenter.SearchPatient())
                    MessageBox.Show("Пациент не найден");
            }


        }

        private void buttRemovePatient_Click(object sender, EventArgs e)
        {
            uint _selIndex = listViewPatients.SelectedItems.Count != 0 ? uint.Parse(listViewPatients.SelectedItems[0].Text) : 0;

            if (_selIndex != 0)
            {
                DialogResult dialogResult = MessageBox.Show($"Подтвердите действие: удаление пациента с ID: {_selIndex}", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _presenter.RemovePatient();
                    MessageBox.Show("Пациент успешно удалён");
                }
            }
        }

        private void buttChangeData_Click(object sender, EventArgs e)
        {
            ChangeDataOfPatientForm changeDataOfPatientForm = new();
            changeDataOfPatientForm.ShowDialog();

        }
    }
}
