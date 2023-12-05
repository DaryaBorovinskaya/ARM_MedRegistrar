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

namespace ARM_MedRegistrar
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {

            InitializeComponent();

        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }
        private void AddPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void textSurname_TextChanged(object sender, EventArgs e)
        {

        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBloodType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void listBoxAllergies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericNumbOfHouse_ValueChanged(object sender, EventArgs e)
        {
            numericNumbOfFlat.Minimum = 0;
            numericNumbOfFlat.Maximum = 5000;
        }

        private void numericNumbOfFlat_ValueChanged(object sender, EventArgs e)
        {
            
            numericNumbOfFlat.Maximum = 5000;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericPolicySeries_ValueChanged(object sender, EventArgs e)
        {
            numericPolicySeries.Maximum = 9999;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericNumbOfPatientCard_ValueChanged(object sender, EventArgs e)
        {
            numericNumbOfPatientCard.Maximum = int.MaxValue;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void buttAddPatient_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добавление пациента успешно выполнено!");
            Close();
        }
    }
}
