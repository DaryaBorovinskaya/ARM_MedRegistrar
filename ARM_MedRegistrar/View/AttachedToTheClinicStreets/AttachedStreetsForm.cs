

using ARM_MedRegistrar.Data.Json.Lists.AttachedStreets;
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





        private void buttAddDataToFile_Click(object sender, EventArgs e)
        {
            AttachedStreets _newAttachedStreet;
            IAttachedStreetsRepository jsonAttachedStreetsRepository = new JsonAttachedStreetsRepository();
            IList<IAttachedStreets>? _attachedStreets;

            bool _isError = false;

            listBoxAttachedStreets.Items.Clear();
            errorNoStreet.Clear();
            errorNoCity.Clear();
            errorNoRegion.Clear();
            errorNoNumbOfHouse.Clear();

            _attachedStreets = jsonAttachedStreetsRepository.GetAll();

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

                if (numericNumbOfHouse.Value == 0)
                {
                    _isError = true;
                    errorNoNumbOfHouse.SetError(numericNumbOfHouse, "Поле \"Номер дома\" не заполнено");
                }

                if (!_isError)
                {
                    _newAttachedStreet = new(textCity.Text, textRegion.Text, textStreet.Text, (int)numericNumbOfHouse.Value);
                    jsonAttachedStreetsRepository.Add(_newAttachedStreet);

                    MessageBox.Show("Успешно добавлено");
                }
            }

            else
            {
                if (textStreet.Text == string.Empty)
                {
                    _isError = true;
                    errorNoStreet.SetError(textStreet, "Поле \"Улица\" не заполнено");
                }

                if (numericNumbOfHouse.Value == 0)
                {
                    _isError = true;
                    errorNoNumbOfHouse.SetError(numericNumbOfHouse, "Поле \"Номер дома\" не заполнено");
                }

                if (!_isError)
                {

                    if (textCity.Text == string.Empty)
                        textCity.Text = _attachedStreets[0].City;

                    if (textRegion.Text == string.Empty)
                        textRegion.Text = _attachedStreets[0].Region;

                    _newAttachedStreet = new(textCity.Text, textRegion.Text, textStreet.Text, (int)numericNumbOfHouse.Value);
                    jsonAttachedStreetsRepository.Add(_newAttachedStreet);

                    IList<IAttachedStreets>? _printAttachedStreets = jsonAttachedStreetsRepository.GetAll();

                    foreach (var item in _printAttachedStreets)
                        listBoxAttachedStreets.Items.Add("улица " + item.Street);

                    MessageBox.Show("Успешно добавлено");
                }

            }

        }

        private void checkRemembCity_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void AttachedStreetsForm_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericNumbOfHouse.Maximum = 10000;
        }
    }
}
