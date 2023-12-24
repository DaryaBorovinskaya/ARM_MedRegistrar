

using ARM_MedRegistrar.Data.Json.Dictionaries;
using ARM_MedRegistrar.Data.Json.Dictionaries.AttachedStreets;
using ARM_MedRegistrar.Model.AttachedStreets;


namespace ARM_MedRegistrar.View
{
    public partial class AttachedStreetsForm : Form
    {
        public AttachedStreetsForm()
        {
            InitializeComponent();

        }

        private void textBox_SpacePress(object sender, KeyPressEventArgs e)
        {
            //char ch = e.KeyChar;

            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }


        private void textBox_ContainsExceptNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)     //(8 - это Backspace)
                e.KeyChar = '\0';
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
            AttachedStreets _newAttachedStreet;
            IBaseWithIdRepository<uint, IAttachedStreets> jsonAttachedStreetsRepository = new JsonAttachedStreetsRepository();
            IDictionary<uint,IAttachedStreets>? _attachedStreets;

            bool _isError = false;

            listBoxAttachedStreets.Items.Clear();
            errorNoStreet.Clear();
            errorNoCity.Clear();
            errorNoRegion.Clear();
            errorNoNumbOfHouse.Clear();

            _attachedStreets = jsonAttachedStreetsRepository.Read();

            if (_attachedStreets == null)
            {
                if (textCity.Text == string.Empty)
                {
                    _isError = true;
                    errorNoCity.SetError(textCity, "Поле \"Город\" не заполнено");
                }

                if (textRegion.Text == string.Empty)
                {
                    _isError = true;
                    errorNoRegion.SetError(textRegion, "Поле \"Регион\" не заполнено");
                }

                if (textStreet.Text == string.Empty)
                {
                    _isError = true;
                    errorNoStreet.SetError(textStreet, "Поле \"Улица\" не заполнено");
                }

                if (textNumbOfHouse.Text == string.Empty)
                {
                    _isError = true;
                    errorNoNumbOfHouse.SetError(textNumbOfHouse, "Поле \"Номер дома\" не заполнено");
                }

                

                if (!_isError)
                {
                    textNumbOfHouse.Text = textBoxWithoutNullInBeginning(textNumbOfHouse);

                    //_newAttachedStreet = new(textCity.Text, textRegion.Text, textStreet.Text, (int)numericNumbOfHouse.Value);
                    //jsonAttachedStreetsRepository.Add(_newAttachedStreet);

                    MessageBox.Show("Успешно добавлено");
                    textCity.Clear();
                    textRegion.Clear();
                    textStreet.Clear();
                    textNumbOfHouse.Clear();
                }
            }

            else
            {
                if (textStreet.Text == string.Empty)
                {
                    _isError = true;
                    errorNoStreet.SetError(textStreet, "Поле \"Улица\" не заполнено");
                }

                if (textNumbOfHouse.Text == string.Empty)
                {
                    _isError = true;
                    errorNoNumbOfHouse.SetError(textNumbOfHouse, "Поле \"Номер дома\" не заполнено");
                }

                if (!_isError)
                {

                    if (textCity.Text == string.Empty)
                        textCity.Text = _attachedStreets[0].AddressOfBuilding.City;

                    if (textRegion.Text == string.Empty)
                        textRegion.Text = _attachedStreets[0].AddressOfBuilding.Region;

                    //_newAttachedStreet = new(textCity.Text, textRegion.Text, textStreet.Text, (int)numericNumbOfHouse.Value);
                    //jsonAttachedStreetsRepository.Add(_newAttachedStreet);

                    IDictionary<uint,IAttachedStreets>? _printAttachedStreets = jsonAttachedStreetsRepository.Read();
                    if (_printAttachedStreets != null)
                    {
                        foreach (var item in _printAttachedStreets.Values)
                            listBoxAttachedStreets.Items.Add("улица " + item.AddressOfBuilding.Street);
                    }
                    MessageBox.Show("Успешно добавлено");
                    textCity.Clear();
                    textRegion.Clear();
                    textStreet.Clear();
                    textNumbOfHouse.Clear();
                }

            }

        }

    }
}
