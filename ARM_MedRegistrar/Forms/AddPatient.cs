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
        Form form;
        public AddPatient(Form form)
        {
            this.form = form;
            form.Hide();

            InitializeComponent();

            FormClosed += OnClosed;
        }

        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            form.Visible = true;
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }
        private void AddPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
