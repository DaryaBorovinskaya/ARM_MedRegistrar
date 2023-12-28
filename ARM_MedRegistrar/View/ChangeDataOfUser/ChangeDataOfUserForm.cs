using ARM_MedRegistrar.Presenter.ChangeDataOfUsers;
using ARM_MedRegistrar.View.ChangeDataOfUser;

namespace ARM_MedRegistrar
{
    public partial class ChangeDataOfUserForm : Form, IChangeDataOfUserForm
    {
        Form _form;
        string result;
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
                textPost.Text = value;
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
            comboBoxPost.Items.AddRange(_presenter.SetPost().ToArray());
        }

        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            _form.Visible = true;
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

            if (comboBoxPost.SelectedIndex == -1)
            {
                _isError = true;
                errorNoPost.SetError(comboBoxPost, "Поле не заполнено");
            }

            if (!_isError)
            {
                result = _presenter.SaveChanges();
                if (result == string.Empty)
                {
                    MessageBox.Show(_presenter.Success());
                    Close();
                }
                else
                    MessageBox.Show(result);
                textOldLog.Enabled = true;
            }

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
            textOldLog.Enabled = false;
            buttChangeData.Enabled = true;
            errorNoOldLog.Clear();

            if (textOldLog.Text == string.Empty)
                errorNoOldLog.SetError(textOldLog, "Поле не заполнено");

            else
            {
                result = _presenter.IsSuccessSearch();
                if (result == string.Empty)
                    textOldLog.ReadOnly = false;

                else
                {
                    MessageBox.Show(_presenter.FailureSearch());
                    textOldLog.ReadOnly = true;
                }
            }
        }

        private void buttRemoveUser_Click(object sender, EventArgs e)
        {
            result = _presenter.IsRemoveUser();
            if (result == string.Empty)
                MessageBox.Show(_presenter.SuccessRemove());
            else
                MessageBox.Show(_presenter.FailureRemove());

        }
    }
}
