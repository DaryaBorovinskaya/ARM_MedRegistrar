using ARM_MedRegistrar.Presenter.PaidMedServices;

namespace ARM_MedRegistrar.View.PaidMedServices
{
    public partial class PaidMedServicesForm : Form, IPaidMedServicesForm
    {
        Form _form;
        string result;
        PaidMedServicesPresenter _presenter;
        int _lineOfListViewPaidMedServices;

        uint IPaidMedServicesForm.Id
        {
            set
            {
                listViewPaidMedServices.Items.Add(value.ToString());
            }
        }

        int IPaidMedServicesForm.CountOfLine
        {
            set
            {
                _lineOfListViewPaidMedServices = value;
            }
        }

        string IPaidMedServicesForm.SearchingTitle => textSearchingTitle.Text;


        string IPaidMedServicesForm.Title
        {
            get => textTitle.Text;
            set
            {
                listViewPaidMedServices.Items[_lineOfListViewPaidMedServices].SubItems.Add(value);
            }
        }
        decimal IPaidMedServicesForm.Price
        {
            get => numericPrice.Value;  
            set
            {
                listViewPaidMedServices.Items[_lineOfListViewPaidMedServices].SubItems.Add(value.ToString());
            }
        }

        decimal IPaidMedServicesForm.TotalPrice
        {
            set
            {
                textTotalPrice.Text = value.ToString();
            }
        }

        uint IPaidMedServicesForm.SelectedId
        {
            get
            {
                if (listViewPaidMedServices.SelectedItems.Count == 0)
                {
                    return 0;
                }
                return uint.Parse(listViewPaidMedServices.SelectedItems[0].Text);
            }
        }


        public PaidMedServicesForm(Form form)
        {
            _form = form;
            _form.Hide();
            FormClosed += OnClosed;
            InitializeComponent();

            _presenter = new(this);
            _form = form;
        }

        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            _form.Visible = true;
        }

        private void buttSearchPaidMedService_Click(object sender, EventArgs e)
        {
            listViewPaidMedServices.Items.Clear();


            errorNoTitle.Clear();

            if (textSearchingTitle.Text == string.Empty)
                errorNoTitle.SetError(textSearchingTitle, "Поле не заполнено");

            else
            {
                result = _presenter.IsSearchPaidMedService();
                MessageBox.Show(result);
                textSearchingTitle.Clear();
            }
        }

        private void buttAllPaidMedServices_Click(object sender, EventArgs e)
        {
            listViewPaidMedServices.Items.Clear();
            if (!_presenter.ShowAllPaidMedServices())
                MessageBox.Show(_presenter.EmptyList());
        }

        private void buttRemoveMedService_Click(object sender, EventArgs e)
        {
            IList<uint> _selectedId = new List<uint>();
            if (checkIsMultiSelect.Checked)
            {

                if (listViewPaidMedServices.SelectedItems.Count != 0)
                {
                    for (int i = 0; i < listViewPaidMedServices.SelectedItems.Count; i++)
                    {
                        uint selectItemValue = uint.Parse(listViewPaidMedServices.SelectedItems[i].Text);
                        _selectedId.Add(selectItemValue);

                    }

                    string _lineOfId = "";

                    foreach (uint id in _selectedId)
                        _lineOfId += id.ToString() + "  ";



                    DialogResult dialogResult = MessageBox.Show(_presenter.ConfirmationRemove(_lineOfId), " ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        result = _presenter.IsRemovePaidMedService(_selectedId);
                        if (result == string.Empty)
                            MessageBox.Show(_presenter.SuccessRemove());
                        else
                            MessageBox.Show(_presenter.FailureRemove());
                    }

                }
            }


            else
            {
                uint _selIndex = listViewPaidMedServices.SelectedItems.Count != 0 ? uint.Parse(listViewPaidMedServices.SelectedItems[0].Text) : 0;

                if (_selIndex != 0)
                {
                    DialogResult dialogResult = MessageBox.Show($"Подтвердите действие: удаление врача с ID: {_selIndex}", " ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _selectedId.Add(_selIndex);
                        if (_presenter.RemovePaidMedService(_selectedId))
                            MessageBox.Show("Услуга успешно удалена");
                        else
                            MessageBox.Show("Не удалось удалить услугу");
                    }
                }
            }


        }

        private void buttCalculateTotalPrice_Click(object sender, EventArgs e)
        {
            IList<uint> _selectedId = new List<uint>();

            if (listViewPaidMedServices.SelectedItems.Count != 0)
            {
                for (int i = 0; i < listViewPaidMedServices.SelectedItems.Count; i++)
                {
                    uint selectItemValue = uint.Parse(listViewPaidMedServices.SelectedItems[i].Text);
                    _selectedId.Add(selectItemValue);

                }

                if (!_presenter.CalculateTotalPrice(_selectedId))
                    MessageBox.Show("Не удалось посчитать итоговую стоимость");

            }


        }

        private void buttAddPaidMedService_Click(object sender, EventArgs e)
        {


            bool _isError = false;


            errorNoTitle.Clear();
            errorNoPrice.Clear();

            if (textTitle.Text == string.Empty)
            {
                _isError = true;
                errorNoTitle.SetError(textTitle, "Поле не заполнено");
            }

            if (numericPrice.Value == 0)
            {
                _isError = true;
                errorNoTitle.SetError(numericPrice, "Поле не заполнено");
            }


            if (!_isError)
            {
                _presenter.AddPaidMedService();
                textTitle.Clear();
                numericPrice.Value = 0;

                MessageBox.Show("Добавление услуги успешно выполнено!");
            }

        }

        private void numericPrice_ValueChanged(object sender, EventArgs e)
        {
            numericPrice.Maximum = _presenter.MaxPrice();  
        }

        private void checkIsMultiSelect_CheckedChanged(object sender, EventArgs e)
        {
            listViewPaidMedServices.MultiSelect = true;
        }
    }
}
