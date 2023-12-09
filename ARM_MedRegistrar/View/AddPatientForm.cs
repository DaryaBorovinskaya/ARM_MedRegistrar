using ARM_MedRegistrar.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.Lists;
using ARM_MedRegistrar.Model.Persons;

namespace ARM_MedRegistrar
{
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
        {

            InitializeComponent();

        }

        //private void AddPatient_Load(object sender, EventArgs e)
        //{

        //}
        //private void AddPatient_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    e.Cancel = true;
        //}

        //private void textSurname_TextChanged(object sender, EventArgs e)
        //{

        //}



        //private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        //{

        //}

        //private void label9_Click(object sender, EventArgs e)
        //{

        //}

        //private void comboBoxBloodType_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void label11_Click(object sender, EventArgs e)
        //{

        //}

        //private void listBoxAllergies_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void numericNumbOfHouse_ValueChanged(object sender, EventArgs e)
        {
            numericNumbOfFlat.Minimum = 0;
            numericNumbOfFlat.Maximum = 5000;
        }

        private void numericNumbOfFlat_ValueChanged(object sender, EventArgs e)
        {

            numericNumbOfFlat.Maximum = 5000;
        }

        //private void label16_Click(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void numericPolicySeries_ValueChanged(object sender, EventArgs e)
        {
            numericPolicySeries.Maximum = 9999;
        }

        //private void label8_Click(object sender, EventArgs e)
        //{

        //}



        //private void label17_Click(object sender, EventArgs e)
        //{

        //}

        //private void label10_Click(object sender, EventArgs e)
        //{

        //}

        private void buttAddPatient_Click(object sender, EventArgs e)
        {
            FullName _fullName;
            Patient _newPatient;
            Address _address;
            string _city, _region;
            int _plotNumber, _numbOfPatientCard;



            errorNoSurname.Clear();
            errorNoName.Clear();
            errorNoPolicySeries.Clear();
            errorNoPolicyNumber.Clear();
            errorWrongDate.Clear();
            errorNoStreet.Clear();
            errorNoNumbOfHouse.Clear();
            errorNoNumbOfFlat.Clear();
            errorNoBloodType.Clear();
            errorNoRhFactor.Clear();


            if (textSurname.Text != string.Empty && textName.Text != string.Empty
                && numericPolicySeries.Value != 0 && textPolicyNumb.Text != string.Empty
                && dateTimeDateOfBirth.Value.ToLongDateString() != DateTime.Now.ToLongDateString() && textStreet.Text != string.Empty
                && numericNumbOfHouse.Value != 0 && numericNumbOfFlat.Value != 0
                && comboBoxBloodType.SelectedIndex != -1 && comboBoxRhFactor.SelectedIndex != -1)
            {
                _fullName = new(textSurname.Text, textName.Text, textName.Text);
                if (textCity.Text == string.Empty)
                {
                    _city = "Новосибирск";
                    textCity.Text = _city;             //потом выгружать данные из файла
                }
                else
                    _city = textCity.Text;



                if (textRegion.Text == string.Empty)
                {
                    _region = "Калининский";                        //потом выгружать данные из файла 
                    textRegion.Text = _region;
                }
                else
                    _region = textRegion.Text;


                _address = new(_city, _region, textStreet.Text, (int)numericNumbOfHouse.Value, (int)numericNumbOfFlat.Value);
                _plotNumber = 1;       //потом выгружать данные из файла
                numericPlotNumber.Value = _plotNumber;
                _numbOfPatientCard = 1;                       //длина списка пациентов
                textNumbOfPatientCard.Text = _numbOfPatientCard.ToString();
                _newPatient = new(_fullName, dateTimeDateOfBirth.Value, _address, _plotNumber,
                    _numbOfPatientCard, (int)numericPolicySeries.Value, textPolicyNumb.Text, comboBoxBloodType.SelectedItem.ToString(),
                    comboBoxRhFactor.SelectedItem.ToString(), textBoxAllergies.Text);

                List<Patient> _patients = new()
                {
                    _newPatient
                };
                MessageBox.Show("Добавление пациента успешно выполнено!");
                
                if (!checkNoCloseWindow.Checked) 
                    Close();
                else
                {
                    textSurname.Clear();
                    textName.Clear();
                    numericPolicySeries.Value = 0;
                    textPolicyNumb.Clear();
                    textStreet.Clear();
                    numericNumbOfHouse.Value = 0;
                    numericNumbOfFlat.Value = 0;
                    
                }
            }

            else
            {
                if (textSurname.Text == string.Empty)
                    errorNoSurname.SetError(textSurname, "Поле \"Фамилия\" не заполнено");

                if (textName.Text == string.Empty)
                    errorNoName.SetError(textName, "Поле \"Имя\" не заполнено");

                if (numericPolicySeries.Value == 0)
                    errorNoPolicySeries.SetError(numericPolicySeries, "Поле \"Серия полиса\" не заполнено");

                if (textPolicyNumb.Text == string.Empty)
                    errorNoPolicyNumber.SetError(textPolicyNumb, "Поле \"Номер полиса\" не заполнено");

                if (dateTimeDateOfBirth.Value.ToLongDateString() == DateTime.Now.ToLongDateString())
                    errorWrongDate.SetError(dateTimeDateOfBirth, "Поле \"Дата рождения\" заполнено неверно");

                if (textStreet.Text == string.Empty)
                    errorNoStreet.SetError(textStreet, "Поле \"Улица\" не заполнено");

                if (numericNumbOfHouse.Value == 0)
                    errorNoNumbOfHouse.SetError(numericNumbOfHouse, "Поле \"Дом\" не заполнено");

                if (numericNumbOfFlat.Value == 0)
                    errorNoNumbOfFlat.SetError(numericNumbOfFlat, "Поле \"Квартира\" не заполнено");

                if (comboBoxBloodType.SelectedIndex == -1)
                    errorNoBloodType.SetError(comboBoxBloodType, "Поле \"Группа крови\" не заполнено");

                if (comboBoxRhFactor.SelectedIndex == -1)
                    errorNoRhFactor.SetError(comboBoxRhFactor, "Поле \"Резус-фактор\" не заполнено");


            }












        }
    }
}
