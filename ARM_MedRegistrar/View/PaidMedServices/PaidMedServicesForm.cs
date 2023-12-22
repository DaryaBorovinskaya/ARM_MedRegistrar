using ARM_MedRegistrar.Presenter;
using ARM_MedRegistrar.View.Doctors;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ARM_MedRegistrar.View.PaidMedServices
{
    public partial class PaidMedServicesForm : Form, IPaidMedServicesForm
    {
        Form _form;
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
            get => numericPrice.Value;  //decimal.Parse(textTotalPrice.Text);
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

        private void buttSearchPaidMedService_Click(object sender, EventArgs e)
        {
            listViewPaidMedServices.Items.Clear();


            errorNoTitle.Clear();

            if (textSearchingTitle.Text == string.Empty)
                errorNoTitle.SetError(textSearchingTitle, "Поле \"Наименование услуги\" не заполнено");

            else
            {
                if (!_presenter.SearchPaidMedService())
                    MessageBox.Show("Услуга не найдена");
                textSearchingTitle.Clear();
            }
        }

        private void buttAllPaidMedServices_Click(object sender, EventArgs e)
        {
            listViewPaidMedServices.Items.Clear();
            if (!_presenter.ShowAllPaidMedServices())
                MessageBox.Show("Список услуг пуст");
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

                    DialogResult dialogResult = MessageBox.Show($"Подтвердите действие: удаление услуг с ID: {_lineOfId}", " ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (_presenter.RemovePaidMedService(_selectedId))
                            MessageBox.Show("Услуги успешно удалены");
                        else
                            MessageBox.Show("Не удалось удалить услуги");
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
                errorNoTitle.SetError(textTitle, "Поле \"Наименование услуги\" не заполнено");
            }

            if (numericPrice.Value == 0)
            {
                _isError = true;
                errorNoTitle.SetError(numericPrice, "Поле \"Цена\" не заполнено");
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
            numericPrice.Maximum = 10000;
        }

        private void checkIsMultiSelect_CheckedChanged(object sender, EventArgs e)
        {
            listViewPaidMedServices.MultiSelect = true;
        }
    }
}
