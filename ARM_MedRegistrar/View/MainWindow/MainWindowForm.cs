using ARM_MedRegistrar.View.Doctors;
using ARM_MedRegistrar.View.MainWindow;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.View;
using ARM_MedRegistrar.View.InfoAboutUser;
using ARM_MedRegistrar.View.AttachedToTheClinicStreets;

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

        private void textFullNameOfRegistr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttRemoveDoctor_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttSearchAppointment_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttDoctors_Click(object sender, EventArgs e)
        {
            DoctorsForm doctorForm = new(this);
            doctorForm.ShowDialog();
        }


    }
}
