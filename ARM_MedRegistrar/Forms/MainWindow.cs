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
        public MainWindow()
        {
            InitializeComponent();
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
            newForm.Show();
        }

        private void buttAddDoctor_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AddDoctor newForm = new AddDoctor();
            newForm.Show();
        }
    }
}
