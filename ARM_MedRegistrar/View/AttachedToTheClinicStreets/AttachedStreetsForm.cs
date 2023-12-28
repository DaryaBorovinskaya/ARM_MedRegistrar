using ARM_MedRegistrar.Presenter;
using ARM_MedRegistrar.View.AttachedToTheClinicStreets;

namespace ARM_MedRegistrar.View
{
    public partial class AttachedStreetsForm : Form, IAttachedStreetsForm
    {
        AttachedStreetsPresenter _presenter;
        string result;

        string IAttachedStreetsForm.City => textCity.Text;

        string IAttachedStreetsForm.Region => textRegion.Text;

        string IAttachedStreetsForm.Street => textStreet.Text;

        int IAttachedStreetsForm.NumbOfHouse => int.Parse(textNumbOfHouse.Text);

        string IAttachedStreetsForm.AllAttStreets { set => richTextBoxAttStreets.Text = value; }

        public AttachedStreetsForm()
        {
            InitializeComponent();
            _presenter = new(this);
            result = _presenter.CheckAccessLevel();
            if (result != string.Empty)
            {
                buttAddDataToFile.Visible = false;
                buttRemoveDataToFile.Visible = false;
                label2.Visible = false;
                label14.Visible = false;
                label13.Visible = false;
                label12.Visible = false;
                label3.Visible = false;
                textCity.Visible = false;
                textRegion.Visible = false; 
                textStreet.Visible = false;
                textNumbOfHouse.Visible = false;
            }
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
                result = _presenter.AddAttStreets();
                if (result == string.Empty)
                    MessageBox.Show(_presenter.SuccessAdd());
                else
                    MessageBox.Show(result);
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
                result = _presenter.DeleteAttStreets();
                if (result == string.Empty)
                    MessageBox.Show(_presenter.SuccessRemove());
                else
                    MessageBox.Show(_presenter.FailureRemove());
                textStreet.Clear();
                textNumbOfHouse.Clear();
            }
            
           
        }

        private void buttAllAttStreets_Click(object sender, EventArgs e)
        {
            richTextBoxAttStreets.Clear();
            result = _presenter.AllAttStreets();
            if (result != string.Empty)
                MessageBox.Show(result);
        }
    }
}
