
using ARM_MedRegistrar.Presenter;
using Newtonsoft.Json.Linq;

namespace ARM_MedRegistrar.View.AddAppointment
{
    public partial class AddAppointmentForm : Form, IAddAppointmentForm
    {
        Form form;
        int _lineOfListViewDoctors;
        int _lineOfListViewPatients;
        AddAppointmentPresenter _presenter;
        uint IAddAppointmentForm.DoctorId
        {
            set
            {
                listViewDoctors.Items.Add(value.ToString());
            }
        }
        int IAddAppointmentForm.DoctorCountOfLine
        {
            set
            {
                _lineOfListViewDoctors = value;
            }
        }
        string IAddAppointmentForm.DoctorSurname
        {

            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }
        string IAddAppointmentForm.DoctorName
        {

            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }
        string? IAddAppointmentForm.DoctorPatronymic
        {
            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }
        string IAddAppointmentForm.DoctorSpecialization
        {
            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }
        string IAddAppointmentForm.DoctorWorkSchedule
        {
            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }

        int IAddAppointmentForm.DoctorPlotNumber
        {
            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }
        int IAddAppointmentForm.DoctorCabinet
        {
            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }

        uint IAddAppointmentForm.DoctorSelectedId
        {
            get
            {
                if (listViewDoctors.SelectedItems.Count == 0)
                {
                    return 0;
                }
                return uint.Parse(listViewDoctors.SelectedItems[0].Text);
            }
        }

        uint IAddAppointmentForm.PatientId
        {
            set
            {
                listViewPatients.Items.Add(value.ToString());
            }
        }
        int IAddAppointmentForm.PatientCountOfLine
        {
            set
            {
                _lineOfListViewPatients = value;
            }
        }

        string IAddAppointmentForm.PatientSurname
        {

            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }
        string IAddAppointmentForm.PatientName
        {

            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }
        string? IAddAppointmentForm.PatientPatronymic
        {
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }
        string IAddAppointmentForm.PatientDateOfBirth
        {
            set
            {
                listViewPatients.Items[_lineOfListViewPatients].SubItems.Add(value);
            }
        }

        uint IAddAppointmentForm.PatientSelectedId
        {
            get
            {
                if (listViewPatients.SelectedItems.Count == 0)
                {
                    return 0;
                }
                return uint.Parse(listViewPatients.SelectedItems[0].Text);
            }
        }

        DateTime IAddAppointmentForm.DayOfAppointment => dateTimePickerDateOfAppointment.Value;

        DateTime IAddAppointmentForm.TimeOfAppointment => dateTimePickerTimeOfAppointment.Value;
        

        public AddAppointmentForm()
        {
            InitializeComponent();

            comboBoxCabinetOrHome.Items.AddRange(new string[] { "Первичный приём у врача", "Вторичный приём у врача", "Вызов на дом" });

            _presenter = new(this);

        }

        private void buttAllPatients_Click(object sender, EventArgs e)
        {
            listViewPatients.Items.Clear();
            if (!_presenter.ShowAllPatients())
                MessageBox.Show("Список пациентов пуст");
        }

        private void buttAllDoctors_Click(object sender, EventArgs e)
        {
            listViewDoctors.Items.Clear();
            if (!_presenter.ShowAllDoctors())
                MessageBox.Show("Список врачей пуст");
        }

        private void buttWorkingDoctors_Click(object sender, EventArgs e)
        {
            if (!_presenter.WorkingDoctors())
                MessageBox.Show("В указанные день и время ни один из врачей не имеет свободной записи");
        }
    }
}
