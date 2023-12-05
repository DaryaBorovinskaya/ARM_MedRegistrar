using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARM_MedRegistrar.Model.Lists;
using ARM_MedRegistrar.Model.Persons;

namespace ARM_MedRegistrar
{
    public partial class AddDoctor : Form
    {


        public AddDoctor()
        {

            InitializeComponent();

        }




        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }


        private void AddDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            GroupOfDoctors _groupOfDoctors;

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
                _newDoctor = new(_fullName, (string)comboBoxSpecializations.SelectedItem, (int)numericPlotNumber.Value, (int)numericCabinet.Value);
                _groupOfDoctors = new GroupOfDoctors();
                _groupOfDoctors._doctors.Add(_newDoctor);
                MessageBox.Show("Добавление врача успешно выполнено!");
                Close();
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
    }
}
