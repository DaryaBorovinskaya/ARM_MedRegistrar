using ARM_MedRegistrar.Presenter;
using ARM_MedRegistrar.View.ChangeDataOfUser;

namespace ARM_MedRegistrar
{
    public partial class ChangeDataOfUserForm : Form, IChangeDataOfUserForm
    {
        Form _form;
        ChangeDataOfUserPresenter _presenter;

        string IChangeDataOfUserForm.OldLogin => textOldLog.Text;

        string IChangeDataOfUserForm.Surname
        {
            get => textSurname.Text;
            set
            {
                textSurname.Text = value;
            }
        }
        string IChangeDataOfUserForm.Name
        {
            get => textName.Text;
            set
            {
                textName.Text = value;
            }
        }
        string IChangeDataOfUserForm.Patronymic
        {
            get => textPatr.Text;
            set
            {
                textPatr.Text = value;
            }
        }

        string IChangeDataOfUserForm.PhoneNumber
        {
            get => textPhoneNumber.Text;
            set
            {
                textPhoneNumber.Text = value;
            }
        }
        string IChangeDataOfUserForm.Post
        {
            get => comboBoxPost.SelectedItem.ToString();
            set
            {
                comboBoxPost.SelectedItem = value;
            }
        }
        string IChangeDataOfUserForm.NewPassword => textNewPassword.Text;

        string IChangeDataOfUserForm.NewLogin
        {
            set
            {
                textNewLog.Text = value;
            }
        }

        public ChangeDataOfUserForm(Form form)
        {
            _form = form;
            _form.Hide();
            FormClosed += OnClosed;
            InitializeComponent();

            _presenter = new(this);
            comboBoxPost.Items.AddRange(new string[] { "медицинский регистратор", "заведующий регистратурой", "главный врач" });
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

        private void buttChangeData_Click(object sender, EventArgs e)
        {

            bool _isError = false;

            errorNoPost.Clear();
            errorNoSurname.Clear();
            errorNoName.Clear();
            errorNoOldLog.Clear();
            errorNoNewLog.Clear();
            errorNoNewPassword.Clear();
            errorNoPhoneNumber.Clear();

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

            if (textPatr.Text == string.Empty)
            {
                _isError = true;
                errorNoOldLog.SetError(textOldLog, "Поле не заполнено");
            }


            if (textNewLog.Text == string.Empty)
            {
                _isError = true;
                errorNoNewLog.SetError(textNewLog, "Поле не заполнено");
            }

            if (textNewPassword.Text == string.Empty)
            {
                _isError = true;
                errorNoNewPassword.SetError(textNewPassword, "Поле не заполнено");
            }
            if (textPhoneNumber.Text == string.Empty)
            {
                _isError = true;
                errorNoPhoneNumber.SetError(textPhoneNumber, "Поле не заполнено");
            }

            if (!_isError)
            {
                textPhoneNumber.Text = textBoxWithoutNullInBeginning(textPhoneNumber);
                if (_presenter.SaveChanges())
                {
                    MessageBox.Show("Данные успешно обновлены");
                    Close();
                }
                else
                    MessageBox.Show("Не удалось внести изменения");
            }

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


        private void checkViewNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkViewNewPassword.Checked)
                textNewPassword.UseSystemPasswordChar = false;

            else
                textNewPassword.UseSystemPasswordChar = true;
        }



        private void buttSearch_Click(object sender, EventArgs e)
        {
            buttChangeData.Enabled = true;
            errorNoOldLog.Clear();

            if (textOldLog.Text == string.Empty)
                errorNoOldLog.SetError(textOldLog, "Поле не заполнено");

            else
            {
                textOldLog.Text = textBoxWithoutNullInBeginning(textOldLog);
                if (!_presenter.ShowDataAboutPatient())
                {
                    textOldLog.ReadOnly = false;
                    MessageBox.Show($"Не удалось найти ");
                }
                else
                    textOldLog.ReadOnly = true;
            }
        }

        private void buttRemoveUser_Click(object sender, EventArgs e)
        {
            if (_presenter.RemoveUser())
                MessageBox.Show("Удаление выполнено успешно");
            else
                MessageBox.Show("Не удалось удалить");

        }
    }
}
