
using ARM_MedRegistrar.Model.AttachedStreets;
using ARM_MedRegistrar.Model.Json.JsonRepository;


namespace ARM_MedRegistrar.View
{
    public partial class AttachedStreetsForm : Form
    {
        public AttachedStreetsForm()
        {
            InitializeComponent();

        }

        private void textCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void textRegion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }


        private void textStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }


        private void buttOpenFile_Click(object sender, EventArgs e)
        {




        }

        private void buttAddDataToFile_Click(object sender, EventArgs e)
        {
            AttachedStreets _newAttachedStreet;
            JsonAttachedStreetsRepository jsonAttachedStreetsRepository = new("attachedStreets.json");
            IList<IAttachedStreets>? _attachedStreets;

            listBoxAttachedStreets.Items.Clear();
            errorNoStreet.Clear();
            errorNoCity.Clear();
            errorNoRegion.Clear();

            _attachedStreets = jsonAttachedStreetsRepository.GetAll();

            if (_attachedStreets == null)
            {
                if (textStreet.Text != string.Empty && textCity.Text != string.Empty
                    && textRegion.Text != string.Empty)
                {
                    _newAttachedStreet = new(textCity.Text, textRegion.Text, textStreet.Text);
                    jsonAttachedStreetsRepository.Add(_newAttachedStreet);

                    MessageBox.Show("Успешно добавлено");
                }
                else
                {
                    if (textCity.Text == string.Empty)
                        errorNoCity.SetError(textCity, "Поле \"Город\" не заполнено");

                    if (textRegion.Text == string.Empty)
                        errorNoRegion.SetError(textRegion, "Поле \"Регион\" не заполнено");

                    if (textStreet.Text == string.Empty)
                        errorNoStreet.SetError(textStreet, "Поле \"Улица\" не заполнено");
                }

            }

            else
            {
                if (textStreet.Text != string.Empty)
                {

                    if (textCity.Text == string.Empty)
                        textCity.Text = _attachedStreets[0].City;

                    if (textRegion.Text == string.Empty)
                        textRegion.Text = _attachedStreets[0].Region;

                    _newAttachedStreet = new(textCity.Text, textRegion.Text, textStreet.Text);
                    jsonAttachedStreetsRepository.Add(_newAttachedStreet);

                    IList<IAttachedStreets>? _printAttachedStreets = jsonAttachedStreetsRepository.GetAll();

                    foreach (var item in _printAttachedStreets)
                        listBoxAttachedStreets.Items.Add("улица " + item.Street);

                    MessageBox.Show("Успешно добавлено");
                }
                else
                    errorNoStreet.SetError(textStreet, "Поле \"Улица\" не заполнено");
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
    }
}
