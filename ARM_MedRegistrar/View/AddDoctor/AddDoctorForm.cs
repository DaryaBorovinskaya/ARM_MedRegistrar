
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.View.AddDoctor;
using ARM_MedRegistrar.Presenter;
using Newtonsoft.Json;

namespace ARM_MedRegistrar
{
    public partial class AddDoctorForm : Form, IAddDoctorForm
    {
        AddDoctorPresenter _presenter;
        string IAddDoctorForm.Surname => textSurname.Text;

        string IAddDoctorForm.Name => textName.Text;

        string? IAddDoctorForm.Patronymic => textPatr.Text;

        string IAddDoctorForm.Specializations => comboBoxSpecializations.SelectedItem.ToString();

        string IAddDoctorForm.PhoneNumber => textPhoneNumber.Text;

        int IAddDoctorForm.PlotNumber => (int)numericPlotNumber.Value;

        int IAddDoctorForm.Cabinet => (int)numericCabinet.Value;

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



        private void numericPlotNumber_ValueChanged(object sender, EventArgs e)
        {
            numericPlotNumber.Maximum = 5000;

        }

        private void numericCabinet_ValueChanged(object sender, EventArgs e)
        {
            numericCabinet.Maximum = 5000;

        }

        private void buttAddDoctor_Click(object sender, EventArgs e)
        {


            bool _isError = false;

            errorNoSurname.Clear();
            errorNoName.Clear();
            errorNoSpecial.Clear();
            errorNoPlotNumber.Clear();
            errorNoCabinet.Clear();
            errorNoPhoneNumber.Clear();


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

            if (numericPlotNumber.Value == 0)
            {
                _isError = true;
                errorNoPlotNumber.SetError(numericPlotNumber, "Поле \"Номер участка\" не заполнено");
            }

            if (numericCabinet.Value == 0)
            {
                _isError = true;
                errorNoCabinet.SetError(numericCabinet, "Поле \"Номер кабинета\" не заполнено");
            }

            if (textPhoneNumber.Text != string.Empty)
            {
                _isError = true;
                errorNoPhoneNumber.SetError(textPhoneNumber, "Поле \"Номер телефона\" не заполнено");
            }

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
                    numericPlotNumber.Value = 0;
                    numericCabinet.Value = 0;
                    textPhoneNumber.Clear();

                }

                MessageBox.Show("Добавление врача успешно выполнено!");
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
