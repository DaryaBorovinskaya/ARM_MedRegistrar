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





            //ListViewItem listViewDoctors = new();

            //listViewDoctors.SubItems.Add("Морская Д. Т.");
            //listViewDoctors.SubItems.Add("Неважная Д. Т.");
            //listViewDoctors.SubItems.Add("Нужная Д. Т.");
        }


        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }


        //private void MainWindow_Load(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

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
            //listViewDoctors.Columns.Add(new ColumnHeader());
            //listViewDoctors.Columns[0].Text = "Column 1";
            //listViewDoctors.Columns.Add(new ColumnHeader());
            //listViewDoctors.Columns[1].Text = "Column 2";
            //listViewDoctors.Columns.Add(new ColumnHeader());
            //listViewDoctors.Columns[2].Text = "Column 3";

            //ListViewItem listViewItem1 = new(new string[] { "Banana", "a", "b" });
            //ListViewItem listViewItem2 = new(new string[] { "Apple", "c", "d" });
            //ListViewItem listViewItem3 = new(new string[] { "Grape", "e", "f" });
            //listViewDoctors.Items.AddRange(new ListViewItem[] {listViewItem1,
            //    listViewItem2,
            //    listViewItem3 });
        }

        private void buttAddresses_Click(object sender, EventArgs e)
        {

            AttachedStreetsForm newForm = new();
            newForm.ShowDialog();


        }
    }
}
