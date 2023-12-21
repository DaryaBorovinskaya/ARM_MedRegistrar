using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM_MedRegistrar.View.AddAppointment
{
    public partial class AddAppointmentForm : Form
    {
        public AddAppointmentForm()
        {
            InitializeComponent();

            comboBoxCabinetOrHome.Items.AddRange(new string[] { "Приём у врача", "Вызов на дом" });
        }


    }
}
