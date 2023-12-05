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
    public partial class Entrance : Form
    {
        private string _login, _password;


        public Entrance()
        {

            InitializeComponent();


        }



        

        private void buttEntrance_Click(object sender, EventArgs e)
        {
            errorNoLog.Clear();
            errorNoPassword.Clear();
            _login = textLog.Text;
            _password = textPassword.Text;

            if (_login != string.Empty && _password != string.Empty)
            {

                MainWindow newForm = new MainWindow(this);
                if (newForm.ShowDialog() == DialogResult.OK) Close();

            }

            else
            {
                if (_login == string.Empty)
                    errorNoLog.SetError(textLog, "Поле \"Логин\" не заполнено");


                if (_password == string.Empty)

                    errorNoPassword.SetError(textPassword, "Поле \"Пароль\" не заполнено");
            }



        }


        private void buttonRegistration_Click(object sender, EventArgs e)
        {

            Registration newForm = new Registration(this);
            if (newForm.ShowDialog() == DialogResult.OK) Close();
        }

        private void Entrance_Load(object sender, EventArgs e)
        {

        }
        private void Entrance_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void checkViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkViewPassword.Checked)
                textPassword.UseSystemPasswordChar = false;

            else
                textPassword.UseSystemPasswordChar = true;
        }
    }
}
