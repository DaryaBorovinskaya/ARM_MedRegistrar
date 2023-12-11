using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARM_MedRegistrar.Model.Json.JsonRepository;
using ARM_MedRegistrar.Model.Lists;
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
        }


        private void textSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void textPatr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }


        //private void AddDoctor_Load(object sender, EventArgs e)
        //{

        //}


        //private void AddDoctor_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    e.Cancel = true;
        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textName_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void label2_Click(object sender, EventArgs e)
        //{

        //}

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

            listBox1.Items.Clear();
            errorNoSurname.Clear();
            errorNoName.Clear();
            errorNoSpecial.Clear();
            errorNoPlotNumber.Clear();
            errorNoCabinet.Clear();

            if (comboBoxSpecializations.SelectedIndex != -1 && textSurname.Text != string.Empty
                && textName.Text != string.Empty && numericPlotNumber.Value != 0
                && numericCabinet.Value != 0)

            {
                _fullName = new(textSurname.Text, textName.Text, textName.Text);
                _newDoctor = new(_fullName, comboBoxSpecializations.SelectedItem.ToString(), (int)numericPlotNumber.Value, (int)numericCabinet.Value);


                JsonDoctorRepository jsonDoctorRepository = new("doctors.json");
                jsonDoctorRepository.Add(_newDoctor);

                IList<IDoctor>? _printDoctors = jsonDoctorRepository.GetAll();
                foreach (var item in _printDoctors)
                    listBox1.Items.Add(item.FullName.Name);


                if (!checkNoCloseWindow.Checked)
                    Close();
                else
                {
                    textSurname.Clear();
                    textName.Clear();
                    textPatr.Clear();
                    numericPlotNumber.Value = 0;
                    numericCabinet.Value = 0;

                }

                MessageBox.Show("Добавление врача успешно выполнено!");

            }

            else
            {
                if (textSurname.Text == string.Empty)
                    errorNoSurname.SetError(textSurname, "Поле \"Фамилия\" не заполнено");

                if (textName.Text == string.Empty)
                    errorNoName.SetError(textName, "Поле \"Имя\" не заполнено");

                if (comboBoxSpecializations.SelectedIndex == -1)
                    errorNoSpecial.SetError(comboBoxSpecializations, "Поле \"Специализация\" не заполнено");

                if (numericPlotNumber.Value == 0)
                    errorNoPlotNumber.SetError(numericPlotNumber, "Поле \"Номер участка\" не заполнено");

                if (numericCabinet.Value == 0)
                    errorNoCabinet.SetError(numericCabinet, "Поле \"Номер кабинета\" не заполнено");
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSpecializations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
