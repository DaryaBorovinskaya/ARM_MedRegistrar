
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


        private void buttAddDoctor_Click(object sender, EventArgs e)
        {


            bool _isError = false;

            errorNoSurname.Clear();
            errorNoName.Clear();
            errorNoSpecial.Clear();
            errorNoCabinet.Clear();
            errorNoPhoneNumber.Clear();
            errorNoPlotNumber.Clear();


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
