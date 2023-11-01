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
    public partial class AddDoctor : Form
    {
        Form form;
        public AddDoctor(Form form)
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


        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }


        private void AddDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
