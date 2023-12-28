using ARM_MedRegistrar.Presenter.Doctors;
using ARM_MedRegistrar.View.ChangeDataOfDoctor;
namespace ARM_MedRegistrar.View.Doctors
{
    public partial class DoctorsForm : Form, IDoctorsForm
    {
        Form _form;
        string result;
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

        string IDoctorsForm.InfoAboutDoctor
        {
            set
            {
                richTextBoxInfoAboutDoctor.Text = value;
            }
        }

        public Func<string>? OnDoctorWhoFind; 
        public DoctorsForm(Form form)
        {
            _form = form;
            _form.Hide();
            FormClosed += OnClosed;
            InitializeComponent();

            _presenter = new(this);
            comboBoxSpecializations.Items.AddRange(_presenter.SetSpecialization().ToArray());
            result = _presenter.CheckAccessLevel();
            if (result != string.Empty)
            {
                buttAddDoctor.Visible = false;
                buttRemoveDoctor.Visible = false;
                checkIsMultiSelect.Visible = false;
                buttChangeData.Visible = false;
            }
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
                errorNoSurname.SetError(textSurname, "Поле не заполнено");
            }

            if (textName.Text == string.Empty)
            {
                _isError = true;
                errorNoName.SetError(textName, "Поле не заполнено");
            }

            if (comboBoxSpecializations.SelectedIndex == -1)
            {
                _isError = true;
                errorNoSpecialization.SetError(comboBoxSpecializations, "Поле не заполнено");
            }

            if (!_isError)
            {
                result = _presenter.SearchDoctor();
                if (result != string.Empty)
                    MessageBox.Show(result);
                textSurname.Clear();
                textName.Clear();
                textPatr.Clear();
                comboBoxSpecializations.SelectedIndex = -1;
            }
        }

        private void buttRemoveDoctor_Click(object sender, EventArgs e)
        {
            IList<uint> _selectedId = new List<uint>();
            if (checkIsMultiSelect.Checked)
            {
                if (listViewDoctors.SelectedItems.Count != 0)
                {
                    for (int i = 0; i < listViewDoctors.SelectedItems.Count; i++)
                    {
                        uint selectItemValue = uint.Parse(listViewDoctors.SelectedItems[i].Text);
                        _selectedId.Add(selectItemValue);

                    }

                    string _lineOfId = "";

                    foreach (uint id in _selectedId)
                        _lineOfId += id.ToString() + "  ";

                    DialogResult dialogResult = MessageBox.Show(_presenter.ConfirmationRemove(_lineOfId), " ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        result = _presenter.RemoveDoctor(_selectedId);
                        if (result == string.Empty)
                            MessageBox.Show(_presenter.SuccessRemove());
                        else
                            MessageBox.Show(_presenter.FailureRemove());
                    }

                }
            }


            else
            {


                uint _selIndex = listViewDoctors.SelectedItems.Count != 0 ? uint.Parse(listViewDoctors.SelectedItems[0].Text) : 0;

                if (_selIndex != 0)
                {
                    DialogResult dialogResult = MessageBox.Show(_presenter.ConfirmationRemove(_selIndex.ToString()), " ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _selectedId.Add(_selIndex);
                        result = _presenter.RemoveDoctor(_selectedId);
                        if (result == string.Empty)
                            MessageBox.Show(_presenter.SuccessRemove());
                        else
                            MessageBox.Show(_presenter.FailureRemove());
                    }
                }
            }
        }
        private void buttAllDoctors_Click(object sender, EventArgs e)
        {
            listViewDoctors.Items.Clear();
            result = _presenter.ShowAllDoctors();
            if (result != string.Empty)
                MessageBox.Show(_presenter.EmptyList());
        }

        private void buttChangeData_Click(object sender, EventArgs e)
        {
            ChangeDataOfDoctorForm changeDataOfDoctorForm = new();
            changeDataOfDoctorForm.ShowDialog();
        }

        private void buttAllDataAboutDoctor_Click(object sender, EventArgs e)
        {
            errorMultiSelect.Clear();
            if (!checkIsMultiSelect.Checked)
            {
                richTextBoxInfoAboutDoctor.Clear();

                result = _presenter.ShowInfoAboutDoctor();
                if (result != string.Empty)
                    MessageBox.Show(result);
            }
            else
                errorMultiSelect.SetError(checkIsMultiSelect, _presenter.MultiSelect());

        }

        private void checkIsMultiSelect_CheckedChanged(object sender, EventArgs e)
        {
            listViewDoctors.MultiSelect = true;
        }

    }
}
