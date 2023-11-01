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
    public partial class Registration : Form
    {
        Form form;
        public Registration(Form form)
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


        private void Registration_Load(object sender, EventArgs e)
        {

        }
        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
