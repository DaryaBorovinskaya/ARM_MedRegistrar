using ARM_MedRegistrar.Presenter;
using ARM_MedRegistrar.View.ChangeDataOfDoctor;
namespace ARM_MedRegistrar.View.Doctors
{
    public partial class DoctorsForm : Form, IDoctorsForm
    {
        Form _form;
        DoctorsPresenter _presenter;
        int _lineOfListViewDoctors;
        uint IDoctorsForm.Id
        {
            set
            {
                listViewDoctors.Items.Add(value.ToString());
            }
        }

        int IDoctorsForm.CountOfLine
        {
            set
            {
                _lineOfListViewDoctors = value;
            }
        }

        string IDoctorsForm.Surname
        {
            get => textSurname.Text;
            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }
        string IDoctorsForm.Name
        {
            get => textName.Text;
            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }
        string? IDoctorsForm.Patronymic
        {
            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }
        string IDoctorsForm.Specialization
        {
            get => comboBoxSpecializations.SelectedItem.ToString();
            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }
        int IDoctorsForm.PlotNumber
        {
            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }
        int IDoctorsForm.Cabinet
        {
            set
            {
                listViewDoctors.Items[_lineOfListViewDoctors].SubItems.Add(value.ToString());
            }
        }

        uint IDoctorsForm.SelectedId
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

        string IDoctorsForm.InfoAboutPatient
        {
            set
            {
                richTextBoxInfoAboutDoctor.Text = value;
            }
        }

        public DoctorsForm(Form form)
        {
            _form = form;
            _form.Hide();
            FormClosed += OnClosed;
            InitializeComponent();

            comboBoxSpecializations.Items.AddRange(new string[] { "терапевт", "педиатр", "врач общей практики", "хирург", "невролог", "оториноларинголог", "офтальмолог", "травматолог", "акушер-гинеколог", "уролог", "инфекционист", "онколог", "гастроэнтеролог", "кардиолог", "эндокринолог" });
            toolTipAllDataAboutDoctors.SetToolTip(buttAllDataAboutDoctor, "Выберите врача из списка, нажав на его ID. \nЗатем нажмите кнопку");
            toolTipRemoveDoctor.SetToolTip(buttRemoveDoctor, "Выберите врача из списка, нажав на его ID. \nЗатем нажмите кнопку");

            _presenter = new(this);
        }

        private void textBox_SpacePress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void textBox_ContainsExceptNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)     //(8 - это Backspace)
                e.KeyChar = '\0';
        }
        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            _form.Visible = true;
        }

        private void buttAddDoctor_Click(object sender, EventArgs e)
        {
            AddDoctorForm addDoctorForm = new();
            addDoctorForm.ShowDialog();
        }

        private void buttSearchDoctor_Click(object sender, EventArgs e)
        {
            listViewDoctors.Items.Clear();
            bool _isError = false;

            errorNoSurname.Clear();
            errorNoName.Clear();
            errorNoSpecialization.Clear();

            if (textSurname.Text == string.Empty)
            {
                _isError = true;
                errorNoSurname.SetError(textSurname, "Поле \"Фамилия\" не заполнено");
            }

            if (textName.Text == string.Empty)
            {
                _isError = true;
                errorNoName.SetError(textName, "Поле \"Имя\" не заполнено");
            }

            if (comboBoxSpecializations.SelectedIndex == -1)
            {
                _isError = true;
                errorNoSpecialization.SetError(comboBoxSpecializations, "Поле \"Специализация\" не заполнено");
            }

            if (!_isError)
            {
                if (!_presenter.SearchDoctor())
                    MessageBox.Show("Врач не найден");
                textSurname.Clear();
                textName.Clear();
                textPatr.Clear();
                comboBoxSpecializations.SelectedIndex = -1;
            }
        }

        private void buttRemovePatient_Click(object sender, EventArgs e)
        {
            uint _selIndex = listViewDoctors.SelectedItems.Count != 0 ? uint.Parse(listViewDoctors.SelectedItems[0].Text) : 0;

            if (_selIndex != 0)
            {
                DialogResult dialogResult = MessageBox.Show($"Подтвердите действие: удаление врача с ID: {_selIndex}", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _presenter.RemoveDoctor();
                    MessageBox.Show("Врач успешно удалён");
                }
            }
        }

        private void buttAllDoctors_Click(object sender, EventArgs e)
        {
            listViewDoctors.Items.Clear();
            if (!_presenter.ShowAllDoctors())
                MessageBox.Show("Список врачей пуст");
        }

        private void buttChangeData_Click(object sender, EventArgs e)
        {
            ChangeDataOfDoctorForm changeDataOfDoctorForm = new();
            changeDataOfDoctorForm.ShowDialog();
        }

        private void buttAllDataAboutDoctor_Click(object sender, EventArgs e)
        {
            richTextBoxInfoAboutDoctor.Clear();

            _presenter.ShowInfoAboutDoctor();
        }
    }
}
