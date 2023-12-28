using ARM_MedRegistrar.Presenter;
using ARM_MedRegistrar.View.AttachedToTheClinicStreets;

namespace ARM_MedRegistrar.View
{
    public partial class AttachedStreetsForm : Form, IAttachedStreetsForm
    {
        AttachedStreetsPresenter _presenter;

        string IAttachedStreetsForm.City => textCity.Text;

        string IAttachedStreetsForm.Region => textRegion.Text;

        string IAttachedStreetsForm.Street => textStreet.Text;

        int IAttachedStreetsForm.NumbOfHouse => int.Parse(textNumbOfHouse.Text);

        string IAttachedStreetsForm.AllAttStreets { set => richTextBoxAttStreets.Text = value; }

        public AttachedStreetsForm()
        {
            InitializeComponent();
            _presenter = new(this);
        }

        private string textBoxWithoutNullInBeginning(TextBox textBox)
        {
            string _newTextOfTextBox = textBox.Text;
            int _length = _newTextOfTextBox.Length;
            if (_newTextOfTextBox[0] == '0')
            {
                if (_length == 1)
                    _newTextOfTextBox = "1";
                else
                    _newTextOfTextBox = _newTextOfTextBox.Remove(0, 1);
            }
            return _newTextOfTextBox;
        }

        private void buttAddDataToFile_Click(object sender, EventArgs e)
        {
            bool _isError = false;
            errorNoStreet.Clear();
            errorNoCity.Clear();
            errorNoRegion.Clear();
            errorNoNumbOfHouse.Clear();

            if (textCity.Text == string.Empty)
            {
                _isError = true;
                errorNoCity.SetError(textCity, "Поле не заполнено");
            }

            if (textRegion.Text == string.Empty)
            {
                _isError = true;
                errorNoRegion.SetError(textRegion, "Поле не заполнено");
            }

            if (textStreet.Text == string.Empty)
            {
                _isError = true;
                errorNoStreet.SetError(textStreet, "Поле не заполнено");
            }

            if (textNumbOfHouse.Text == string.Empty)
            {
                _isError = true;
                errorNoNumbOfHouse.SetError(textNumbOfHouse, "Поле не заполнено");
            }

            if (!_isError)
            {
                textNumbOfHouse.Text = textBoxWithoutNullInBeginning(textNumbOfHouse);
                _presenter.AddAttStreets();
                MessageBox.Show("Успешно добавлено");
                textStreet.Clear();
                textNumbOfHouse.Clear();
            }


        }

        private void buttRemoveDataToFile_Click(object sender, EventArgs e)
        {
            bool _isError = false;
            errorNoStreet.Clear();
            errorNoCity.Clear();
            errorNoRegion.Clear();
            errorNoNumbOfHouse.Clear();

            if (textCity.Text == string.Empty)
            {
                _isError = true;
                errorNoCity.SetError(textCity, "Поле не заполнено");
            }

            if (textRegion.Text == string.Empty)
            {
                _isError = true;
                errorNoRegion.SetError(textRegion, "Поле не заполнено");
            }

            if (textStreet.Text == string.Empty)
            {
                _isError = true;
                errorNoStreet.SetError(textStreet, "Поле не заполнено");
            }

            if (textNumbOfHouse.Text == string.Empty)
            {
                _isError = true;
                errorNoNumbOfHouse.SetError(textNumbOfHouse, "Поле не заполнено");
            }

            if (!_isError)
            {
                textNumbOfHouse.Text = textBoxWithoutNullInBeginning(textNumbOfHouse);
                if (_presenter.DeleteAttStreets())
                    MessageBox.Show("Удаление выполнено успешно");
                else
                    MessageBox.Show("Не удалось удалить");
                textStreet.Clear();
                textNumbOfHouse.Clear();
            }
        }

        private void buttAllAttStreets_Click(object sender, EventArgs e)
        {
            richTextBoxAttStreets.Clear();
            _presenter.AllAttStreets();
        }
    }
}
