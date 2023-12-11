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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ARM_MedRegistrar
{
    public partial class MainWindowForm : Form
    {
        Form form;
        public MainWindowForm(Form form)
        {

            this.form = form;
            form.Hide();

            InitializeComponent();
            DialogResult = DialogResult.Cancel;

            FormClosed += OnClosed;

            textFullNameOfRegistr.Text = "Aлимова Н П";         //из файла (данные User)





            
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


        private void buttSearchDoctor_Click(object sender, EventArgs e)
        {
            
        }

        private void buttAddresses_Click(object sender, EventArgs e)
        {

            AttachedStreetsForm newForm = new();
            newForm.ShowDialog();


        }
    }
}
