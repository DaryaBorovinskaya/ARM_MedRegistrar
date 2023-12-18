using ARM_MedRegistrar.View.Doctors;
using ARM_MedRegistrar.View.MainWindow;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.View;
using ARM_MedRegistrar.View.InfoAboutUser;
using ARM_MedRegistrar.View.AttachedToTheClinicStreets;
using ARM_MedRegistrar.Model.Patients;
using ARM_MedRegistrar.Data.Json.Dictionaries.PatientRepository;

namespace ARM_MedRegistrar
{
    public partial class MainWindowForm : Form, IMainWindowForm
    {
        Form _form;

        IUserEmployee _employee;
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
        }

        private void textBox_SpacePress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == (int)Keys.Space)
                ch = '\0';
        }

        private void textBox_ContainsExceptNumbers(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)     //(8 - это Backspace)
                ch = '\0';

        }
        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }




        private void buttAddPatient_Click(object sender, EventArgs e)
        {

            AddPatientForm newForm = new();
            newForm.ShowDialog();


        }

        private void buttAddDoctor_Click(object sender, EventArgs e)
        {




        }


        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }




        private void buttAddresses_Click(object sender, EventArgs e)
        {

            AttachedStreetsForm newForm = new();
            newForm.ShowDialog();


        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {

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
            IPatientRepository _patientRepository = new JsonPatientRepository("patients.json");
            SortedDictionary<uint, IPatient>? _patients = _patientRepository.GetAll();
            int line = 0;
            if (_patients != null && _patients.Count != 0)
                foreach (IPatient patient in _patients.Values)
                {
                    listViewPatients.Items.Add(patient.Id.ToString());
                    listViewPatients.Items[line].SubItems.Add(patient.FullName.Surname.ToString());
                    listViewPatients.Items[line].SubItems.Add(patient.FullName.Name.ToString());
                    listViewPatients.Items[line].SubItems.Add(patient.FullName.Patronymic.ToString());
                    listViewPatients.Items[line].SubItems.Add(patient.DateOfBirth);
                    listViewPatients.Items[line].SubItems.Add(patient.PlotNumber.ToString());
                    listViewPatients.Items[line].SubItems.Add(patient.NumbOfPatientCard.ToString());
                    line++;
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
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            IPatientRepository _patientRepository = new JsonPatientRepository("patients.json");
            SortedDictionary<uint, IPatient>? _patients = _patientRepository.GetAll();
            if (uint.Parse(listViewPatients.SelectedItems[0].Text) != 0)
            richTextBox1.Text = _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].Id
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].FullName.Surname
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].FullName.Name
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].FullName.Patronymic
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].DateOfBirth
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].Address.City
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].Address.Region
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].Address.Street
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].Address.NumbOfHouse
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].Address.NumbOfFlat
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].PlotNumber
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].NumbOfPatientCard
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].PolicySeries
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].PolicyNumb
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].DocumentSeries
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].DocumentNumber
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].BloodType
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].RhFactor
                + "\n" + _patients[uint.Parse(listViewPatients.SelectedItems[0].Text)].Allergies;
        }
    }
}
