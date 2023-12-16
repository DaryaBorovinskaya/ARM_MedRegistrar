using ARM_MedRegistrar.View;
using ARM_MedRegistrar.View.MainWindow;
using ARM_MedRegistrar.Model.Persons;

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

            AddDoctorForm newForm = new();
            newForm.ShowDialog();


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
    }
}
