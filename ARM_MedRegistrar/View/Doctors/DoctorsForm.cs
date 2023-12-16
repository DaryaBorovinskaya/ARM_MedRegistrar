using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARM_MedRegistrar.View.SearchAndRemoveDoctor;

namespace ARM_MedRegistrar.View.Doctors
{
    public partial class DoctorsForm : Form
    {
        Form _form;
        public DoctorsForm(Form form)
        {
            _form = form;
            _form.Hide();
            FormClosed += OnClosed;
            InitializeComponent();
        }


        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            _form.Visible = true;
            //DialogResult = DialogResult.OK;
        }

        private void DoctorsForm_Load(object sender, EventArgs e)
        {

        }

        private void buttAddDoctor_Click(object sender, EventArgs e)
        {
            AddDoctorForm addDoctorForm = new();
            addDoctorForm.ShowDialog();
        }

        private void buttSearchAndRemoveDoctor_Click(object sender, EventArgs e)
        {
            SearchAndRemoveDoctorForm searchAndRemoveDoctorForm = new();
            searchAndRemoveDoctorForm.ShowDialog();
        }
    }
}
