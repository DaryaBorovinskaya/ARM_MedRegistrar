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
    public partial class MainWindow : Form
    {
        Form form;
        public MainWindow(Form form)
        {

            this.form = form;
            form.Hide();

            InitializeComponent();
            DialogResult = DialogResult.Cancel;

            FormClosed += OnClosed;


        }


        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttAddPatient_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AddPatient newForm = new AddPatient();
            newForm.ShowDialog();
        }

        private void buttAddDoctor_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AddDoctor newForm = new AddDoctor();
            newForm.ShowDialog();
        }


        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
