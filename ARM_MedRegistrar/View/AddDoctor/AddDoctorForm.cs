
using ARM_MedRegistrar.Model.EnteringNumbersInStringType;
using ARM_MedRegistrar.Model.Persons;
using Newtonsoft.Json;

namespace ARM_MedRegistrar
{
    public partial class AddDoctorForm : Form
    {


        public AddDoctorForm()
        {

            InitializeComponent();
            comboBoxSpecializations.Items.AddRange(new string[] { "терапевт", "педиатр", "врач общей практики", "хирург", "невролог", "оториноларинголог", "офтальмолог", "травматолог", "акушер-гинеколог", "уролог", "инфекционист", "онколог", "гастроэнтеролог", "кардиолог", "эндокринолог" });
            toolEnterPhoneNumb.SetToolTip(textPhoneNumber, "Ввод цифр без иных символов");
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
            FullName _fullName;
            Doctor _newDoctor;

            bool _isError = false;

            listBox1.Items.Clear();
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
                _fullName = new(textSurname.Text, textName.Text, textName.Text);
                _newDoctor = new(_fullName, textPhoneNumber.Text, comboBoxSpecializations.SelectedItem.ToString(), (int)numericPlotNumber.Value, (int)numericCabinet.Value);


                //JsonDoctorRepository jsonDoctorRepository = new("doctors.json");
                //jsonDoctorRepository.Add(_newDoctor);

                //IList<IDoctor>? _printDoctors = jsonDoctorRepository.GetAll();
                //foreach (var item in _printDoctors)
                //    listBox1.Items.Add(item.FullName.Name);


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

        
    }
}
