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
        public string login, password;



        public Entrance()
        {
            InitializeComponent();
        }


        string[] doctSpecializations = new string[] { "терапевт", "хирург", "невролог",
            "оториноларинголог", "офтальмолог",
            "травматолог", "акушер-гинеколог", "уролог", "инфекционист",
            "онколог", "гастроэнтеролог", "кардиолог", "эндокринолог"};

        private void buttEntrance_Click(object sender, EventArgs e)
        {
            login = textLog.Text;
            password = textPassword.Text;
            this.Hide();
            MainWindow newForm = new MainWindow();
            newForm.Show();


        }



        private void buttonExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();        //закрытие всех окон

        }

        
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration newForm = new Registration();
            newForm.Show();
        }


    }
}
